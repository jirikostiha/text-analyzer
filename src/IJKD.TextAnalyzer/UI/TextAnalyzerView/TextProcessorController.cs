namespace IJKD.TextAnalyzer.UI.TextAnalyzerView
{
    using System;
    using System.ComponentModel;
    using System.IO;
    using BusinessLogic;
    using Exceptions;

    public class TextProcessorController : IController<ITextProcessorView>
    {
        public ITextProcessorView View { get; set; }

        public BackgroundWorker Worker { get; private set; }

        public void Run(string inputFile, string outputFile)
        {
            inputFile.NotNull().NotEmpty();
            outputFile.NotNull().NotEmpty();

            var tuple = new Tuple<string, string>(inputFile, outputFile);

            InitializeBackgroundWorker();
            Worker.RunWorkerAsync(tuple);
        }

        public void Stop()
        {
            Worker.CancelAsync();
        }

        #region private methods

        private void InitializeBackgroundWorker()
        {
            Worker = new BackgroundWorker();
            Worker.DoWork += DoWork;
            Worker.RunWorkerCompleted += AnalysisCompleted;
            Worker.ProgressChanged += AnalysisProgressChanged;
            Worker.WorkerReportsProgress = true;
            Worker.WorkerSupportsCancellation = true;
        }

        /// <summary>
        /// Creates and configure text processor.
        /// </summary>
        /// <returns>text processor</returns>
        //NOTE: mozno udelat pomoci Factory
        private ITextProcessor CreateProcessor()
        {
            var analyzer = new Analyzer()
                               {
                                   LineBreakCounter = new LineBreakCounter(),
                                   PrintableCharCounter = new PrintableCharCounter(),
                                   WordCounter = new WordCounter(),
                                   SentenceCounter = new SentenceCounter()
                               };

            var converter = new CharacterConverter();
            converter.Modificators.Add(new DiacriticRemover());
            converter.Modificators.Add(new EmptyLineRemover());
            converter.Modificators.Add(new PunctationRemover());
            converter.Modificators.Add(new SpaceRemover());

            var processor = new OnePassTextProcessor()
                                {
                                    Analyzer = analyzer,
                                    Converter = converter
                                };

            return processor;
        }

        private void DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            if (worker == null) { return; }

            e.Result = ProcessFile(worker, e);
        }

        private AnalysisResult ProcessFile(BackgroundWorker worker, DoWorkEventArgs e)
        {
            var fileTuple = e.Argument as Tuple<string, string>;
            if (fileTuple == null) return null;

            var inputFilePath = fileTuple.Item1;
            var outputFilePath = fileTuple.Item2;

            // read input file text
            var data = FileHelper.LoadAllText(inputFilePath);

            var processor = CreateProcessor();
            var runner = new Runner(data, processor);

            while (runner.MoveNext())
            {
                //append to output file
                using (var sw = File.AppendText(outputFilePath))
                {
                    sw.Write(runner.Current);
                    sw.Flush();
                }

                // cancel if requested
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return runner.TextProcessor.Analyzer.GetResult();
                }

                // count progress
                int progress = (int)((runner.Position / (float)runner.InputData.Length) * 100);
                
                //report progress
                worker.ReportProgress(progress, runner.TextProcessor.Analyzer.GetResult());
            }

            return runner.TextProcessor.Analyzer.GetResult();
        }

        private void AnalysisProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var subresult = e.UserState as AnalysisResult;
            if (subresult != null)
            {
                //report progress to view
                View.Refresh(e.ProgressPercentage, subresult);
            }
        }

        private void AnalysisCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                ExceptionHelper.ResolveAndHandle(sender, e.Error);
                return;
            }

            if (e.Cancelled)
            {
                //report stop
                View.WorkStopped();
                return;
            }

            var result = e.Result as AnalysisResult;
            if (result != null)
            {
                // report finish
                View.Refresh(100, result);
            }
        }
        
        #endregion
    }
}
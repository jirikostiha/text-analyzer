namespace TextAnalyzer
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Responsible for handling amount of data for processing in one batch operation.
    /// </summary>
    public class Runner : IEnumerator<string>, IResetable
    {
        private const int DefaultBatchSize = 4096;

        private int _batchSize;
        private ITextProcessor _textProcessor;

        public Runner(string data, ITextProcessor processor)
        {
            data.NotNull().NotEmpty();
            processor.NotNull();

            TextProcessor = processor;
            InputData = data;
            Reset();
            _batchSize = DefaultBatchSize;
        }

        public string InputData { get; private set; }

        public ITextProcessor TextProcessor
        {
            get { return _textProcessor; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(TextProcessor));
                }
                _textProcessor = value;
            }
        }

        public int BatchSize
        {
            get { return _batchSize; }
            set
            {
                value.LessThan(1, "Amount of batch data size cannot be less than one");
                _batchSize = value;
            }
        }

        public int Position { get; private set; }

        /// <summary>
        /// Process next data block
        /// </summary>
        public bool MoveNext()
        {
            // precalculated future position
            int nextPosition = Position + BatchSize;

            // length of next block
            var length = nextPosition < InputData.Length ? BatchSize : InputData.Length - Position;

            // gets data block
            var block = InputData.Substring(Position, length);

            // proccess block
            Current = TextProcessor.Process(block);
            
            // increase position index
            Position += length;

            return Position <= InputData.Length;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public void Reset()
        {
            Position = 0;
        }

        public string Current { get; private set; }

        object IEnumerator.Current
        {
            get { return Current; }
        }
    }
}
namespace TextAnalyzer.Exceptions
{
    using System;
    using System.Text;

    public class ExceptionFormatter : IExceptionFormatter
    {
        private int _maxStackTraceLength = 300;

        public string Format(Exception exception)
        {
            StringBuilder builder = new StringBuilder(400);

            builder.AppendLine(exception.Message);
            builder.AppendLine();
            builder.Append("Source: ");
            builder.AppendLine(exception.Source);
            builder.AppendLine("StackTrace: ");
            builder.AppendLine(exception.StackTrace.TryGetSubstring(0, _maxStackTraceLength));

            if (exception.InnerException != null)
            {
                builder.AppendLine();
                builder.AppendLine("--InnerException--");
                builder.AppendFormat("{0}", Format(exception.InnerException));
            }

            return builder.ToString();
        }

        public string Format(object sender, Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}
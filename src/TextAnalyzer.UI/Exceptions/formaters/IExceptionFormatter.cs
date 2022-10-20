namespace IJKD.TextAnalyzer.Exceptions
{
    using System;

    public interface IExceptionFormatter
    {
        string Format(Exception exception);
        string Format(object sender, Exception exception);
    }
}
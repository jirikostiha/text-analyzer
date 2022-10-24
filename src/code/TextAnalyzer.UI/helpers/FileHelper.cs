namespace TextAnalyzer.UI
{
    using System;
    using System.IO;
    using System.Security;
    using Exceptions;

    public static class FileHelper
    {
        public static FileInfo FileCreateHandleAndRethrow(string filePath)
        {
            FileInfo file = null;
            try
            {
                file = new FileInfo(filePath);
            }
            catch (PathTooLongException ex)
            {
                throw new UIException(Resources.errFilePathNotValid, ex);
            }
            catch (ArgumentException ex)
            {
                throw new UIException(Resources.errFilePathNotValid, ex);
            }
            catch (NotSupportedException ex)
            {
                throw new UIException(Resources.errFilePathNotValid, ex);
            }
            catch (SecurityException ex)
            {
                throw new UIException(Resources.errUnsuficientRights, ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new UIException(Resources.errUnsuficientRights, ex);
            }

            return file;
        }

        public static long GetFileLengthHandleAndRethrow(FileInfo file)
        {
            var fileLength = default(long);
            try
            {
                fileLength = file.Length;
            }
            catch (FileNotFoundException ex)
            {
                throw new UIException(Resources.errFileNotFound, ex);
            }
            catch (IOException ex)
            {
                throw new UIException(Resources.errCannotRefreshFileState, ex);
            }
            return fileLength;
        }

        public static string LoadAllText(string filePath)
        {
            string data = null;
            try
            {
                data = File.ReadAllText(filePath);
            }
            catch (FileNotFoundException ex)
            {
                throw new UIException(Resources.errFileNotFound, ex);
            }
            catch (PathTooLongException ex)
            {
                throw new UIException(Resources.errFilePathNotValid, ex);
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new UIException(Resources.errFilePathNotValid, ex);
            }
            catch (IOException ex)
            {
                throw new UIException(Resources.errIOError, ex);
            }
            catch (ArgumentException ex)
            {
                throw new UIException(Resources.errFilePathNotValid, ex);
            }
            catch (NotSupportedException ex)
            {
                throw new UIException(Resources.errFilePathNotValid, ex);
            }
            catch (SecurityException ex)
            {
                throw new UIException(Resources.errUnsuficientRights, ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new UIException(Resources.errUnsuficientRights, ex);
            }
            return data;
        }

        public static FileStream OpenWrite(string outputFilePath)
        {
            FileStream fs = null;
            try
            {
                fs = File.OpenWrite(outputFilePath);
            }
            catch (FileNotFoundException ex)
            {
                throw new UIException(Resources.errFileNotFound, ex);
            }
            catch (PathTooLongException ex)
            {
                throw new UIException(Resources.errFilePathNotValid, ex);
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new UIException(Resources.errFilePathNotValid, ex);
            }
            catch (IOException ex)
            {
                throw new UIException(Resources.errIOError, ex);
            }
            catch (ArgumentException ex)
            {
                throw new UIException(Resources.errFilePathNotValid, ex);
            }
            catch (NotSupportedException ex)
            {
                throw new UIException(Resources.errFilePathNotValid, ex);
            }
            catch (SecurityException ex)
            {
                throw new UIException(Resources.errUnsuficientRights, ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new UIException(Resources.errUnsuficientRights, ex);
            }

            return fs;
        }
    }
}
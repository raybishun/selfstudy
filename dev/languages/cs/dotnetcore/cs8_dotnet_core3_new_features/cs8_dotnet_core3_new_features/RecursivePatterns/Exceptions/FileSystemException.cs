using System;
using System.Collections.Generic;
using System.Text;

namespace RecursivePatterns.Exceptions
{
    class FileSystemException : Exception
    {
        public FileSystemException(string message) : base(message)
        {
            
        }
    }
}

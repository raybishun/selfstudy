using System;
using System.Collections.Generic;
using System.Text;

namespace CSPatterns.Exceptions
{
    class FileSystemException : Exception
    {
        public FileSystemException(string message) : base(message)
        {
            
        }
    }
}

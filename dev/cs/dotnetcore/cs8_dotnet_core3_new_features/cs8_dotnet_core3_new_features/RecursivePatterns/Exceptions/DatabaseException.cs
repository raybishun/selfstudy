using System;
using System.Collections.Generic;
using System.Text;

namespace RecursivePatterns.Exceptions
{
    class DatabaseException : Exception
    {
        public string DbName { get; }
        public DatabaseException(string message, string dbName) : base(message)
        {
            DbName = dbName;
        }
    }
}

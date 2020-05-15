using CSPatterns.Exceptions;
using System;

namespace CSPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                throw new DatabaseException("Db Connection Failed", "API DB");
			}
			catch (Exception err)
			{
                Reporter reporter = new Reporter();
                reporter.Report(err, "Error in Main()", SeverityLevel.Error);
			}
        }
    }
}

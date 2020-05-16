using RecursivePatterns.Exceptions;
using System;

namespace RecursivePatterns
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				// throw new HttpException("Oops, not found", "http://api.com/route", 404);
				// throw new HttpException("Oops, internal infra fault", "http://api.com/route", 500);
				throw new HttpException("Oops, internal infra fault", "http://api.com/route", 503);
			}
			catch (Exception err)
			{
				IReporter reporter = new Reporter();
				reporter.Report(err, "Error detected in Main()", SeverityLevel.Warning);
			}
        }
    }
}

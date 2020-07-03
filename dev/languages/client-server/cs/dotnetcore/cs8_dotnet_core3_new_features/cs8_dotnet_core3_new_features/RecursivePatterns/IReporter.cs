using System;
using System.Collections.Generic;
using System.Text;

namespace RecursivePatterns
{
    interface IReporter
    {
        void Report(Exception ex, string description, SeverityLevel severityLevel);
    }
}

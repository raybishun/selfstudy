using System;
using System.Collections.Generic;
using System.Text;

using CSPatterns.Exceptions;

namespace CSPatterns
{
    class Reporter : IReporter
    {
        public void Report(Exception ex, string description, SeverityLevel severityLevel)
        {
            switch (severityLevel)
            {
                case SeverityLevel.Trace:
                    WriteLine(ex, ConsoleColor.Cyan, $"Trace: {description}");
                    break;
                case SeverityLevel.Info:
                    WriteLine(ex, ConsoleColor.DarkBlue, $"Info: {description}");
                    break;
                case SeverityLevel.Warning:
                    WriteLine(ex, ConsoleColor.DarkYellow, $"Warning: {description}");
                    break;
                case SeverityLevel.Error:
                    WriteLine(ex, ConsoleColor.Red, $"Error: {description}");
                    break;
                case SeverityLevel.Critical:
                    WriteLine(ex, ConsoleColor.Magenta, $"Critical: {description}");
                    break;
                default:
                    break;
            }
        }

        void WriteLine(Exception ex, ConsoleColor color, string text)
        {
            switch (ex)
            {
                case DatabaseException dbEx:
                    text = $"[Database - {dbEx.DbName}]: {text}";
                    break;
                case FileSystemException fsEx:
                    text = $"[FS]: {text}";
                    break;
                case HttpException httpEx:
                    text = $"[HTTP Error] {httpEx.StatusCode} -{httpEx.Url}: {text}";
                    break;
            }

            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = currentColor;
        }
    }
}

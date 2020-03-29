using System;
using System.Text.RegularExpressions;

namespace RegExConsoleApp
{
    class Program
    {
        // ====================================================================
        // Common (language independent) Regular Expression Symbols
        // ====================================================================
        // Symbol       Description                 
        // ^            Start of input              
        // \d           A single digit              
        // \w           Whitespace                  
        // [A-Za-z0-9]  Ranges(s) of characters
        // +            One or more
        // .            A single character          
        // {3}          Exactly three
        // {3,}         Three or more
        // $            End of input                
        // \D           A single NON-digit
        // \W           NON-whitespace
        // [AEIOU]      Set of characters
        // ?            One or more
        // {3,5}        Three or five
        // {,3}         Up to three


        static void Main(string[] args)
        {
            // RegEx_Find_Single_Digit_In_String();
            RegEx_Only_Accept_Single_Digit();
 

            Console.ReadLine();
        }

        private static void RegEx_Only_Accept_Single_Digit()
        {
            Console.Write("Only enter a single digit: ");

            string input = Console.ReadLine();

            // Note, the @ disables the use of any escape characters
            // And, the \d$ = input must be only a single digit
            Regex getSingleDigit = new Regex(@"\d$");

            if (getSingleDigit.IsMatch(input))
            {
                Console.WriteLine("Digit found...");
            }
            else
            {
                Console.WriteLine("Digit not found.");
            }
        }

        private static void RegEx_Find_Single_Digit_In_String()
        {
            Console.Write("Enter string with at least 1 digit: ");

            string input = Console.ReadLine();

            // Note, the @ disables the use of any escape characters
            // And, the \d = single digit
            Regex getSingleDigit = new Regex(@"\d");

            if (getSingleDigit.IsMatch(input))
            {
                Console.WriteLine("Digit found...");
            }
            else
            {
                Console.WriteLine("Digit not found.");
            }
        }
    }
}

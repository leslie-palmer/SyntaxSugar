using System;

namespace SyntaxSugar
{
    internal class Program
    {
        static void Main(string[] args)
        {//Assigns a value to "answer", compares it against a number, selects the correct string and writes a line to console in 3 lines
            var answer = 4;
            var response = (answer < 9) ? "less than nine" : "greater than or equal to nine";
            Console.WriteLine($"{answer} is {response}");
        }//The string assigned to "response" and the string written to the console were formatted this way for easy readability
    }
}

// See https://aka.ms/new-console-template for more information
using System;
namespace helloworld
{
    class Program
    {
        public static string Cypher(string inputText)
        {
            string parsedString="";
            string lowerCaseAlphabet = "abcdefghijklmnopqrstuvwxyz";
            string upperCaseAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "0123456789";
            int inputLength = inputText.Length;
            for (int i = 0; i < inputLength; i++)
            {
                char currentChar = inputText[i];
                if (lowerCaseAlphabet.Contains(currentChar))
                {
                    int indexOfChar = lowerCaseAlphabet.IndexOf(currentChar);
                    char parsedCurrentChar = lowerCaseAlphabet[(indexOfChar+3)%26];
                    parsedString += parsedCurrentChar;
                } else if (upperCaseAlphabet.Contains(currentChar))
                {
                    int indexOfChar = upperCaseAlphabet.IndexOf(currentChar);
                    char parsedCurrentChar = upperCaseAlphabet[(indexOfChar+3)%26];
                    parsedString += parsedCurrentChar;
                } else if (currentChar == ' ') {
                    parsedString = parsedString + currentChar;
                } else if (numbers.Contains(currentChar))
                {
                    int indexOfChar = numbers.IndexOf(currentChar);
                    char parsedCurrentChar = numbers[(indexOfChar + 3)%10];
                    parsedString += parsedCurrentChar;
                } else
                {
                    parsedString += currentChar;
                }
            }
            return parsedString;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Cypher program!\nType your text to be encripted below!");
            string inputText = Console.ReadLine();
            string cypheredText = Cypher(inputText);
             Console.WriteLine("The encripted string is:" + cypheredText);
             Console.ReadLine();
        }
    }
}
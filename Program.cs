using System;
using System.Collections.Generic;

namespace Lab_3_3
{
    class Program
    {
        static Stack<char> stack = new Stack<char>();
        static char[] chars;
        static void Main(string[] args)
        {
            Console.Write("Please enter a word you would like to reverse: ");
            string userInput = Console.ReadLine();
            

            if (userInput.Contains(" "))
            {
                var sentence = userInput.Split(" ");
                string newSentence = null;

                for (int i = 0; i < sentence.Length; i++)
                {
                    newSentence += ReverseString(sentence[i]) + " ";
                }

                Console.WriteLine($"You entered a sentence and your new sentence is: {newSentence}");

            }
            else
            {
                string newWord = ReverseString(userInput);

                Console.WriteLine($"Your word in reverse: {newWord}");
            }

          
        }

        static string ReverseString(string word)
        {
            chars = word.ToCharArray();
            string reverseWord = null;

            for (int i=0; i < chars.Length; i++)
            {
                stack.Push(chars[i]);
            }
            
            while (stack.Count > 0)
            {
                reverseWord += stack.Pop();
            }

            return reverseWord;
            
        }
    }
}

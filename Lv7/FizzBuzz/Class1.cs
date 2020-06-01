using System;
using System.Collections.Generic;

namespace FizzBuzz
{


    public class FizzBuzzer
    {

        public bool Check(string word)
        {
            if (string.IsNullOrEmpty(word)) throw new ArgumentException();


            bool palindrom = false;
            bool space = false;
            bool upperLetter = false;
            bool smallLetter = false;
            //Task1
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    palindrom = true;
                }
                else
                {
                    palindrom = false;
                }

            }

            //Task2
            foreach (char c in word)
            {
                if (char.IsUpper(c)) upperLetter = false;
                if (char.IsLower(c)) smallLetter = false;
                if (char.IsWhiteSpace(c)) space = false;
            }

            //Task3
            foreach (char c in word)
            {
                if (char.IsUpper(c)) char.ToLower(c);
                if (char.IsPunctuation(c)) char.Parse(" ");
                if (char.IsSymbol(c)) char.Parse("x");
            }

            return palindrom && upperLetter && smallLetter && space;


        }

        
    }
}
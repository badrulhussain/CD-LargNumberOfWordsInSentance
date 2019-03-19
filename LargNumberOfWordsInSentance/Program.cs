using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LargNumberOfWordsInSentance
{
    class Program
    {
        static int Main(string[] args)
        {
            //var S = "We test coders. Give us a try?";
            //var S = "Forget  CVs..Save time . x x";

            var C = S.ToArray();
            List<string> Sentances = new List<string>();

            StringBuilder Sentance = new StringBuilder();

            for (int i = 0; i < C.Length; i++)
            {
                if (char.IsPunctuation(C[i]))
                {
                    Sentance.Append(C[i]);
                    Sentances.Add(Sentance.ToString());
                    Sentance.Clear();
                }
                if (!char.IsPunctuation(C[i]))
                {
                    Sentance.Append(C[i]);
                }
            }

            var position = 0;
                var maxWord = 1;
            foreach(var item in Sentances)
            {
                var currentWordCount = CountWords(item);
                if (currentWordCount > maxWord)
                {
                    maxWord = currentWordCount;
                }

                position++;
            }

            //Console.WriteLine(maxWord);
            return maxWord;
        }

        public static int CountWords(string s)
        {
            int c = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (char.IsWhiteSpace(s[i - 1]) == true)
                {
                    if (char.IsLetterOrDigit(s[i]) == true ||
                        char.IsPunctuation(s[i]))
                    {
                        c++;
                    }
                }
            }
            return c;
        }
    }
}

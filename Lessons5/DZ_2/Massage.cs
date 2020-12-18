using System;
using System.Text;

namespace DZ_2
{
    public static class Message
    {        
        public static string PrintWords(string message, int maxLength)
        {
            string[] separators = { ",", ".", "!", "?", ";", ":", " " };
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= maxLength)
                {
                    Console.Write(words[i] + " ");
                    sb.Append($"{words[i]} ");
                }
            }
            return sb.ToString();
        }
       
        public static string DeleteWords(string message, char symbol)
        {
            string[] separators = { ",", ".", "!", "?", ";", ":", " " };
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i][words[i].Length - 1] == symbol)
                    words[i] = words[i].Remove(0);
            }
            
            for (int i = 0; i < words.Length - 1; i++)
            {
                for (int j = 0; j < words.Length - 1; j++)
                {
                    if (words[j] == "")
                    {
                        var temp = words[j];
                        words[j] = words[j + 1];
                        words[j + 1] = temp;
                    }
                }
            }
            string result = string.Join(" ", words).TrimEnd();
            return result;
        }
        
        public static string MaxLengthWord(string message)
        {
            string[] separators = { ",", ".", "!", "?", ";", ":", " " };
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string maxWord = words[0];
            for (int i = 1; i < words.Length; i++)
            {
                if (maxWord.Length < words[i].Length)
                    maxWord = words[i];
            }
            return maxWord;
        }
        
        public static string MaxLengthWords(string message)
        {
            string[] separators = { ",", ".", "!", "?", ";", ":", " " };
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int maxLengthWord = words[0].Length;
            StringBuilder result = new StringBuilder();
            for (int i = 1; i < words.Length; i++)
            {
                if (maxLengthWord < words[i].Length)
                    maxLengthWord = words[i].Length;
            }

            for (int i = 0; i < words.Length; i++)
            {
                if (maxLengthWord == words[i].Length)
                    result.Append($"{words[i]} ");
            }
            return result.ToString();
        }        
    }
}

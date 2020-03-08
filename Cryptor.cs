using System;
using System.Collections.Generic;

namespace Text_Encryptor
{
    class Cryptor
    {
        public Language language;

        public Cryptor(Language turkish)
        {
            this.language = turkish;
        }

        public string EnCrypt(string str, Function function)
        {
            string[] newStr = new string[str.Length];
            for(int x = 0; x < str.Length; x++)
            {
                string letter = str.Substring(x, 1).ToLower(language.culture);
                if(!language.letters.Contains(letter))
                {
                    newStr[x] = letter;
                    continue;
                }
                int order = LetterOrder.GetOrder(letter,language);
                order = function.Call(order);
                newStr[x] = LetterOrder.GetLetter(order, language);
            }
            return string.Join("", newStr);
        }
        
        public string DeCrypt(string str,BasicFunction function)
        {
            string[] newStr = new string[str.Length];
            for (int x = 0; x < str.Length; x++)
            {
                string letter = str.Substring(x, 1).ToLower(language.culture);
                if (!language.letters.Contains(letter))
                {
                    newStr[x] = letter;
                    continue;
                }
                int order = LetterOrder.GetOrder(letter, language);
                double result1 = function.ReverseCall(order);
                while (result1 != Math.Floor(result1))
                {
                    order += language.letters.Length;
                    result1 = function.ReverseCall(order);
                }
                newStr[x] = LetterOrder.GetLetter((int)result1, language);
            }
            return string.Join("", newStr);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Encryptor
{
    static class LetterOrder
    {
        public static int GetOrder(string str,Language language)
        {
            if (str.Length > 1)
            {
                return 0;
            }
            return language.letters.IndexOf(str.ToLower());
        }

        public static string GetLetter(int order,Language language)
        {
            int index;
            if(order < 0)
            {
                order = (language.letters.Length - 1) - (-1 * (order + 1));
            }
            index = order % (language.letters.Length);
            return language.letters.Substring(index, 1);
        }
    }

    class Language
    {
        public string letters { get; }
        public static Language Turkish { get { return new Language("abcçdefgğhıijklmnoöprsştuüvyz"); } }
        public static Language English { get { return new Language("abcdefghijklmnopqrstuvwxyz"); } }
        
        public Language(string letters)
        {
            this.letters = letters;
        }
    }

}

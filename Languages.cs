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
            int index = order % (language.letters.Length);
            if (index < 0)
            {
                index = (language.letters.Length - 1) - (-1 * (index + 1));
            }           
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

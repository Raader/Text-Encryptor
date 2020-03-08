using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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
            return language.letters.IndexOf(str.ToLower(language.culture));
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
        public CultureInfo culture;
        public static Language Turkish { get { return new Language("abcçdefgğhıijklmnoöprsştuüvyz",new CultureInfo("tr-TR")); } }
        public static Language English { get { return new Language("abcdefghijklmnopqrstuvwxyz", new CultureInfo("en-US")); } }
        
        public Language(string letters,CultureInfo culture)
        {
            this.letters = letters;
            this.culture = culture;
        }
    }

}

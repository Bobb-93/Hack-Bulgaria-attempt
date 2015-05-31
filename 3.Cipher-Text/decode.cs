using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Cipher_Text
{
    class decode
    {
        static void decode_word(string word, Dictionary<char, char> codes)
        {
            char[] arrayFromSymbols=word.ToCharArray();

            foreach(char c in arrayFromSymbols)
            {
                Console.Write("{0}", codes[c]); 
            }
        }
        static void Main(string[] args)
        {
            Dictionary<char, char> phonebook = new Dictionary<char, char>()
            {
                {'a', 'w'},
                {'l', 'd'},
                {'b', 'o'},
                {'u', 't'},
            };
            decode_word("alubb", phonebook);

        }
    }
}

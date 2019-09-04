using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Task1
{
    public class DataPharser
    {
        public char[] getMessage(string filePath)
        {
            using (StreamReader stream = new StreamReader(filePath, Encoding.Default))
            {
                char[] message = stream.ReadToEnd().ToCharArray();
                return message;
            }
        }

        public Dictionary<int, char> GetAlphabet()
        {
            Dictionary<int, char> result = new Dictionary<int, char>();
            using (StreamReader stream = new StreamReader("Alphabet.txt", Encoding.Default))
            {
                char[] alphabet = stream.ReadToEnd().ToCharArray();
                for (int i = 0; i < alphabet.Length; i++)
                {
                    result.Add(i, alphabet[i]);
                }
            }
            return result;
        }

        public int[] CharToCode(char[] message, Dictionary<int, char> alphabet)
        {
            int[] result = new int[message.Length];
            for (int i = 0; i < message.Length; i++)
            {
                foreach (var item in alphabet)
                {
                    if (message[i] == item.Value)
                    {
                        result[i] = item.Key;
                    }
                }
            }
            return result;
        }

        public string CodeToMessage(int[] code, Dictionary<int, char> alphabet)
        {
            string result = "";
            for (int i = 0; i < code.Length; i++)
            {
                result += alphabet[code[i]];
            }
            return result;
        }
    }
}
using System;

namespace Task1
{
    internal class Program
    {
        //добавить в алфавит заглавные буквы, проверку ошибок.
        private static void Main(string[] args)
        {
            DataPharser dp = new DataPharser();
            Encryption_tools et = new Encryption_tools();
            char[] message = dp.getMessage("Message.txt");
            var alphabet = dp.GetAlphabet();
            int[] messageToInt = dp.CharToCode(message, alphabet);
            int[] messageToBtype = et.Coding(messageToInt, 1, 7, alphabet.Count);
            int[] messageToAtype = et.Decoding(messageToBtype, 1, 7, alphabet.Count);
            foreach (var item in dp.CodeToMessage(messageToAtype, alphabet))
            {
                Console.WriteLine(item);
            }
        }
    }
}
using System;

namespace Task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DataPharser dp = new DataPharser();
            Encryption_tools et = new Encryption_tools();
            var alphabet = dp.GetAlphabet();
            Console.WriteLine("Длинна алфавита = {0}", alphabet.Count);
            Console.Write("Введите n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите k = ");
            int k = int.Parse(Console.ReadLine());
            char[] message = dp.getMessage("Message.txt");
            int[] messageToInt = dp.CharToCode(message, alphabet);
            Console.WriteLine("\nСообщение в код\n------------------------------------------------------------" + "\n");
            foreach (var item in messageToInt)
            {
                Console.Write(item + " ");
            }
            int[] messageToBtype = et.Coding(messageToInt, n, k, alphabet.Count);
            Console.WriteLine("\nСообщение в тип В\n------------------------------------------------------------" + "\n");
            foreach (var item in messageToBtype)
            {
                Console.Write(item + " ");
            }

            int[] messageToAtype = et.Decoding(messageToBtype, n, k, alphabet.Count);
            Console.WriteLine("\nОбратно в тип А\n------------------------------------------------------------" + "\n");
            foreach (var item in messageToAtype)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nРезультат\n------------------------------------------------------------" + "\n");
            foreach (var item in dp.CodeToMessage(messageToAtype, alphabet))
            {
                Console.Write(item);
            }
        }
    }
}
using System;

namespace Task1
{
    public class Encryption_tools
    {
        private int To_A(int B, int n, int k, int m)
        {
            return (B - k) * (1 / n) % m;
        }

        private int To_B(int A, int n, int k, int m)
        {
            return (A * n + k) % m;
        }

        private int NOD(int m, int n)
        {
            int nod = 0;
            for (int i = 1; i < (n * m + 1); i++)
            {
                if (m % i == 0 && n % i == 0)
                {
                    nod = i;
                }
            }
            return nod;
        }

        public int[] Coding(int[] message, int n, int k, int m)
        {
            if (NOD(n, m) == 1)
            {
                int size = message.Length;
                int[] res = new int[size];
                for (int i = 0; i < size; i++)
                {
                    res[i] = To_B(message[i], n, k, m);
                }
                return res;
            }
            else throw new ArgumentException("Nod(n,m)!=1");
        }

        public int[] Decoding(int[] code, int n, int k, int m)
        {
            if (NOD(n, m) == 1)
            {
                int size = code.Length;
                int[] res = new int[size];
                for (int i = 0; i < size; i++)
                {
                    res[i] = To_A(code[i], n, k, m);
                }
                return res;
            }
            else throw new ArgumentException("Nod(n,m)!=1");
        }
    }
}
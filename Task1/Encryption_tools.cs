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

        public int[] Coding(int[] message, int n, int k, int m)
        {
            int size = message.Length;
            int[] res = new int[size];
            for (int i = 0; i < size; i++)
            {
                res[i] = To_B(message[i], n, k, m);
            }
            return res;
        }

        public int[] Decoding(int[] code, int n, int k, int m)
        {
            int size = code.Length;
            int[] res = new int[size];
            for (int i = 0; i < size; i++)
            {
                res[i] = To_A(code[i], n, k, m);
            }
            return res;
        }
    }
}
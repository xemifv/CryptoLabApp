using System;
using System.Windows.Forms;

namespace CryptoLabApp.Forms
{
    public partial class RandomNumberForm : Form
    {
        public RandomNumberForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            long number = GenerateRandomNumber();
            bool isPrime = IsPrimeRabinMiller(number);
            MessageBox.Show($"Згенеровано: {number}\nЧи є простим: {isPrime}");
        }

        private long GenerateRandomNumber()
        {
            Random rand = new Random();
            return rand.Next(1000, 1000000) | 1; // Непарне число
        }

        private bool IsPrimeRabinMiller(long n, int k = 5)
        {
            if (n < 2) return false;
            if (n == 2 || n == 3) return true;
            if (n % 2 == 0) return false;

            long d = n - 1;
            int s = 0;
            while (d % 2 == 0)
            {
                d /= 2;
                s++;
            }

            Random rand = new Random();
            for (int i = 0; i < k; i++)
            {
                long a = rand.Next(2, (int)Math.Min(n - 2, int.MaxValue));
                long x = ModPow(a, d, n);
                if (x == 1 || x == n - 1) continue;

                for (int r = 0; r < s - 1; r++)
                {
                    x = ModPow(x, 2, n);
                    if (x == n - 1) break;
                }
                if (x != n - 1) return false;
            }
            return true;
        }

        private long ModPow(long baseNum, long exp, long mod)
        {
            long result = 1;
            baseNum %= mod;
            while (exp > 0)
            {
                if ((exp & 1) == 1) result = (result * baseNum) % mod;
                baseNum = (baseNum * baseNum) % mod;
                exp >>= 1;
            }
            return result;
        }
    }
}
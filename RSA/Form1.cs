using System.Diagnostics;
using System.Numerics;

namespace RSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool isPrime(int number)
        {
            if (number == 1 || number == 2)
            {
                return false;
            }

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int NOD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            int p = Int32.Parse(textBox1.Text);
            int q = Int32.Parse(textBox2.Text);

            string message = textBox3.Text;

            if (isPrime(p) && isPrime(q))
            {
                textBox4.Text = encrypt(message, p, q);
            }
        }

        private string encrypt(string message, int p, int q)
        {
            string result = "";

            int n = p * q;
            textBox7.Text = n.ToString();

            int fn = (p - 1) * (q - 1);
            textBox6.Text = fn.ToString();

            int d = 0;
            for (int i = 2; i < fn + 100000; i++)
            {
                d = i;
                if (NOD(d, fn) == 1)
                {
                    break;
                }
            }

            int e = 1;

            for (int i = 1; i < fn + 100000; i++)
            {
                e = i;
                if ((e * d) % fn == 1)
                {
                    break;
                }
            }

            textBox5.Text = e.ToString();
            textBox8.Text = d.ToString();

            foreach (char symb in message)
            {
                result += BigInteger.ModPow((int)symb, e, n) + " ";
            }

            //textBox4.Text = $"Закрытый ключ: ({d}, {n}) n = {n} e = {e}";

            return result;
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {

            string[] messageToDecrTmp = textBox4.Text.Split(' ');
            BigInteger[] keys = new BigInteger[messageToDecrTmp.Length];
            int l = 0;

            try
            {
                foreach (string symb in messageToDecrTmp)
                {
                    keys[l] = BigInteger.ModPow(Int32.Parse(symb), Int32.Parse(textBox8.Text), Int32.Parse(textBox7.Text));
                    l++;
                }
            }
            catch { }

            foreach(int key in keys)
            {
                textBox9.Text += (char)(key+70);
            }

            textBox9.Text = textBox9.Text.Substring(0, textBox9.Text.Length - 1);
        }
    }
}

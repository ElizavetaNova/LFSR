using System;
using System.Linq;
using System.Windows.Forms;

namespace LFSR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public string multiply(string a, string b) // умножение 0011x0101 = 0001
        {
            int lena = a.Length;
            int lenb = b.Length;
            int max;
            int min;
            string strmax;
            string strmin;
            string result = "";
            if (lena > lenb)
            {
                max = lena;
                min = lenb;
                strmax = a;
                strmin = b;
            }
            else
            {
                max = lenb;
                min = lena;
                strmax = b;
                strmin = a;
            }
            for (int i = 0; i < max; i++)
            {
                if (min > 0)
                {
                    result += mpsum(strmax.Last(), strmin.Last());
                    min -= 1;
                    strmax = strmax.Remove(strmax.Length - 1, 1);
                    strmin = strmin.Remove(strmin.Length - 1, 1);
                }
                else
                {
                    result += '0';
                }

            }
            return result;
        }
        public string xor(string a, string b) // xor 0011x0101=0110
        {
            int lena = a.Length;
            int lenb = b.Length;
            int max;
            int min;
            string strmax;
            string strmin;
            string result = "";
            if (lena > lenb)
            {
                max = lena;
                min = lenb;
                strmax = a;
                strmin = b;
            }
            else
            {
                max = lenb;
                min = lena;
                strmax = b;
                strmin = a;
            }
            for (int i = 0; i < (max); i++)
            {
                if (min > 0)
                {
                    result += xorsum(strmax.Last(), strmin.Last());
                    min -= 1;
                    strmax = strmax.Remove(strmax.Length - 1, 1);
                    strmin = strmin.Remove(strmin.Length - 1, 1);
                }
                else
                {
                    result += xorsum(strmax.Last(), '0');
                    strmax = strmax.Remove(strmax.Length - 1, 1);
                }

            }

            return result;
        }
        public char xorsum(char a, char b)
        {
            if (a == b) return '0';
            else return '1';
        }
        public char mpsum(char a, char b)
        {
            if (a == '1' && b == '1') return '1';
            else return '0';
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string originalMessage = OriginalMessage.Text;
            string initialVector = initialization.Text;
            string coeffVector = Coefficient.Text;

            //if (originalMessage )
        }
    }
}

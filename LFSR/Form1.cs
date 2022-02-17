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
        public char getsum(string a) // сумма по строке
        {
            char c = a[0];
            a = a.Remove(0, 1);
            for(int i=0; i<a.Length; i++)
            {
                c = xorsum(c, a[i]);

            }
            return c;
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
        public char xorsum(char a, char b) // посимвольный xor
        {
            if (a == b) return '0';
            else return '1';
        }
        public char mpsum(char a, char b) // посимвольное умножение
        {
            if (a == '1' && b == '1') return '1';
            else return '0';
        }
        private void button1_Click(object sender, EventArgs e) //зашифровать
        {

            if (OriginalMessage.Text != null & initialization.Text != null & Coefficient.Text != null)
            {
                if (initialization.Text.Length == Coefficient.Text.Length)
                {
                    string originalMessage = OriginalMessage.Text;
                    string initialVector = initialization.Text;
                    string coeffVector = Coefficient.Text;

                    string z = initialVector; //промежуточный результат, который в конце складывается с исходным сообщением
                    char sumBit;
                    string tempInitial = initialVector;
                    string multip = "";
                    int k = 0; //сколько символов нужно удалить, чтоб получить tempInitial


                    while (z.Length != originalMessage.Length)
                    {

                        multip = multiply(tempInitial, coeffVector);
                        sumBit = getsum(multip);
                        z = z + sumBit;
                        k += 1;
                        tempInitial = z.Remove(0, k);
                    }
                    string result = xor(z, originalMessage);
                    Z.Text = z;
                    Result.Text = result;
                }
                else
                    MessageBox.Show("Длины вектора коэффициентов и вектора инициализации должны совпадать");
            }
            else
                MessageBox.Show("Заполните необходимые поля ");
        }

        private void button2_Click(object sender, EventArgs e) // расшифровать
        {
            if (Сryptogram.Text != null & CoefficientDecod.Text != null & initializationDecod.Text != null)
            {
                if (CoefficientDecod.Text.Length == initializationDecod.Text.Length)
                {
                    string cryptogramText = Сryptogram.Text;
                    string initialVector = initializationDecod.Text;
                    string coeffVector = CoefficientDecod.Text;

                    string z = initialVector; //промежуточный результат, который в конце складывается с исходным сообщением
                    char sumBit;
                    string tempInitial = initialVector;
                    string multip = "";
                    int k = 0; //сколько символов нужно удалить, чтоб получить tempInitial

                    while (z.Length != cryptogramText.Length)
                    {
                        multip = multiply(tempInitial, coeffVector);
                        sumBit = getsum(multip);
                        z = z + sumBit;
                        k += 1;
                        tempInitial = z.Remove(0, k);
                    }
                    string result = xor(cryptogramText, z);
                    ZDecod.Text = z;
                    //result = result.Reverse().ToString();
                    RezultDecod.Text = result;


                }
                else
                    MessageBox.Show("Длины вектора коэффициентов и вектора инициализации должны совпадать");
            }
            else MessageBox.Show("Заполните необходимые поля");

        }

        private void keyPress(object sender, KeyPressEventArgs e)
        {
            int ch = e.KeyChar;
            if (ch != 48 && ch != 49 && ch != 8) //0,1, BackSpace 
            {
                e.Handled = true;
            }
        }
    }
}

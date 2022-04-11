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
        public char getSumOfBitInline(string a) // сумма по строке
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
        private void Encryption(object sender, EventArgs e) //зашифровать
        {
            EncryptAndDecript(initialization.Text, Coefficient.Text, OriginalMessage.Text);
        }

        private void Decryption(object sender, EventArgs e) // расшифровать
        {
            EncryptAndDecript(initializationDecod.Text, CoefficientDecod.Text, Сryptogram.Text);            
        }
        public string EncryptAndDecript(string initialVector, string coeffVector, string binNumber)
        {
            if (binNumber != null & coeffVector != null & initialVector != null)
            {
                if (coeffVector.Length == initialVector.Length)
                {
                    string vectorZ = initialVector; //промежуточный результат, который в конце складывается с исходным сообщением
                    char sumBitInString;
                    string tempInitial = initialVector;
                    string multip = "";
                    int countDeleteBit = 0; //сколько символов нужно удалить, чтоб получить tempInitial

                    while (vectorZ.Length != binNumber.Length)
                    {
                        multip = multiply(tempInitial, coeffVector);
                        sumBitInString = getSumOfBitInline(multip);
                        vectorZ = vectorZ + sumBitInString;
                        countDeleteBit += 1;
                        tempInitial = vectorZ.Remove(0, countDeleteBit);
                    }
                    string result = xor(binNumber, vectorZ);
                    result = new string(result.Reverse().ToArray());
                    return result;
                }
                else
                {
                    MessageBox.Show("Длины вектора коэффициентов и вектора инициализации должны совпадать");
                    return "";
                }
            }
            else
            {
                MessageBox.Show("Заполните необходимые поля");
                return "";
            }            
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

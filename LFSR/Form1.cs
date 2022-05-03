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
        public char GetSumOfBitInRaw(string a) // сумма по строке
        {
            char c = a[0];
            a = a.Remove(0, 1);
            for (int i = 0; i < a.Length; i++)
            {
                c = CharacterByCharacterXOR(c, a[i]);
            }
            return c;
        }

        public string OperationWithTwoOperands(string firstOperand, string secondOperand, bool typeOfOperation)
        {
            int lengthOfFirstOperand = firstOperand.Length;
            int lengthOfSecondOperand = secondOperand.Length;
            int maximumLengthOfOperand;
            int minimumLengthOfOperand;
            string stringWithMaximumLength;
            string stringWithMinimumLength;
            string stringResultOfOperation = "";
            if (lengthOfFirstOperand > lengthOfSecondOperand)
            {
                maximumLengthOfOperand = lengthOfFirstOperand;
                minimumLengthOfOperand = lengthOfSecondOperand;
                stringWithMaximumLength = firstOperand;
                stringWithMinimumLength = secondOperand;
            }
            else
            {
                maximumLengthOfOperand = lengthOfSecondOperand;
                minimumLengthOfOperand = lengthOfFirstOperand;
                stringWithMaximumLength = secondOperand;
                stringWithMinimumLength = firstOperand;
            }
            for (int i = 0; i < maximumLengthOfOperand; i++)
            {
                if (minimumLengthOfOperand > 0)
                {
                    if (typeOfOperation == true)
                        stringResultOfOperation += CharacterByCharacterXOR(stringWithMaximumLength.Last(), stringWithMinimumLength.Last());
                    else stringResultOfOperation += CharacterByCharacterMultiplication(stringWithMaximumLength.Last(), stringWithMinimumLength.Last());
                    minimumLengthOfOperand -= 1;
                    stringWithMaximumLength = stringWithMaximumLength.Remove(stringWithMaximumLength.Length - 1, 1);
                    stringWithMinimumLength = stringWithMinimumLength.Remove(stringWithMinimumLength.Length - 1, 1);
                }
                else
                {
                    if (typeOfOperation == true)
                    {
                        stringResultOfOperation += CharacterByCharacterXOR(stringWithMaximumLength.Last(), '0');
                        stringWithMaximumLength = stringWithMaximumLength.Remove(stringWithMaximumLength.Length - 1, 1);
                    }
                    else stringResultOfOperation += '0';
                }

            }
            return stringResultOfOperation;
        }
        public char CharacterByCharacterXOR(char a, char b) // посимвольный xor
        {
            if (a == b) return '0';
            else return '1';
        }
        public char CharacterByCharacterMultiplication(char a, char b) // посимвольное умножение
        {
            if (a == '1' && b == '1') return '1';
            else return '0';
        }
        private void Encryption(object sender, EventArgs e) //зашифровать
        {
            ResultE.Text = EncryptAndDecrypt(textBoxInitializationVectorE.Text, textBoxCoefficientVectorE.Text, textBoxOriginalMessageE.Text, ZE);
        }

        private void Decryption(object sender, EventArgs e) // расшифровать
        {
            ResultD.Text = EncryptAndDecrypt(textBoxInitializationVectorD.Text, textBoxCoefficientVectorD.Text, textBoxСryptogramD.Text, ZD);
        }
        private string EncryptAndDecrypt(string initialVector, string coeffVector, string binNumber, TextBox Z)
        {
            ConditionCheckForLFSR(initialVector, coeffVector, binNumber);
            string vectorZ = initialVector; //промежуточный результат, который в конце складывается с исходным сообщением
            char sumBitInString;
            string tempInitial = initialVector;
            int countDeleteBit = 0; //сколько символов нужно удалить, чтоб получить tempInitial

            while (vectorZ.Length != binNumber.Length)
            {
                string multip = OperationWithTwoOperands(tempInitial, coeffVector, false);
                sumBitInString = GetSumOfBitInRaw(multip);
                vectorZ = vectorZ + sumBitInString;
                countDeleteBit += 1;
                tempInitial = vectorZ.Remove(0, countDeleteBit);
            }

            Z.Text = vectorZ;
            string result = OperationWithTwoOperands(binNumber, vectorZ, true);
            result = new string(result.Reverse().ToArray());
            return result;
        }
        private void ConditionCheckForLFSR(string initialVector, string coeffVector, string binNumber)
        {
            if (binNumber == "" || coeffVector == "" || initialVector == "")
                MessageBox.Show("Длины вектора коэффициентов и вектора инициализации должны совпадать", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (coeffVector.Length != initialVector.Length)
                MessageBox.Show("Заполните необходимые поля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
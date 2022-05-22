using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Functions;

namespace Ramzai
{
    public partial class Form2 : Form
    {
        private Regex gammaRegex = new Regex("[0-9]");
        private Regex textRegex = new Regex("[A-Z\\/]");
        public Form2()
        {
            InitializeComponent();
            Function.Init();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = "";
            outputTextBox.Text = "";
            gammaTextBox.Text = "";
        }

        private void cipherButton_Click(object sender, EventArgs e)
        {
            //Чтобы не изменить внешний вид введенного в текстбокс текста,
            //положим его во временную переменную
            string tempInputText = inputTextBox.Text;

            //удалим пробелы
            tempInputText = Function.removeSpaces(tempInputText);
            gammaTextBox.Text = Function.removeSpaces(gammaTextBox.Text);

            //проверочки
            if (!gammaRegex.IsMatch(gammaTextBox.Text))
            {
                outputTextBox.Text = "Неверная гамма";
                return;
            }
            if(!textRegex.IsMatch(inputTextBox.Text) || inputTextBox.Text.Length < 19)
            {
                outputTextBox.Text = "Кодируемое сообщение неверного формата";
                return;
            }
            // Почти все проверки пройдены, начинаем кодировать

            //замена символов на их номера согласно табличке
            int[] preCipher = Function.getPreliminaryCipher(tempInputText.ToCharArray());

            if (preCipher.Length != gammaTextBox.Text.Length)
            {
                outputTextBox.Text = "Длина гаммы должна быть равна длине сообщения";
                return;
            }

            //создать указатель начала гаммы
            Function.setPointer((int)pointerPart1.Value, (int)pointerPart2.Value, (int)pointerPart3.Value);

            //производим гаммирование
            preCipher = Function.getCipher(preCipher, gammaTextBox.Text);

            //вывести шифр
            string cipher = "";
            int i = 0;
            const int BLOCK_SIZE = 5;
            foreach(int p in preCipher)
            {
                if(i < BLOCK_SIZE)
                {
                    i++;
                }
                else
                {
                    cipher += " ";
                    i = 1;
                }
                cipher += p.ToString();
            }
            outputTextBox.Text = cipher;
        }
    }
}

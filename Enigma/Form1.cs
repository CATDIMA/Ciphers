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
using Mechanics;

namespace Enigma
{
    public partial class Form1 : Form
    {
        //регулярка для входного текста
        //он должен содержать только заглавные англ. буквы
        private Regex regexText = new Regex("[A-Z]");

        //хранилище текстбоксов патч-панели
        public List<TextBox> textBoxes = new List<TextBox>();

        private string removeSpaces(string str)
        {
            string[] temp = str.Split(' ', '\n');
            string result = "";
            foreach(string s in temp)
            {
                result += s;
            }
            return result;
        }

        public Form1()
        {
            InitializeComponent();

            //текстбоксы патч-панели
            textBoxes.Add(patch1);
            textBoxes.Add(patch2);
            textBoxes.Add(patch3);
            textBoxes.Add(patch4);
            textBoxes.Add(patch5);
            textBoxes.Add(patch6);
            textBoxes.Add(patch7);
            textBoxes.Add(patch8);
            textBoxes.Add(patch9);
            textBoxes.Add(patch10);
            textBoxes.Add(patch11);
            textBoxes.Add(patch12);
        }

        private void cipherButton_Click(object sender, EventArgs e)
        {
            //успешно ли создана патч панель?
            bool isPatchesAdded = PatchPanel.Init(ref textBoxes);
            
            //установка роторов в указанные начальные позиции
            Mechanics.Enigma.setInitPos((int)key1.Value, (int)key2.Value, (int)key3.Value);

            //теперь можно выбрать типы роторов
            bool isRotorsAdded = Mechanics.Enigma.setRotorsType(new int[3]
                {(int)rotorSelection1.Value, (int)rotorSelection2.Value, (int)rotorSelection3.Value });

            //выбор типа рефлектора
            bool isReflectorAdded = Mechanics.Enigma.setReflectorType(reflectorBox.SelectedIndex);

            //проверки
            //нет текста для шифрования
            if(inputTextBox.TextLength == 0 || !regexText.IsMatch(inputTextBox.Text))
            {
                cipherTextBox.Text = "No text to encode";
                return;
            }
            //неправильно выбраны роторы или не выбраны вообще
            if(!isRotorsAdded)
            {
                cipherTextBox.Text = "No rotors selected";
                return;
            }
            //не выбран рефлектор
            if(!isReflectorAdded)
            {
                cipherTextBox.Text = "Reflector not selected";
                return;
            }
            //страшный баг с патч-панелью
            if(!isPatchesAdded)
            {
                cipherTextBox.Text = "A malfunction in the Enigma mechanism. Check the patch panel. If everything is OK, contact the manufacturer";
                return;
            }

            //удаление пробелов в кодируемом сообщении
            inputTextBox.Text = removeSpaces(inputTextBox.Text);

            //вывод шифра                   //вызов функции шифрования
            cipherTextBox.Text = Mechanics.Enigma.encrypt(inputTextBox.Text);
        }
    }
}

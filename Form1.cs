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
        private Regex regexText = new Regex("[A-Z]");
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
            bool isPatchesAdded = PatchPanel.Init(ref textBoxes);
            Mechanics.Enigma.setInitPos((int)key1.Value, (int)key2.Value, (int)key3.Value);
            bool isRotorsAdded = Mechanics.Enigma.setRotorsType(new int[3]
                {(int)rotorSelection1.Value, (int)rotorSelection2.Value, (int)rotorSelection3.Value });
            bool isReflectorAdded = Mechanics.Enigma.setReflectorType(reflectorBox.SelectedIndex);
            if(inputTextBox.TextLength == 0 || !regexText.IsMatch(inputTextBox.Text))
            {
                cipherTextBox.Text = "Kein Text zum Verschlüsseln";
                return;
            }

            if(!isRotorsAdded)
            {
                cipherTextBox.Text = "Keine Rotoren ausgewählt";
                return;
            }

            if(!isReflectorAdded)
            {
                cipherTextBox.Text = "Reflektor nicht ausgewählt";
                return;
            }

            if(!isPatchesAdded)
            {
                cipherTextBox.Text = "Ein Fehler im Enigma-Mechanismus. Überprüfen Sie das Patchfeld. Wenn alles in Ordnung ist, wenden Sie sich an den Hersteller";
                return;
            }
            inputTextBox.Text = removeSpaces(inputTextBox.Text);
            cipherTextBox.Text = Mechanics.Enigma.encrypt(inputTextBox.Text);
        }
    }
}

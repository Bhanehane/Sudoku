using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        List<TextBox> ListeDeTextBox = new List<TextBox>();
        public Form1()
        {
            InitializeComponent();
            CréationListe();
        }

        private void CréationListe()
        {
            ListeDeTextBox.Add(textBoxB1P11);
            ListeDeTextBox.Add(textBoxB1P12);
            ListeDeTextBox.Add(textBoxB1P13);
            ListeDeTextBox.Add(textBoxB1P21);
            ListeDeTextBox.Add(textBoxB1P22);
            ListeDeTextBox.Add(textBoxB1P23);
            ListeDeTextBox.Add(textBoxB1P31);
            ListeDeTextBox.Add(textBoxB1P32);
            ListeDeTextBox.Add(textBoxB1P33);
            ListeDeTextBox.Add(textBoxB2P11);
            ListeDeTextBox.Add(textBoxB2P12);
            ListeDeTextBox.Add(textBoxB2P13);
            ListeDeTextBox.Add(textBoxB2P21);
            ListeDeTextBox.Add(textBoxB2P22);
            ListeDeTextBox.Add(textBoxB2P23);
            ListeDeTextBox.Add(textBoxB2P31);
            ListeDeTextBox.Add(textBoxB2P32);
            ListeDeTextBox.Add(textBoxB2P33);
            ListeDeTextBox.Add(textBoxB3P11);
            ListeDeTextBox.Add(textBoxB3P12);
            ListeDeTextBox.Add(textBoxB3P13);
            ListeDeTextBox.Add(textBoxB3P21);
            ListeDeTextBox.Add(textBoxB3P22);
            ListeDeTextBox.Add(textBoxB3P23);
            ListeDeTextBox.Add(textBoxB3P31);
            ListeDeTextBox.Add(textBoxB3P32);
            ListeDeTextBox.Add(textBoxB3P33);
            ListeDeTextBox.Add(textBoxB4P11);
            ListeDeTextBox.Add(textBoxB4P12);
            ListeDeTextBox.Add(textBoxB4P13);
            ListeDeTextBox.Add(textBoxB4P21);
            ListeDeTextBox.Add(textBoxB4P22);
            ListeDeTextBox.Add(textBoxB4P23);
            ListeDeTextBox.Add(textBoxB4P31);
            ListeDeTextBox.Add(textBoxB4P32);
            ListeDeTextBox.Add(textBoxB4P33);
            ListeDeTextBox.Add(textBoxB5P11);
            ListeDeTextBox.Add(textBoxB5P12);
            ListeDeTextBox.Add(textBoxB5P13);
            ListeDeTextBox.Add(textBoxB5P21);
            ListeDeTextBox.Add(textBoxB5P22);
            ListeDeTextBox.Add(textBoxB5P23);
            ListeDeTextBox.Add(textBoxB5P31);
            ListeDeTextBox.Add(textBoxB5P32);
            ListeDeTextBox.Add(textBoxB5P33);
            ListeDeTextBox.Add(textBoxB6P11);
            ListeDeTextBox.Add(textBoxB6P12);
            ListeDeTextBox.Add(textBoxB6P13);
            ListeDeTextBox.Add(textBoxB6P21);
            ListeDeTextBox.Add(textBoxB6P22);
            ListeDeTextBox.Add(textBoxB6P23);
            ListeDeTextBox.Add(textBoxB6P31);
            ListeDeTextBox.Add(textBoxB6P32);
            ListeDeTextBox.Add(textBoxB6P33);
            ListeDeTextBox.Add(textBoxB7P11);
            ListeDeTextBox.Add(textBoxB7P12);
            ListeDeTextBox.Add(textBoxB7P13);
            ListeDeTextBox.Add(textBoxB7P21);
            ListeDeTextBox.Add(textBoxB7P22);
            ListeDeTextBox.Add(textBoxB7P23);
            ListeDeTextBox.Add(textBoxB7P31);
            ListeDeTextBox.Add(textBoxB7P32);
            ListeDeTextBox.Add(textBoxB7P33);
            ListeDeTextBox.Add(textBoxB8P11);
            ListeDeTextBox.Add(textBoxB8P12);
            ListeDeTextBox.Add(textBoxB8P13);
            ListeDeTextBox.Add(textBoxB8P21);
            ListeDeTextBox.Add(textBoxB8P22);
            ListeDeTextBox.Add(textBoxB8P23);
            ListeDeTextBox.Add(textBoxB8P31);
            ListeDeTextBox.Add(textBoxB8P32);
            ListeDeTextBox.Add(textBoxB8P33);
            ListeDeTextBox.Add(textBoxB9P11);
            ListeDeTextBox.Add(textBoxB9P12);
            ListeDeTextBox.Add(textBoxB9P13);
            ListeDeTextBox.Add(textBoxB9P21);
            ListeDeTextBox.Add(textBoxB9P22);
            ListeDeTextBox.Add(textBoxB9P23);
            ListeDeTextBox.Add(textBoxB9P31);
            ListeDeTextBox.Add(textBoxB9P32);
            ListeDeTextBox.Add(textBoxB9P33);
        }

        private void textBoxB1P11_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB1P11);
        }

        private void textBoxB1P12_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB1P12);
        }

        private void textBoxB1P13_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB1P13);

        }

        private void textBoxB1P21_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB1P21);
        }

        private void textBoxB1P22_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB1P22);
        }

        private void textBoxB1P23_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB1P23);
        }

        private void textBoxB1P31_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB1P31);
        }

        private void textBoxB1P32_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB1P32);
        }

        private void textBoxB1P33_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB1P33);
        }

        private void textBoxB2P11_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB2P11);
        }

        private void textBoxB2P12_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB2P12);
        }

        private void textBoxB2P13_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB2P13);
        }

        private void textBoxB2P21_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB2P21);
        }

        private void textBoxB2P22_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB2P22);
        }

        private void textBoxB2P23_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB2P23);
        }

        private void textBoxB2P31_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB2P31);
        }

        private void textBoxB2P32_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB2P32);
        }

        private void textBoxB2P33_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB2P33);
        }

        private void textBoxB3P11_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB3P11);
        }

        private void textBoxB3P12_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB3P12);
        }

        private void textBoxB3P13_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB3P13);
        }

        private void textBoxB3P21_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB3P21);
        }

        private void textBoxB3P22_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB3P22);
        }

        private void textBoxB3P23_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB3P23);
        }

        private void textBoxB3P31_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB3P31);
        }

        private void textBoxB3P32_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB3P32);
        }

        private void textBoxB3P33_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB3P33);
        }

        private void textBoxB4P11_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB4P11);
        }

        private void textBoxB4P12_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB4P12);
        }

        private void textBoxB4P13_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB4P13);
        }

        private void textBoxB4P21_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB4P21);
        }

        private void textBoxB4P22_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB4P22);
        }

        private void textBoxB4P23_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB4P23);
        }

        private void textBoxB4P31_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB4P31);
        }

        private void textBoxB4P32_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB4P32);
        }

        private void textBoxB4P33_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB4P33);
        }

        private void textBoxB5P11_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB5P11);
        }

        private void textBoxB5P12_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB5P12);
        }

        private void textBoxB5P13_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB5P13);
        }

        private void textBoxB5P21_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB5P21);
        }

        private void textBoxB5P22_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB5P22);
        }

        private void textBoxB5P23_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB5P23);
        }

        private void textBoxB5P31_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB5P31);
        }

        private void textBoxB5P32_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB5P32);
        }

        private void textBoxB5P33_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB5P33);
        }

        private void textBoxB6P11_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB6P11);
        }

        private void textBoxB6P12_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB6P12);
        }

        private void textBoxB6P13_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB6P13);
        }

        private void textBoxB6P21_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB6P21);
        }

        private void textBoxB6P22_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB6P22);
        }

        private void textBoxB6P23_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB6P23);
        }

        private void textBoxB6P31_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB6P31);
        }

        private void textBoxB6P32_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB6P32);
        }

        private void textBoxB6P33_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB6P33);
        }

        private void textBoxB7P11_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB7P11);
        }

        private void textBoxB7P12_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB7P12);
        }

        private void textBoxB7P13_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB7P13);
        }

        private void textBoxB7P21_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB7P21);
        }

        private void textBoxB7P22_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB7P22);
        }

        private void textBoxB7P23_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB7P23);
        }

        private void textBoxB7P31_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB7P31);
        }

        private void textBoxB7P32_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB7P32);
        }

        private void textBoxB7P33_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB7P33);
        }

        private void textBoxB8P11_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB8P11);
        }

        private void textBoxB8P12_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB8P12);
        }

        private void textBoxB8P13_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB8P13);
        }

        private void textBoxB8P21_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB8P21);
        }

        private void textBoxB8P22_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB8P22);
        }

        private void textBoxB8P23_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB8P23);
        }

        private void textBoxB8P31_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB8P31);
        }

        private void textBoxB8P32_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB8P32);
        }

        private void textBoxB8P33_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB8P33);
        }
        
        private void textBoxB9P11_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB9P11);
        }

        private void textBoxB9P12_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB9P12);
        }

        private void textBoxB9P13_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB9P13);
        }

        private void textBoxB9P21_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB9P21);
        }

        private void textBoxB9P22_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB9P22);
        }

        private void textBoxB9P23_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB9P23);
        }

        private void textBoxB9P31_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB9P31);
        }

        private void textBoxB9P32_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB9P32);
        }

        private void textBoxB9P33_TextChanged(object sender, EventArgs e)
        {
            TextBoxChecking(textBoxB9P33);
        }


        private void TextBoxChecking(TextBox textBox)
        {
            if (textBox.Text.Count() == 1)
            {
                if (textBox.Text.Contains('1') || textBox.Text.Contains('2') || textBox.Text.Contains('3') || textBox.Text.Contains('4') || textBox.Text.Contains('5') ||
                   textBox.Text.Contains('6') || textBox.Text.Contains('7') || textBox.Text.Contains('8') || textBox.Text.Contains('9'))
                {

                }
                else
                {
                    textBox.Clear();
                }
            }
        }
    }
}

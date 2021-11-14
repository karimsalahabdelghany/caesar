using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ceasor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String txt = this.text.Text;
            String keyText = this.key.Text;
            int key;

            while (int.TryParse(keyText, out key) == false)
            {
                MessageBox.Show("Invalid input in key");
                this.key.Focus();
                this.key.Text = "0";
                key = 0;
                break;
            }
            
            String encryptedText(int num)
            {
                String cipherText = "";
                int equation;
                for (int x = 0; x < txt.Length; x++)
                {
                    equation = txt[x] + num;
                    if (txt[x] >= 65 && txt[x] <= 90)
                    {
                        cipherText += 
                                equation > 90 ? (char)(equation - 26) 
                                : (char)equation;
                    }
                    else
                    {
                        cipherText +=
                                equation > 122 ? (char)(equation - 26)
                                : (char)equation;
                    }
                    //MessageBox.Show(text[i].ToString());
                    //cipherText = text[i].ToString();
                }
                this.encText.Focus();
                return cipherText;
            }

            this.encText.Text = encryptedText(key);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String text = this.text.Text;
            String keyText = this.key.Text;
            int key;

            while (int.TryParse(keyText, out key) == false)
            {
                MessageBox.Show("Invalid input in key");
                this.key.Focus();
                this.key.Text = "0";
                key = 0;
                break;
            }

            String encryptedText(int num)
            {
                String cipherText = "";
                int equ;
                for (int i = 0; i < text.Length; i++)
                {
                    equ = text[i] - num;
                    if (text[i] >= 65 && text[i] <= 90)
                    {
                        cipherText +=
                                equ < 65 ? (char)(equ + 26)
                                : (char)equ;
                    }
                    else
                    {
                        cipherText +=
                                equ< 97 ? (char)(equ + 26)
                                : (char)equ;
                    }
                    //MessageBox.Show(text[i].ToString());
                    //cipherText = text[i].ToString();
                }
                this.decText.Focus();
                return cipherText;
            }

            this.decText.Text = encryptedText(key);
        }
    }
}

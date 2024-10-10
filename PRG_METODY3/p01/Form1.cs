using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Smaz(ref string text)
        {
            string slova = "";
            foreach (char pismeno in text)
            {
                if (!char.IsDigit(pismeno))
                {
                    slova += pismeno;
                }
            }
            text = slova;
        }

        private void Mezery(ref string text)
        {
            string slova = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ' || (slova.Length > 0 && slova[slova.Length - 1] != ' '))
                {
                    slova += text[i];
                }
            }
            text = slova;
        }

        private void Zobraz(string text, ListBox listbox)
        {
            listbox.Items.Clear();
            Mezery(ref text);
            foreach (string slovo in text.Split(' '))
            {
                listbox.Items.Add(slovo);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            string text = textBox.Text;
            Smaz(ref text);
            Zobraz(text, listBox);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if(textBox.Text != "")
            {
                button.Enabled = true;
            }
            else
            {
                button.Enabled = false;
            }
        }
    }
}
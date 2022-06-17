using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        
        List<char> seznamznaku;

        private void Naplneni(List<char> seznam, TextBox texboxik)
        {
            try
            {
                int pocet = texboxik.Lines.Count();
                for (int i = 0; i < pocet; i++)
                {
                    if (texboxik.Lines[i] != "")
                    {
                        seznam.Add(Convert.ToChar(texboxik.Lines[i]));
                    }
                }
            }
            catch
            {
                MessageBox.Show("Musíš zadat pouze jeden znak :D", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                seznamznaku.Clear();
            }
        }
        private void Vypis(List<char> seznam, ListBox listboxik)
        {
            foreach(char c in seznam)
            {
                listboxik.Items.Add(c);
            }
        }
        private void Smazani(List<char>seznam,ListBox listobox)
        {
            seznam.RemoveAll(x => (x >= 97 && x <= 122) || (x >= 48 && x <= 57));
            Vypis(seznam,listobox);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            seznamznaku = new List<char>();
            Naplneni(seznamznaku, textBox1);
            Vypis(seznamznaku, listBox1);
            Smazani(seznamznaku, listBox2);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ve víceřádkové komponentě TextBox jsou zapsány znaky, v každém řádku jeden znak.\nVytvořte seznam znaků z TextBox pomocí třídy List.\nZnaky z List vypište do komponenty ListBox.\nZe seznamu List vypusťte všechna malá písmena anglické abecedy a všechny číslice.\nOpravený seznam zobrazte.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}

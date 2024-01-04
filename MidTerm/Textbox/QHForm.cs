using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTerm.Textbox
{
    public partial class QHForm : Form
    {

        public bool change = false;
        int length = 0;
        String Tlbl4 = "The number of characters you enter textBox is: ";
        string deslbl4 = "Use Textchange to count number of character on text Box";
        public QHForm()
        {
            InitializeComponent();
        }

        private void QHForm_Load(object sender, EventArgs e)
        {
            label4.Text = Tlbl4 + length;
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {

            if (textBox1.Text == textBox1.Tag.ToString())
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                textBox1.Text = textBox1.Tag.ToString();
                textBox1.ForeColor = Color.Silver;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (change == true)
            {
                if (textBox1.PasswordChar == '*')
                {
                    textBox1.PasswordChar = '\0';
                    change = false;
                }
            }
            else
            {
                if (textBox1.PasswordChar == '\0' && textBox1.Text != textBox1.Tag.ToString())
                {
                    textBox1.PasswordChar = '*';
                    change = true;
                }
            }
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Text = "Show/Hide word ";
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox1.Tag.ToString())
            {
                length = 0;
            }
            else
            {
                length = textBox1.Text.Length;
            }

            label4.Text = Tlbl4 + length;
        }
    }
}

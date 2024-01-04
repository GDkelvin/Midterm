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
    public partial class MouseEventForm : Form
    {
        public MouseEventForm()
        {
            InitializeComponent();
        }

        private void MouseEventForm_Load(object sender, EventArgs e)
        {

        }
        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            textBox5.Text = "Hello!";
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.Text = "Hello!";
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Hello!";
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            textBox3.Text = "You leave me!";
        }

        private void textBox4_DoubleClick(object sender, EventArgs e)
        {
            textBox4.Text = "Hello!";
        }
    }
}

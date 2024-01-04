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
    public partial class MaxLengthForm : Form
    {
        public MaxLengthForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox.MaxLength = 5;
            label2.Text = "Max length is now 5";
        }
    }
}

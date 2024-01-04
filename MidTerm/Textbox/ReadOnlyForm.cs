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
    public partial class ReadOnlyForm : Form
    {
        public ReadOnlyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TextBox.ReadOnly == false)
            {
                TextBox.ReadOnly = true;
                label2.Text = "Read only = true";
            }
            else
            {
                TextBox.ReadOnly = false;
                label2.Text = "Read only = true";
            }
        }
    }
}

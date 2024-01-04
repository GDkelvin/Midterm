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
    public partial class VisibleForm : Form
    {
        public VisibleForm()
        {
            InitializeComponent();
        }

        private void VisibleForm_Load(object sender, EventArgs e)
        {

        }
        private void chkAcpt_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAcpt.Checked)
            {
                textBox12.Visible = true;
                lblYES.Visible = true;
                btnSubmit.Visible = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox12.Text == "YES")
            {
                label5.Visible = true;
            }
        }
    }
}

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
    public partial class AcceptTabForm : Form
    {
        public AcceptTabForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TextBox.AcceptsTab == false)
            {
                TextBox.AcceptsTab = true;
                label2.Text = "Accept Tab = true";
            }
            else
            {
                TextBox.AcceptsTab = false;
                label2.Text = "Accept Tab = false";
            }
            
        }
    }
}

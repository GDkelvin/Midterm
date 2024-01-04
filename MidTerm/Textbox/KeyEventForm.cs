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
    public partial class KeyEventForm : Form
    {
        public KeyEventForm()
        {
            InitializeComponent();
        }
        int SpaceCount = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            SpaceCount = 0;
            lblSpaceCount.Text = "Press Space in Textbox!";
            textBox11.Text = "";
            textBox11.Focus();
        }
        private void KeyEventForm_Load(object sender, EventArgs e)
        {

        }
        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                SpaceCount += 1;
                lblSpaceCount.Text = "You Press Spacebar " + SpaceCount + " time (s)!";
            }
        }
    }
}

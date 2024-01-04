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
    public partial class TabIndexForm : Form
    {
        public TabIndexForm()
        {
            InitializeComponent();
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBoxIndex2.Text = "Hello! If you press Tab with my Textbox TabStop == true. You can Press Tab again to switch to Tab Index = 3";
            textBoxIndex3.Text = "My tab Index = 3!";
            textBoxIndex4.Text = "My tab Index = 4!";

        }

        private void textBoxIndex1_Enter(object sender, EventArgs e)
        {
            textBoxIndex1.Text = "Press Tab in me!";
        }

        private void textBoxIndex4_Enter(object sender, EventArgs e)
        {
            textBoxIndex5.Text = "My tab Index = 5! But you can't press Tab to switch to me due to my TabStop == false";
        }
        private void TabIndexForm_Load(object sender, EventArgs e)
        {

        }
    }
}

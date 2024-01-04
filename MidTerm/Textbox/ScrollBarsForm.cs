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
    public partial class ScrollBarsForm : Form
    {
        public ScrollBarsForm()
        {
            InitializeComponent();
        }

        private void RBtnVertical_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnVertical.Checked)
            {
                TextBox.ScrollBars = ScrollBars.Vertical;
            }
        }

        private void RBtnHorizontal_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnHorizontal.Checked)
            {
                TextBox.ScrollBars = ScrollBars.Horizontal;
            }
        }

        private void RBtnBoth_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnBoth.Checked)
            {
                TextBox.ScrollBars = ScrollBars.Both;
            }
        }

        private void RBtnNone_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnNone.Checked)
            {
                TextBox.ScrollBars = ScrollBars.None;
            }
        }

        private void ScrollBarsForm_Load(object sender, EventArgs e)
        {

        }
    }
}

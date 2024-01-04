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
    public partial class BackColorForm : Form
    {
        public BackColorForm()
        {
            InitializeComponent();
        }

        private void BackColorForm_Load(object sender, EventArgs e)
        {

        }
        private void TextBox_MouseHover(object sender, EventArgs e)
        {

            TextBox.ForeColor = Color.Red;
        }

        private void TextBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox.ForeColor = SystemColors.ControlText;
        }
    }
}

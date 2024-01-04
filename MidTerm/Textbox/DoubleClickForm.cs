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
    public partial class DoubleClickForm : Form
    {
        public DoubleClickForm()
        {
            InitializeComponent();
        }
        private void TextBox_DoubleClick(object sender, EventArgs e)
        {
            TextBox.SelectAll();
            Clipboard.SetText(TextBox.Text);
            MessageBox.Show("Copied to clipboard");
        }
        private void DoubleClickForm_Load(object sender, EventArgs e)
        {

        }
    }
}

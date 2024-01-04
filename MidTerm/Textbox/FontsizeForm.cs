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
    public partial class FontsizeForm : Form
    {
        public FontsizeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Font myFont = new Font("Consolas", 12, FontStyle.Bold | FontStyle.Italic);
            TextBox.Font = myFont;
        }

        private void FontsizeForm_Load(object sender, EventArgs e)
        {

        }
    }
}

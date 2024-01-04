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
    public partial class ChangeSizeForm : Form
    {
        public ChangeSizeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox.Height -= 40;
        }

        private void ChangeSizeForm_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class ForeColorForm : Form
    {
        public ForeColorForm()
        {
            InitializeComponent();
        }

        private void ForeColorForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox.BackColor = Color.Black;
            TextBox.ForeColor = Color.White;
        }
    }
}

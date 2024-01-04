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
    public partial class CharacterCasingForm : Form
    {
        public CharacterCasingForm()
        {
            InitializeComponent();
        }

        private void btnUppercase_Click(object sender, EventArgs e)
        {
            TextBox.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnLowercase_Click(object sender, EventArgs e)
        {
            TextBox.CharacterCasing = CharacterCasing.Lower;
        }
    }
}

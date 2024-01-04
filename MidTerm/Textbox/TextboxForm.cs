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
    public partial class TextboxForm : Form
    {
        public TextboxForm()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void openChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void TextboxForm_Load(object sender, EventArgs e)
        {

        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            openChildForm(new VisibleForm());
        }

        private void btnMouseEvent_Click(object sender, EventArgs e)
        {
            openChildForm(new MouseEventForm());
        }

        private void btnKeyEvent_Click(object sender, EventArgs e)
        {
            openChildForm(new KeyEventForm());
        }

        private void btnTabIndex_Click(object sender, EventArgs e)
        {
            openChildForm(new TabIndexForm());
        }

        private void btnScrollBar_Click(object sender, EventArgs e)
        {
            openChildForm(new ScrollBarsForm());
        }

        private void btnWordWrap_Click(object sender, EventArgs e)
        {
            openChildForm(new WordWrapForm());
        }

        private void btnDoubleClick_Click(object sender, EventArgs e)
        {
            openChildForm(new DoubleClickForm());
        }

        private void btnCharCasing_Click(object sender, EventArgs e)
        {
            openChildForm(new CharacterCasingForm());
        }

        private void BtnQHuy_Click(object sender, EventArgs e)
        {
            openChildForm(new QHForm());
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            openChildForm(new ChangeSizeForm());
        }

        private void btnForeColor_Click(object sender, EventArgs e)
        {
            openChildForm(new ForeColorForm());
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            openChildForm(new BackColorForm());
        }

        private void btnTextAlign_Click(object sender, EventArgs e)
        {
            openChildForm(new TextAlign());
        }

        private void btnMaxLength_Click(object sender, EventArgs e)
        {
            openChildForm(new MaxLengthForm());
        }

        private void btnReadOnly_Click(object sender, EventArgs e)
        {
            openChildForm(new ReadOnlyForm());
        }

        private void btnAcceptTab_Click(object sender, EventArgs e)
        {
            openChildForm(new AcceptTabForm());
        }

        private void btnFontsize_Click(object sender, EventArgs e)
        {
            openChildForm(new FontsizeForm());
        }

        
    }
}

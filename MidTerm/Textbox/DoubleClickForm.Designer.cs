
namespace MidTerm.Textbox
{
    partial class DoubleClickForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoubleClickForm));
            this.richTxtDes = new System.Windows.Forms.RichTextBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTxtDes
            // 
            this.richTxtDes.Font = new System.Drawing.Font("Arial", 10F);
            this.richTxtDes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.richTxtDes.Location = new System.Drawing.Point(12, 220);
            this.richTxtDes.Name = "richTxtDes";
            this.richTxtDes.ReadOnly = true;
            this.richTxtDes.Size = new System.Drawing.Size(543, 223);
            this.richTxtDes.TabIndex = 46;
            this.richTxtDes.Text = resources.GetString("richTxtDes.Text");
            // 
            // TextBox
            // 
            this.TextBox.AcceptsReturn = true;
            this.TextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.TextBox.Location = new System.Drawing.Point(12, 30);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(543, 131);
            this.TextBox.TabIndex = 47;
            this.TextBox.Tag = " You can enter something";
            this.TextBox.Text = resources.GetString("TextBox.Text");
            this.TextBox.WordWrap = false;
            this.TextBox.DoubleClick += new System.EventHandler(this.TextBox_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(8, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Double Click Event";
            // 
            // DoubleClickForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 609);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTxtDes);
            this.Controls.Add(this.TextBox);
            this.Name = "DoubleClickForm";
            this.Text = "DoubleClickForm";
            this.Load += new System.EventHandler(this.DoubleClickForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtDes;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label label1;
    }
}
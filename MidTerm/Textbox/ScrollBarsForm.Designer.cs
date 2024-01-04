
namespace MidTerm.Textbox
{
    partial class ScrollBarsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrollBarsForm));
            this.btnClear = new System.Windows.Forms.Button();
            this.RBtnNone = new System.Windows.Forms.RadioButton();
            this.RBtnBoth = new System.Windows.Forms.RadioButton();
            this.RBtnHorizontal = new System.Windows.Forms.RadioButton();
            this.RBtnVertical = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.richTxtDes = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(536, -129);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(51, 34);
            this.btnClear.TabIndex = 47;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // RBtnNone
            // 
            this.RBtnNone.AutoSize = true;
            this.RBtnNone.Location = new System.Drawing.Point(344, 214);
            this.RBtnNone.Name = "RBtnNone";
            this.RBtnNone.Size = new System.Drawing.Size(51, 17);
            this.RBtnNone.TabIndex = 45;
            this.RBtnNone.TabStop = true;
            this.RBtnNone.Text = "None";
            this.RBtnNone.UseVisualStyleBackColor = true;
            this.RBtnNone.CheckedChanged += new System.EventHandler(this.RBtnNone_CheckedChanged);
            // 
            // RBtnBoth
            // 
            this.RBtnBoth.AutoSize = true;
            this.RBtnBoth.Location = new System.Drawing.Point(247, 214);
            this.RBtnBoth.Name = "RBtnBoth";
            this.RBtnBoth.Size = new System.Drawing.Size(47, 17);
            this.RBtnBoth.TabIndex = 44;
            this.RBtnBoth.TabStop = true;
            this.RBtnBoth.Text = "Both";
            this.RBtnBoth.UseVisualStyleBackColor = true;
            this.RBtnBoth.CheckedChanged += new System.EventHandler(this.RBtnBoth_CheckedChanged);
            // 
            // RBtnHorizontal
            // 
            this.RBtnHorizontal.AutoSize = true;
            this.RBtnHorizontal.Location = new System.Drawing.Point(122, 214);
            this.RBtnHorizontal.Name = "RBtnHorizontal";
            this.RBtnHorizontal.Size = new System.Drawing.Size(72, 17);
            this.RBtnHorizontal.TabIndex = 43;
            this.RBtnHorizontal.TabStop = true;
            this.RBtnHorizontal.Text = "Horizontal";
            this.RBtnHorizontal.UseVisualStyleBackColor = true;
            this.RBtnHorizontal.CheckedChanged += new System.EventHandler(this.RBtnHorizontal_CheckedChanged);
            // 
            // RBtnVertical
            // 
            this.RBtnVertical.AutoSize = true;
            this.RBtnVertical.Location = new System.Drawing.Point(12, 214);
            this.RBtnVertical.Name = "RBtnVertical";
            this.RBtnVertical.Size = new System.Drawing.Size(60, 17);
            this.RBtnVertical.TabIndex = 42;
            this.RBtnVertical.TabStop = true;
            this.RBtnVertical.Text = "Vertical";
            this.RBtnVertical.UseVisualStyleBackColor = true;
            this.RBtnVertical.CheckedChanged += new System.EventHandler(this.RBtnVertical_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(201, -138);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(71, 16);
            this.lblTitle.TabIndex = 41;
            this.lblTitle.Text = "Scroll Bar";
            // 
            // TextBox
            // 
            this.TextBox.AcceptsReturn = true;
            this.TextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.TextBox.Location = new System.Drawing.Point(12, 41);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(543, 131);
            this.TextBox.TabIndex = 39;
            this.TextBox.Tag = " You can enter something";
            this.TextBox.WordWrap = false;
            // 
            // richTxtDes
            // 
            this.richTxtDes.Font = new System.Drawing.Font("Arial", 10F);
            this.richTxtDes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.richTxtDes.Location = new System.Drawing.Point(15, 257);
            this.richTxtDes.Name = "richTxtDes";
            this.richTxtDes.ReadOnly = true;
            this.richTxtDes.Size = new System.Drawing.Size(543, 223);
            this.richTxtDes.TabIndex = 1;
            this.richTxtDes.Text = resources.GetString("richTxtDes.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "ScrollBars";
            // 
            // ScrollBarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 609);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTxtDes);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.RBtnNone);
            this.Controls.Add(this.RBtnBoth);
            this.Controls.Add(this.RBtnHorizontal);
            this.Controls.Add(this.RBtnVertical);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.TextBox);
            this.Name = "ScrollBarsForm";
            this.Text = "ScrollBarsForm";
            this.Load += new System.EventHandler(this.ScrollBarsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton RBtnNone;
        private System.Windows.Forms.RadioButton RBtnBoth;
        private System.Windows.Forms.RadioButton RBtnHorizontal;
        private System.Windows.Forms.RadioButton RBtnVertical;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.RichTextBox richTxtDes;
        private System.Windows.Forms.Label label1;
    }
}
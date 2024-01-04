
namespace MidTerm.Textbox
{
    partial class VisibleForm
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
            this.pnlVisible = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblYES = new System.Windows.Forms.Label();
            this.chkAcpt = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTxtDes = new System.Windows.Forms.RichTextBox();
            this.pnlVisible.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlVisible
            // 
            this.pnlVisible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVisible.Controls.Add(this.label5);
            this.pnlVisible.Controls.Add(this.btnSubmit);
            this.pnlVisible.Controls.Add(this.lblYES);
            this.pnlVisible.Controls.Add(this.chkAcpt);
            this.pnlVisible.Controls.Add(this.label2);
            this.pnlVisible.Controls.Add(this.textBox12);
            this.pnlVisible.Controls.Add(this.label4);
            this.pnlVisible.Location = new System.Drawing.Point(11, 11);
            this.pnlVisible.Margin = new System.Windows.Forms.Padding(2);
            this.pnlVisible.Name = "pnlVisible";
            this.pnlVisible.Size = new System.Drawing.Size(465, 342);
            this.pnlVisible.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Delete succesfully!";
            this.label5.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(232, 145);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(49, 20);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblYES
            // 
            this.lblYES.AutoSize = true;
            this.lblYES.Location = new System.Drawing.Point(16, 124);
            this.lblYES.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYES.Name = "lblYES";
            this.lblYES.Size = new System.Drawing.Size(115, 13);
            this.lblYES.TabIndex = 10;
            this.lblYES.Text = "Enter YES to continue!";
            this.lblYES.Visible = false;
            // 
            // chkAcpt
            // 
            this.chkAcpt.AutoSize = true;
            this.chkAcpt.Location = new System.Drawing.Point(16, 86);
            this.chkAcpt.Margin = new System.Windows.Forms.Padding(2);
            this.chkAcpt.Name = "chkAcpt";
            this.chkAcpt.Size = new System.Drawing.Size(111, 17);
            this.chkAcpt.TabIndex = 9;
            this.chkAcpt.Text = "I want to continue";
            this.chkAcpt.UseVisualStyleBackColor = true;
            this.chkAcpt.CheckedChanged += new System.EventHandler(this.chkAcpt_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Continue this will permanently delete this file (not true)!";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(16, 145);
            this.textBox12.Margin = new System.Windows.Forms.Padding(2);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(201, 20);
            this.textBox12.TabIndex = 7;
            this.textBox12.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Visible";
            // 
            // richTxtDes
            // 
            this.richTxtDes.Font = new System.Drawing.Font("Arial", 10F);
            this.richTxtDes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.richTxtDes.Location = new System.Drawing.Point(12, 381);
            this.richTxtDes.Name = "richTxtDes";
            this.richTxtDes.ReadOnly = true;
            this.richTxtDes.Size = new System.Drawing.Size(543, 201);
            this.richTxtDes.TabIndex = 48;
            this.richTxtDes.Text = "A textbox can be visible or not due to property change\nYou can change the visible" +
    " property via code:\n\n  if(textBox12.Text==\"YES\") {\n      label5.Visible = true;\n" +
    "  }";
            // 
            // VisibleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 609);
            this.Controls.Add(this.richTxtDes);
            this.Controls.Add(this.pnlVisible);
            this.Name = "VisibleForm";
            this.Text = "VisibleForm";
            this.Load += new System.EventHandler(this.VisibleForm_Load);
            this.pnlVisible.ResumeLayout(false);
            this.pnlVisible.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVisible;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblYES;
        private System.Windows.Forms.CheckBox chkAcpt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTxtDes;
    }
}
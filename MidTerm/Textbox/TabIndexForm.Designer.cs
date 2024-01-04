
namespace MidTerm.Textbox
{
    partial class TabIndexForm
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
            this.pnlTabIndex = new System.Windows.Forms.Panel();
            this.textBoxIndex4 = new System.Windows.Forms.TextBox();
            this.textBoxIndex3 = new System.Windows.Forms.TextBox();
            this.textBoxIndex5 = new System.Windows.Forms.TextBox();
            this.textBoxIndex2 = new System.Windows.Forms.TextBox();
            this.textBoxIndex1 = new System.Windows.Forms.TextBox();
            this.lblTabIndex = new System.Windows.Forms.Label();
            this.richTxtDes = new System.Windows.Forms.RichTextBox();
            this.pnlTabIndex.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTabIndex
            // 
            this.pnlTabIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTabIndex.Controls.Add(this.textBoxIndex4);
            this.pnlTabIndex.Controls.Add(this.textBoxIndex3);
            this.pnlTabIndex.Controls.Add(this.textBoxIndex5);
            this.pnlTabIndex.Controls.Add(this.textBoxIndex2);
            this.pnlTabIndex.Controls.Add(this.textBoxIndex1);
            this.pnlTabIndex.Controls.Add(this.lblTabIndex);
            this.pnlTabIndex.Location = new System.Drawing.Point(11, 11);
            this.pnlTabIndex.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTabIndex.Name = "pnlTabIndex";
            this.pnlTabIndex.Size = new System.Drawing.Size(465, 342);
            this.pnlTabIndex.TabIndex = 39;
            // 
            // textBoxIndex4
            // 
            this.textBoxIndex4.Location = new System.Drawing.Point(26, 145);
            this.textBoxIndex4.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIndex4.Multiline = true;
            this.textBoxIndex4.Name = "textBoxIndex4";
            this.textBoxIndex4.Size = new System.Drawing.Size(76, 88);
            this.textBoxIndex4.TabIndex = 4;
            this.textBoxIndex4.Enter += new System.EventHandler(this.textBoxIndex4_Enter);
            // 
            // textBoxIndex3
            // 
            this.textBoxIndex3.Location = new System.Drawing.Point(56, 249);
            this.textBoxIndex3.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIndex3.Multiline = true;
            this.textBoxIndex3.Name = "textBoxIndex3";
            this.textBoxIndex3.Size = new System.Drawing.Size(76, 88);
            this.textBoxIndex3.TabIndex = 3;
            // 
            // textBoxIndex5
            // 
            this.textBoxIndex5.Location = new System.Drawing.Point(154, 191);
            this.textBoxIndex5.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIndex5.Multiline = true;
            this.textBoxIndex5.Name = "textBoxIndex5";
            this.textBoxIndex5.ReadOnly = true;
            this.textBoxIndex5.Size = new System.Drawing.Size(218, 88);
            this.textBoxIndex5.TabIndex = 5;
            this.textBoxIndex5.TabStop = false;
            // 
            // textBoxIndex2
            // 
            this.textBoxIndex2.Location = new System.Drawing.Point(131, 66);
            this.textBoxIndex2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIndex2.Multiline = true;
            this.textBoxIndex2.Name = "textBoxIndex2";
            this.textBoxIndex2.ReadOnly = true;
            this.textBoxIndex2.Size = new System.Drawing.Size(218, 88);
            this.textBoxIndex2.TabIndex = 2;
            this.textBoxIndex2.Enter += new System.EventHandler(this.textBox3_Enter);
            // 
            // textBoxIndex1
            // 
            this.textBoxIndex1.Location = new System.Drawing.Point(26, 34);
            this.textBoxIndex1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIndex1.Multiline = true;
            this.textBoxIndex1.Name = "textBoxIndex1";
            this.textBoxIndex1.Size = new System.Drawing.Size(76, 88);
            this.textBoxIndex1.TabIndex = 1;
            this.textBoxIndex1.Text = "Click me!";
            this.textBoxIndex1.Enter += new System.EventHandler(this.textBoxIndex1_Enter);
            // 
            // lblTabIndex
            // 
            this.lblTabIndex.AutoSize = true;
            this.lblTabIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabIndex.Location = new System.Drawing.Point(12, 14);
            this.lblTabIndex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTabIndex.Name = "lblTabIndex";
            this.lblTabIndex.Size = new System.Drawing.Size(71, 18);
            this.lblTabIndex.TabIndex = 0;
            this.lblTabIndex.Text = "Tab Index";
            // 
            // richTxtDes
            // 
            this.richTxtDes.Font = new System.Drawing.Font("Arial", 10F);
            this.richTxtDes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.richTxtDes.Location = new System.Drawing.Point(11, 383);
            this.richTxtDes.Name = "richTxtDes";
            this.richTxtDes.ReadOnly = true;
            this.richTxtDes.Size = new System.Drawing.Size(543, 201);
            this.richTxtDes.TabIndex = 48;
            this.richTxtDes.Text = "The index value of the control within the set of controls within its container. T" +
    "he controls in the container are included in the tab order.\nTextbox1.TabIndex = " +
    "1;\\nTextbox1.TabStop = true;";
            // 
            // TabIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 609);
            this.Controls.Add(this.richTxtDes);
            this.Controls.Add(this.pnlTabIndex);
            this.Name = "TabIndexForm";
            this.Text = "TabIndexForm";
            this.Load += new System.EventHandler(this.TabIndexForm_Load);
            this.pnlTabIndex.ResumeLayout(false);
            this.pnlTabIndex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTabIndex;
        private System.Windows.Forms.TextBox textBoxIndex4;
        private System.Windows.Forms.TextBox textBoxIndex3;
        private System.Windows.Forms.TextBox textBoxIndex5;
        private System.Windows.Forms.TextBox textBoxIndex2;
        private System.Windows.Forms.TextBox textBoxIndex1;
        private System.Windows.Forms.Label lblTabIndex;
        private System.Windows.Forms.RichTextBox richTxtDes;
    }
}
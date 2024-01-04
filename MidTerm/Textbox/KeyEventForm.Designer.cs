
namespace MidTerm.Textbox
{
    partial class KeyEventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyEventForm));
            this.pnlKeyEvent = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lblSpaceCount = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.lblKeyEvent = new System.Windows.Forms.Label();
            this.richTxtDes = new System.Windows.Forms.RichTextBox();
            this.pnlKeyEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlKeyEvent
            // 
            this.pnlKeyEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKeyEvent.Controls.Add(this.button2);
            this.pnlKeyEvent.Controls.Add(this.lblSpaceCount);
            this.pnlKeyEvent.Controls.Add(this.textBox11);
            this.pnlKeyEvent.Controls.Add(this.lblKeyEvent);
            this.pnlKeyEvent.Location = new System.Drawing.Point(11, 11);
            this.pnlKeyEvent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlKeyEvent.Name = "pnlKeyEvent";
            this.pnlKeyEvent.Size = new System.Drawing.Size(465, 342);
            this.pnlKeyEvent.TabIndex = 41;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 53);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 9;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblSpaceCount
            // 
            this.lblSpaceCount.AutoSize = true;
            this.lblSpaceCount.Location = new System.Drawing.Point(44, 89);
            this.lblSpaceCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpaceCount.Name = "lblSpaceCount";
            this.lblSpaceCount.Size = new System.Drawing.Size(122, 13);
            this.lblSpaceCount.TabIndex = 8;
            this.lblSpaceCount.Text = "Press Space in Textbox!";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(29, 54);
            this.textBox11.Margin = new System.Windows.Forms.Padding(2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(201, 20);
            this.textBox11.TabIndex = 7;
            this.textBox11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox11_KeyPress);
            // 
            // lblKeyEvent
            // 
            this.lblKeyEvent.AutoSize = true;
            this.lblKeyEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyEvent.Location = new System.Drawing.Point(26, 14);
            this.lblKeyEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKeyEvent.Name = "lblKeyEvent";
            this.lblKeyEvent.Size = new System.Drawing.Size(74, 18);
            this.lblKeyEvent.TabIndex = 6;
            this.lblKeyEvent.Text = "Key Event";
            // 
            // richTxtDes
            // 
            this.richTxtDes.Font = new System.Drawing.Font("Arial", 10F);
            this.richTxtDes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.richTxtDes.Location = new System.Drawing.Point(12, 370);
            this.richTxtDes.Name = "richTxtDes";
            this.richTxtDes.ReadOnly = true;
            this.richTxtDes.Size = new System.Drawing.Size(543, 201);
            this.richTxtDes.TabIndex = 48;
            this.richTxtDes.Text = resources.GetString("richTxtDes.Text");
            // 
            // KeyEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 609);
            this.Controls.Add(this.richTxtDes);
            this.Controls.Add(this.pnlKeyEvent);
            this.Name = "KeyEventForm";
            this.Text = "KeyEventForm";
            this.Load += new System.EventHandler(this.KeyEventForm_Load);
            this.pnlKeyEvent.ResumeLayout(false);
            this.pnlKeyEvent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlKeyEvent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblSpaceCount;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label lblKeyEvent;
        private System.Windows.Forms.RichTextBox richTxtDes;
    }
}

namespace MidTerm.Textbox
{
    partial class MouseEventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MouseEventForm));
            this.pnlMouseEvent = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMouseEvent = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.richTxtDes = new System.Windows.Forms.RichTextBox();
            this.pnlMouseEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMouseEvent
            // 
            this.pnlMouseEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMouseEvent.Controls.Add(this.textBox4);
            this.pnlMouseEvent.Controls.Add(this.textBox3);
            this.pnlMouseEvent.Controls.Add(this.textBox2);
            this.pnlMouseEvent.Controls.Add(this.textBox1);
            this.pnlMouseEvent.Controls.Add(this.lblMouseEvent);
            this.pnlMouseEvent.Controls.Add(this.textBox5);
            this.pnlMouseEvent.Location = new System.Drawing.Point(11, 11);
            this.pnlMouseEvent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMouseEvent.Name = "pnlMouseEvent";
            this.pnlMouseEvent.Size = new System.Drawing.Size(465, 342);
            this.pnlMouseEvent.TabIndex = 40;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(263, 191);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 88);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "Double Click me!";
            this.textBox4.DoubleClick += new System.EventHandler(this.textBox4_DoubleClick);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(86, 191);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 88);
            this.textBox3.TabIndex = 9;
            this.textBox3.MouseLeave += new System.EventHandler(this.textBox3_MouseLeave);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(347, 63);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 88);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Hold in me!";
            this.textBox2.MouseEnter += new System.EventHandler(this.textBox2_MouseEnter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 63);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 88);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Hover me!";
            this.textBox1.MouseHover += new System.EventHandler(this.textBox1_MouseHover);
            // 
            // lblMouseEvent
            // 
            this.lblMouseEvent.AutoSize = true;
            this.lblMouseEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMouseEvent.Location = new System.Drawing.Point(26, 14);
            this.lblMouseEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMouseEvent.Name = "lblMouseEvent";
            this.lblMouseEvent.Size = new System.Drawing.Size(95, 18);
            this.lblMouseEvent.TabIndex = 6;
            this.lblMouseEvent.Text = "Mouse Event";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(28, 63);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(76, 88);
            this.textBox5.TabIndex = 1;
            this.textBox5.Text = "Click me!";
            this.textBox5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox5_MouseClick);
            // 
            // richTxtDes
            // 
            this.richTxtDes.Font = new System.Drawing.Font("Arial", 10F);
            this.richTxtDes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.richTxtDes.Location = new System.Drawing.Point(11, 378);
            this.richTxtDes.Name = "richTxtDes";
            this.richTxtDes.ReadOnly = true;
            this.richTxtDes.Size = new System.Drawing.Size(543, 201);
            this.richTxtDes.TabIndex = 49;
            this.richTxtDes.Text = resources.GetString("richTxtDes.Text");
            // 
            // MouseEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 609);
            this.Controls.Add(this.richTxtDes);
            this.Controls.Add(this.pnlMouseEvent);
            this.Name = "MouseEventForm";
            this.Text = "MouseEventForm";
            this.Load += new System.EventHandler(this.MouseEventForm_Load);
            this.pnlMouseEvent.ResumeLayout(false);
            this.pnlMouseEvent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMouseEvent;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMouseEvent;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RichTextBox richTxtDes;
    }
}
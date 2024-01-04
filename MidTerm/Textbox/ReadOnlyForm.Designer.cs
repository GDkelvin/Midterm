﻿
namespace MidTerm.Textbox
{
    partial class ReadOnlyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadOnlyForm));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTxtDes = new System.Windows.Forms.RichTextBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Read Only";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 33);
            this.button1.TabIndex = 66;
            this.button1.Text = "Read only mode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTxtDes
            // 
            this.richTxtDes.Font = new System.Drawing.Font("Arial", 10F);
            this.richTxtDes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.richTxtDes.Location = new System.Drawing.Point(16, 270);
            this.richTxtDes.Name = "richTxtDes";
            this.richTxtDes.ReadOnly = true;
            this.richTxtDes.Size = new System.Drawing.Size(543, 201);
            this.richTxtDes.TabIndex = 64;
            this.richTxtDes.Text = resources.GetString("richTxtDes.Text");
            // 
            // TextBox
            // 
            this.TextBox.AcceptsReturn = true;
            this.TextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.TextBox.Location = new System.Drawing.Point(16, 41);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(543, 131);
            this.TextBox.TabIndex = 65;
            this.TextBox.Tag = " You can enter something";
            this.TextBox.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Read only = false";
            // 
            // ReadOnlyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 609);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTxtDes);
            this.Controls.Add(this.TextBox);
            this.Name = "ReadOnlyForm";
            this.Text = "ReadOnlyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTxtDes;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label label2;
    }
}
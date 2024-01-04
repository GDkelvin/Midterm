
namespace MidTerm.Textbox
{
    partial class CharacterCasingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterCasingForm));
            this.label1 = new System.Windows.Forms.Label();
            this.richTxtDes = new System.Windows.Forms.RichTextBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.btnLowercase = new System.Windows.Forms.Button();
            this.btnUppercase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Character casing";
            // 
            // richTxtDes
            // 
            this.richTxtDes.Font = new System.Drawing.Font("Arial", 10F);
            this.richTxtDes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.richTxtDes.Location = new System.Drawing.Point(-1, 284);
            this.richTxtDes.Name = "richTxtDes";
            this.richTxtDes.ReadOnly = true;
            this.richTxtDes.Size = new System.Drawing.Size(543, 223);
            this.richTxtDes.TabIndex = 53;
            this.richTxtDes.Text = resources.GetString("richTxtDes.Text");
            // 
            // TextBox
            // 
            this.TextBox.AcceptsReturn = true;
            this.TextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.TextBox.Location = new System.Drawing.Point(12, 37);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(543, 131);
            this.TextBox.TabIndex = 54;
            this.TextBox.Tag = " You can enter something";
            this.TextBox.Text = resources.GetString("TextBox.Text");
            this.TextBox.WordWrap = false;
            // 
            // btnLowercase
            // 
            this.btnLowercase.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLowercase.Location = new System.Drawing.Point(301, 201);
            this.btnLowercase.Name = "btnLowercase";
            this.btnLowercase.Size = new System.Drawing.Size(132, 45);
            this.btnLowercase.TabIndex = 58;
            this.btnLowercase.Text = "Lowercase";
            this.btnLowercase.UseVisualStyleBackColor = true;
            this.btnLowercase.Click += new System.EventHandler(this.btnLowercase_Click);
            // 
            // btnUppercase
            // 
            this.btnUppercase.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUppercase.Location = new System.Drawing.Point(101, 201);
            this.btnUppercase.Name = "btnUppercase";
            this.btnUppercase.Size = new System.Drawing.Size(132, 45);
            this.btnUppercase.TabIndex = 57;
            this.btnUppercase.Text = "Uppercase";
            this.btnUppercase.UseVisualStyleBackColor = true;
            this.btnUppercase.Click += new System.EventHandler(this.btnUppercase_Click);
            // 
            // CharacterCasingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 609);
            this.Controls.Add(this.btnLowercase);
            this.Controls.Add(this.btnUppercase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTxtDes);
            this.Controls.Add(this.TextBox);
            this.Name = "CharacterCasingForm";
            this.Text = "CharacterCasingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTxtDes;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button btnLowercase;
        private System.Windows.Forms.Button btnUppercase;
    }
}
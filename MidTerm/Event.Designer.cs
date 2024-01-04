namespace MidTerm
{
    partial class Event
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Event));
            this.panel6 = new System.Windows.Forms.Panel();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.AutoScrollMargin = new System.Drawing.Size(547, 665);
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.richTextBox4);
            this.panel6.Controls.Add(this.richTextBox3);
            this.panel6.Controls.Add(this.label73);
            this.panel6.Controls.Add(this.richTextBox2);
            this.panel6.Controls.Add(this.richTextBox1);
            this.panel6.Controls.Add(this.label65);
            this.panel6.Controls.Add(this.label61);
            this.panel6.Controls.Add(this.label66);
            this.panel6.Controls.Add(this.label72);
            this.panel6.Controls.Add(this.label67);
            this.panel6.Controls.Add(this.label71);
            this.panel6.Controls.Add(this.label68);
            this.panel6.Controls.Add(this.label70);
            this.panel6.Controls.Add(this.label69);
            this.panel6.Location = new System.Drawing.Point(1, 1);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(763, 782);
            this.panel6.TabIndex = 5;
            // 
            // richTextBox4
            // 
            this.richTextBox4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.richTextBox4.Location = new System.Drawing.Point(40, 460);
            this.richTextBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(304, 73);
            this.richTextBox4.TabIndex = 48;
            this.richTextBox4.Text = "private void cboPay_SelectedValueChanged(object sender, EventArgs e)\n{\n    Messag" +
    "eBox.Show(\"You choose by \" + cboPay.SelectedItem);\n}";
            // 
            // richTextBox3
            // 
            this.richTextBox3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.richTextBox3.Location = new System.Drawing.Point(40, 304);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(304, 112);
            this.richTextBox3.TabIndex = 47;
            this.richTextBox3.Text = "private void cboDay_DropDown(object sender, EventArgs e)\n{\n    cboDay.Items.Clear" +
    "();\n    cboDay.Items.Add(\"1\");\n    cboDay.Items.Add(\"2\");\n    cboDay.Items.Add(\"" +
    "3\");\n    cboDay.Items.Add(\"4\");\n}";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.Location = new System.Drawing.Point(31, 174);
            this.label73.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(284, 15);
            this.label73.TabIndex = 46;
            this.label73.Text = "has committed the selection by moving focus away.\r\n";
            // 
            // richTextBox2
            // 
            this.richTextBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.richTextBox2.Location = new System.Drawing.Point(43, 197);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(304, 67);
            this.richTextBox2.TabIndex = 45;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.richTextBox1.Location = new System.Drawing.Point(43, 80);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(304, 71);
            this.richTextBox1.TabIndex = 44;
            this.richTextBox1.Text = "private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)\n{\n   " +
    " lbValue1.Text = cboDepartment.Text;\n}";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.ForeColor = System.Drawing.Color.Red;
            this.label65.Location = new System.Drawing.Point(11, 435);
            this.label65.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(19, 20);
            this.label65.TabIndex = 43;
            this.label65.Text = "4";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(7, 5);
            this.label61.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(73, 26);
            this.label61.TabIndex = 3;
            this.label61.Text = "Event";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.Location = new System.Drawing.Point(33, 439);
            this.label66.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(385, 15);
            this.label66.TabIndex = 41;
            this.label66.Text = "SelectedValueChanged: holds the value of the currently selected item.\r\n";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.Location = new System.Drawing.Point(30, 46);
            this.label72.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(396, 15);
            this.label72.TabIndex = 32;
            this.label72.Text = "SelectedIndexChanged: when the SelectedIndex property has changed.\r\n";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.ForeColor = System.Drawing.Color.Red;
            this.label67.Location = new System.Drawing.Point(9, 283);
            this.label67.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(19, 20);
            this.label67.TabIndex = 40;
            this.label67.Text = "3";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.ForeColor = System.Drawing.Color.Red;
            this.label71.Location = new System.Drawing.Point(9, 42);
            this.label71.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(19, 20);
            this.label71.TabIndex = 34;
            this.label71.Text = "1";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.Location = new System.Drawing.Point(30, 287);
            this.label68.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(366, 15);
            this.label68.TabIndex = 38;
            this.label68.Text = "DropDown: when the drop-down portion of a ComboBox is shown.";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.Location = new System.Drawing.Point(30, 159);
            this.label70.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(408, 30);
            this.label70.TabIndex = 35;
            this.label70.Text = "SelectionChangeCommitted: the user has changed the selected item and \r\n\r\n";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.ForeColor = System.Drawing.Color.Red;
            this.label69.Location = new System.Drawing.Point(9, 158);
            this.label69.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(19, 20);
            this.label69.TabIndex = 37;
            this.label69.Text = "2";
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 609);
            this.Controls.Add(this.panel6);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Event";
            this.Text = "Event";
            this.Load += new System.EventHandler(this.Event_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label69;
    }
}
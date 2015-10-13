namespace IsWasWhenWill
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpInitial1 = new System.Windows.Forms.DateTimePicker();
            this.dtpInitial2 = new System.Windows.Forms.DateTimePicker();
            this.dtpResult1 = new System.Windows.Forms.DateTimePicker();
            this.dtpResult2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(104, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 28);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Day(s)",
            "Week(s)",
            "Month(s)",
            "Year(s)"});
            this.comboBox1.Location = new System.Drawing.Point(143, 2);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(64, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // dtpInitial1
            // 
            this.dtpInitial1.Location = new System.Drawing.Point(104, 22);
            this.dtpInitial1.Name = "dtpInitial1";
            this.dtpInitial1.Size = new System.Drawing.Size(186, 20);
            this.dtpInitial1.TabIndex = 1;
            // 
            // dtpInitial2
            // 
            this.dtpInitial2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpInitial2.Location = new System.Drawing.Point(296, 22);
            this.dtpInitial2.Name = "dtpInitial2";
            this.dtpInitial2.Size = new System.Drawing.Size(80, 20);
            this.dtpInitial2.TabIndex = 2;
            // 
            // dtpResult1
            // 
            this.dtpResult1.Location = new System.Drawing.Point(104, 160);
            this.dtpResult1.Name = "dtpResult1";
            this.dtpResult1.Size = new System.Drawing.Size(186, 20);
            this.dtpResult1.TabIndex = 3;
            // 
            // dtpResult2
            // 
            this.dtpResult2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpResult2.Location = new System.Drawing.Point(296, 160);
            this.dtpResult2.Name = "dtpResult2";
            this.dtpResult2.Size = new System.Drawing.Size(80, 20);
            this.dtpResult2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 219);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpResult2);
            this.Controls.Add(this.dtpResult1);
            this.Controls.Add(this.dtpInitial2);
            this.Controls.Add(this.dtpInitial1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtpInitial1;
        private System.Windows.Forms.DateTimePicker dtpInitial2;
        private System.Windows.Forms.DateTimePicker dtpResult1;
        private System.Windows.Forms.DateTimePicker dtpResult2;
        private System.Windows.Forms.Button button1;
    }
}


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
            this.dtpInitial1 = new System.Windows.Forms.DateTimePicker();
            this.dtpInitial2 = new System.Windows.Forms.DateTimePicker();
            this.dtpResult1 = new System.Windows.Forms.DateTimePicker();
            this.dtpResult2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 219);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpResult2);
            this.Controls.Add(this.dtpResult1);
            this.Controls.Add(this.dtpInitial2);
            this.Controls.Add(this.dtpInitial1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpInitial1;
        private System.Windows.Forms.DateTimePicker dtpInitial2;
        private System.Windows.Forms.DateTimePicker dtpResult1;
        private System.Windows.Forms.DateTimePicker dtpResult2;
        private System.Windows.Forms.Label label1;
    }
}


namespace CallculatorWindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TeksA = new System.Windows.Forms.TextBox();
            this.TeksB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.COB1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Hasil = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nilai A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nilai B";
            // 
            // TeksA
            // 
            this.TeksA.Location = new System.Drawing.Point(116, 102);
            this.TeksA.Name = "TeksA";
            this.TeksA.Size = new System.Drawing.Size(128, 22);
            this.TeksA.TabIndex = 2;
            // 
            // TeksB
            // 
            this.TeksB.Location = new System.Drawing.Point(116, 157);
            this.TeksB.Name = "TeksB";
            this.TeksB.Size = new System.Drawing.Size(128, 22);
            this.TeksB.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Hitung";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // COB1
            // 
            this.COB1.FormattingEnabled = true;
            this.COB1.Items.AddRange(new object[] {
            "Penambahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.COB1.Location = new System.Drawing.Point(116, 47);
            this.COB1.Name = "COB1";
            this.COB1.Size = new System.Drawing.Size(128, 24);
            this.COB1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Operasi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hasil";
            // 
            // Hasil
            // 
            this.Hasil.BackColor = System.Drawing.SystemColors.Menu;
            this.Hasil.FormattingEnabled = true;
            this.Hasil.ItemHeight = 16;
            this.Hasil.Location = new System.Drawing.Point(116, 207);
            this.Hasil.Name = "Hasil";
            this.Hasil.Size = new System.Drawing.Size(128, 20);
            this.Hasil.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 351);
            this.Controls.Add(this.Hasil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.COB1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TeksB);
            this.Controls.Add(this.TeksA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Aplikasi Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TeksA;
        private System.Windows.Forms.TextBox TeksB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox COB1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Hasil;
    }
}


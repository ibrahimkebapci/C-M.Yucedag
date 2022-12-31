namespace OgrenciOrtalama
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
            this.ProjeTxt = new System.Windows.Forms.TextBox();
            this.Sinav1Txt = new System.Windows.Forms.TextBox();
            this.Sinav2Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProjeTxt
            // 
            this.ProjeTxt.Location = new System.Drawing.Point(212, 129);
            this.ProjeTxt.Name = "ProjeTxt";
            this.ProjeTxt.Size = new System.Drawing.Size(100, 30);
            this.ProjeTxt.TabIndex = 0;
            this.ProjeTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Sinav1Txt
            // 
            this.Sinav1Txt.Location = new System.Drawing.Point(212, 54);
            this.Sinav1Txt.Name = "Sinav1Txt";
            this.Sinav1Txt.Size = new System.Drawing.Size(100, 30);
            this.Sinav1Txt.TabIndex = 1;
            this.Sinav1Txt.Text = "600";
            this.Sinav1Txt.TextChanged += new System.EventHandler(this.Sinav1_TextChanged);
            // 
            // Sinav2Txt
            // 
            this.Sinav2Txt.Location = new System.Drawing.Point(212, 93);
            this.Sinav2Txt.Name = "Sinav2Txt";
            this.Sinav2Txt.Size = new System.Drawing.Size(100, 30);
            this.Sinav2Txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sinav1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sinav2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Proje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ortalama";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sonuc
            // 
            this.Sonuc.AutoSize = true;
            this.Sonuc.Location = new System.Drawing.Point(218, 238);
            this.Sonuc.Name = "Sonuc";
            this.Sonuc.Size = new System.Drawing.Size(70, 25);
            this.Sonuc.TabIndex = 9;
            this.Sonuc.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 432);
            this.Controls.Add(this.Sonuc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sinav2Txt);
            this.Controls.Add(this.Sinav1Txt);
            this.Controls.Add(this.ProjeTxt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "OgrenciOrtalama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProjeTxt;
        private System.Windows.Forms.TextBox Sinav1Txt;
        private System.Windows.Forms.TextBox Sinav2Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Sonuc;
    }
}


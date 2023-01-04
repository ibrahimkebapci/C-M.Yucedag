namespace Ders3_FinalProjesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ButonA = new System.Windows.Forms.Button();
            this.ButonB = new System.Windows.Forms.Button();
            this.ButonC = new System.Windows.Forms.Button();
            this.ButonD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblYanlis = new System.Windows.Forms.Label();
            this.LblDogru = new System.Windows.Forms.Label();
            this.LblSoruNo = new System.Windows.Forms.Label();
            this.ButonSonuc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 19);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(530, 279);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // ButonA
            // 
            this.ButonA.Location = new System.Drawing.Point(124, 316);
            this.ButonA.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ButonA.Name = "ButonA";
            this.ButonA.Size = new System.Drawing.Size(181, 68);
            this.ButonA.TabIndex = 1;
            this.ButonA.Text = "A";
            this.ButonA.UseVisualStyleBackColor = true;
            this.ButonA.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButonB
            // 
            this.ButonB.Location = new System.Drawing.Point(322, 316);
            this.ButonB.Margin = new System.Windows.Forms.Padding(5);
            this.ButonB.Name = "ButonB";
            this.ButonB.Size = new System.Drawing.Size(181, 68);
            this.ButonB.TabIndex = 2;
            this.ButonB.Text = "B";
            this.ButonB.UseVisualStyleBackColor = true;
            // 
            // ButonC
            // 
            this.ButonC.Location = new System.Drawing.Point(124, 394);
            this.ButonC.Margin = new System.Windows.Forms.Padding(5);
            this.ButonC.Name = "ButonC";
            this.ButonC.Size = new System.Drawing.Size(181, 68);
            this.ButonC.TabIndex = 3;
            this.ButonC.Text = "C";
            this.ButonC.UseVisualStyleBackColor = true;
            // 
            // ButonD
            // 
            this.ButonD.Location = new System.Drawing.Point(322, 394);
            this.ButonD.Margin = new System.Windows.Forms.Padding(5);
            this.ButonD.Name = "ButonD";
            this.ButonD.Size = new System.Drawing.Size(181, 68);
            this.ButonD.TabIndex = 4;
            this.ButonD.Text = "D";
            this.ButonD.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(659, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Soru No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(673, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dogru: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(673, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yanlis: ";
            // 
            // LblYanlis
            // 
            this.LblYanlis.AutoSize = true;
            this.LblYanlis.Location = new System.Drawing.Point(763, 140);
            this.LblYanlis.Name = "LblYanlis";
            this.LblYanlis.Size = new System.Drawing.Size(70, 25);
            this.LblYanlis.TabIndex = 10;
            this.LblYanlis.Text = "label4";
            // 
            // LblDogru
            // 
            this.LblDogru.AutoSize = true;
            this.LblDogru.Location = new System.Drawing.Point(763, 96);
            this.LblDogru.Name = "LblDogru";
            this.LblDogru.Size = new System.Drawing.Size(70, 25);
            this.LblDogru.TabIndex = 9;
            this.LblDogru.Text = "label5";
            // 
            // LblSoruNo
            // 
            this.LblSoruNo.AutoSize = true;
            this.LblSoruNo.Location = new System.Drawing.Point(763, 51);
            this.LblSoruNo.Name = "LblSoruNo";
            this.LblSoruNo.Size = new System.Drawing.Size(70, 25);
            this.LblSoruNo.TabIndex = 8;
            this.LblSoruNo.Text = "label6";
            // 
            // ButonSonuc
            // 
            this.ButonSonuc.Location = new System.Drawing.Point(692, 201);
            this.ButonSonuc.Name = "ButonSonuc";
            this.ButonSonuc.Size = new System.Drawing.Size(135, 61);
            this.ButonSonuc.TabIndex = 11;
            this.ButonSonuc.Text = "button5";
            this.ButonSonuc.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(593, 331);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(762, 331);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 495);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButonSonuc);
            this.Controls.Add(this.LblYanlis);
            this.Controls.Add(this.LblDogru);
            this.Controls.Add(this.LblSoruNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButonD);
            this.Controls.Add(this.ButonC);
            this.Controls.Add(this.ButonB);
            this.Controls.Add(this.ButonA);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button ButonA;
        private System.Windows.Forms.Button ButonB;
        private System.Windows.Forms.Button ButonC;
        private System.Windows.Forms.Button ButonD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblYanlis;
        private System.Windows.Forms.Label LblDogru;
        private System.Windows.Forms.Label LblSoruNo;
        private System.Windows.Forms.Button ButonSonuc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


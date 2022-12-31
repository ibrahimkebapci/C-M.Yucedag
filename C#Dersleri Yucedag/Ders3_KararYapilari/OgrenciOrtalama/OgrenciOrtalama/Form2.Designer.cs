namespace OgrenciOrtalama
{
    partial class Form2
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
            this.TxtKitapAdet = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LableSonuc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFiyat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "KitapAdedi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtKitapAdet
            // 
            this.TxtKitapAdet.Location = new System.Drawing.Point(224, 107);
            this.TxtKitapAdet.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtKitapAdet.Name = "TxtKitapAdet";
            this.TxtKitapAdet.Size = new System.Drawing.Size(160, 30);
            this.TxtKitapAdet.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hesap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LableSonuc
            // 
            this.LableSonuc.AutoSize = true;
            this.LableSonuc.Location = new System.Drawing.Point(259, 267);
            this.LableSonuc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LableSonuc.Name = "LableSonuc";
            this.LableSonuc.Size = new System.Drawing.Size(74, 25);
            this.LableSonuc.TabIndex = 3;
            this.LableSonuc.Text = "Sonuc";
            this.LableSonuc.Click += new System.EventHandler(this.LableSonuc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fiyat:";
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Location = new System.Drawing.Point(224, 160);
            this.TxtFiyat.Margin = new System.Windows.Forms.Padding(5);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Size = new System.Drawing.Size(160, 30);
            this.TxtFiyat.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(548, 434);
            this.Controls.Add(this.TxtFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LableSonuc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtKitapAdet);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form2";
            this.Text = "ToptanKitapIndirimi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKitapAdet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LableSonuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFiyat;
    }
}
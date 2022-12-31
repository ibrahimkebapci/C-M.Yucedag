namespace OgrenciOrtalama
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.TxtSayi1 = new System.Windows.Forms.TextBox();
            this.TxtSayi2 = new System.Windows.Forms.TextBox();
            this.TxtIsaret = new System.Windows.Forms.TextBox();
            this.LableSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TxtSayi1
            // 
            this.TxtSayi1.Location = new System.Drawing.Point(155, 137);
            this.TxtSayi1.Name = "TxtSayi1";
            this.TxtSayi1.Size = new System.Drawing.Size(100, 30);
            this.TxtSayi1.TabIndex = 1;
            // 
            // TxtSayi2
            // 
            this.TxtSayi2.Location = new System.Drawing.Point(367, 137);
            this.TxtSayi2.Name = "TxtSayi2";
            this.TxtSayi2.Size = new System.Drawing.Size(100, 30);
            this.TxtSayi2.TabIndex = 2;
            // 
            // TxtIsaret
            // 
            this.TxtIsaret.Location = new System.Drawing.Point(261, 137);
            this.TxtIsaret.Name = "TxtIsaret";
            this.TxtIsaret.Size = new System.Drawing.Size(100, 30);
            this.TxtIsaret.TabIndex = 3;
            this.TxtIsaret.TextChanged += new System.EventHandler(this.Isaret_TextChanged);
            // 
            // LableSonuc
            // 
            this.LableSonuc.AutoSize = true;
            this.LableSonuc.Location = new System.Drawing.Point(521, 140);
            this.LableSonuc.Name = "LableSonuc";
            this.LableSonuc.Size = new System.Drawing.Size(70, 25);
            this.LableSonuc.TabIndex = 4;
            this.LableSonuc.Text = "label1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(690, 447);
            this.Controls.Add(this.LableSonuc);
            this.Controls.Add(this.TxtIsaret);
            this.Controls.Add(this.TxtSayi2);
            this.Controls.Add(this.TxtSayi1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtSayi1;
        private System.Windows.Forms.TextBox TxtSayi2;
        private System.Windows.Forms.TextBox TxtIsaret;
        private System.Windows.Forms.Label LableSonuc;
    }
}
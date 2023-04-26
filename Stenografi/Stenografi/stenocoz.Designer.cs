namespace Stenografi
{
    partial class stenocoz
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
            this.mesaj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.coz = new System.Windows.Forms.Button();
            this.resimyol = new System.Windows.Forms.TextBox();
            this.resimkutusu = new System.Windows.Forms.PictureBox();
            this.ekle = new System.Windows.Forms.Button();
            this.sifrecombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.kriptoloji = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.resimkutusu)).BeginInit();
            this.SuspendLayout();
            // 
            // mesaj
            // 
            this.mesaj.Enabled = false;
            this.mesaj.Location = new System.Drawing.Point(23, 129);
            this.mesaj.Multiline = true;
            this.mesaj.Name = "mesaj";
            this.mesaj.Size = new System.Drawing.Size(283, 345);
            this.mesaj.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Çözülen Mesaj";
            // 
            // coz
            // 
            this.coz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(178)))));
            this.coz.Enabled = false;
            this.coz.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.coz.ForeColor = System.Drawing.Color.White;
            this.coz.Location = new System.Drawing.Point(23, 601);
            this.coz.Name = "coz";
            this.coz.Size = new System.Drawing.Size(188, 40);
            this.coz.TabIndex = 10;
            this.coz.Text = "Çöz";
            this.coz.UseVisualStyleBackColor = false;
            this.coz.Click += new System.EventHandler(this.coz_Click);
            // 
            // resimyol
            // 
            this.resimyol.Enabled = false;
            this.resimyol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resimyol.Location = new System.Drawing.Point(245, 32);
            this.resimyol.Multiline = true;
            this.resimyol.Name = "resimyol";
            this.resimyol.Size = new System.Drawing.Size(925, 36);
            this.resimyol.TabIndex = 9;
            // 
            // resimkutusu
            // 
            this.resimkutusu.Location = new System.Drawing.Point(330, 101);
            this.resimkutusu.Name = "resimkutusu";
            this.resimkutusu.Size = new System.Drawing.Size(829, 540);
            this.resimkutusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resimkutusu.TabIndex = 8;
            this.resimkutusu.TabStop = false;
            // 
            // ekle
            // 
            this.ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(178)))));
            this.ekle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle.ForeColor = System.Drawing.Color.White;
            this.ekle.Location = new System.Drawing.Point(23, 32);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(188, 40);
            this.ekle.TabIndex = 7;
            this.ekle.Text = "Resim Ekle";
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // sifrecombo
            // 
            this.sifrecombo.Enabled = false;
            this.sifrecombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifrecombo.FormattingEnabled = true;
            this.sifrecombo.Items.AddRange(new object[] {
            "Sezar",
            "Vigenere",
            "3DES",
            "AES",
            "RSA"});
            this.sifrecombo.Location = new System.Drawing.Point(143, 489);
            this.sifrecombo.Name = "sifrecombo";
            this.sifrecombo.Size = new System.Drawing.Size(163, 33);
            this.sifrecombo.TabIndex = 14;
            this.sifrecombo.SelectedIndexChanged += new System.EventHandler(this.sifrecombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kriptografi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Şifre";
            this.label3.Visible = false;
            // 
            // sifretxt
            // 
            this.sifretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifretxt.Location = new System.Drawing.Point(23, 554);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(278, 30);
            this.sifretxt.TabIndex = 15;
            this.sifretxt.Visible = false;
            // 
            // kriptoloji
            // 
            this.kriptoloji.AutoSize = true;
            this.kriptoloji.Location = new System.Drawing.Point(23, 497);
            this.kriptoloji.Name = "kriptoloji";
            this.kriptoloji.Size = new System.Drawing.Size(18, 17);
            this.kriptoloji.TabIndex = 17;
            this.kriptoloji.UseVisualStyleBackColor = true;
            this.kriptoloji.CheckedChanged += new System.EventHandler(this.kriptoloji_CheckedChanged);
            // 
            // stenocoz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1188, 664);
            this.Controls.Add(this.kriptoloji);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.sifrecombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mesaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coz);
            this.Controls.Add(this.resimyol);
            this.Controls.Add(this.resimkutusu);
            this.Controls.Add(this.ekle);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "stenocoz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stenografi Çözme";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.stenocoz_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.resimkutusu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mesaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button coz;
        private System.Windows.Forms.TextBox resimyol;
        private System.Windows.Forms.PictureBox resimkutusu;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.ComboBox sifrecombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sifretxt;
        private System.Windows.Forms.CheckBox kriptoloji;
    }
}
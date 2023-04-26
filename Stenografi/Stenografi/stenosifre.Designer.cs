namespace Stenografi
{
    partial class stenosifre
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
            this.ekle = new System.Windows.Forms.Button();
            this.resimkutusu = new System.Windows.Forms.PictureBox();
            this.resimyol = new System.Windows.Forms.TextBox();
            this.sifrele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mesaj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sifrecombo = new System.Windows.Forms.ComboBox();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kriptoloji = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.resimkutusu)).BeginInit();
            this.SuspendLayout();
            // 
            // ekle
            // 
            this.ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(178)))));
            this.ekle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle.ForeColor = System.Drawing.Color.White;
            this.ekle.Location = new System.Drawing.Point(12, 40);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(188, 40);
            this.ekle.TabIndex = 1;
            this.ekle.Text = "Resim Ekle";
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // resimkutusu
            // 
            this.resimkutusu.Location = new System.Drawing.Point(330, 101);
            this.resimkutusu.Name = "resimkutusu";
            this.resimkutusu.Size = new System.Drawing.Size(829, 540);
            this.resimkutusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resimkutusu.TabIndex = 2;
            this.resimkutusu.TabStop = false;
            // 
            // resimyol
            // 
            this.resimyol.Enabled = false;
            this.resimyol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resimyol.Location = new System.Drawing.Point(234, 40);
            this.resimyol.Multiline = true;
            this.resimyol.Name = "resimyol";
            this.resimyol.Size = new System.Drawing.Size(925, 36);
            this.resimyol.TabIndex = 3;
            // 
            // sifrele
            // 
            this.sifrele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(178)))));
            this.sifrele.Enabled = false;
            this.sifrele.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifrele.ForeColor = System.Drawing.Color.White;
            this.sifrele.Location = new System.Drawing.Point(12, 601);
            this.sifrele.Name = "sifrele";
            this.sifrele.Size = new System.Drawing.Size(188, 40);
            this.sifrele.TabIndex = 4;
            this.sifrele.Text = "Şifrele";
            this.sifrele.UseVisualStyleBackColor = false;
            this.sifrele.Click += new System.EventHandler(this.sifrele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Şifrelenecek Mesaj";
            // 
            // mesaj
            // 
            this.mesaj.Enabled = false;
            this.mesaj.Location = new System.Drawing.Point(12, 129);
            this.mesaj.Multiline = true;
            this.mesaj.Name = "mesaj";
            this.mesaj.Size = new System.Drawing.Size(283, 345);
            this.mesaj.TabIndex = 6;
            this.mesaj.Text = "Turkey\'s confirmed cases of the coronavirus increased by 908 in the past 24 hours" +
    ", and 4 more people have died, the Health Ministry announced on May 30.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kriptografi";
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
            this.sifrecombo.Location = new System.Drawing.Point(137, 496);
            this.sifrecombo.Name = "sifrecombo";
            this.sifrecombo.Size = new System.Drawing.Size(158, 33);
            this.sifrecombo.TabIndex = 8;
            this.sifrecombo.SelectedIndexChanged += new System.EventHandler(this.sifrecombo_SelectedIndexChanged);
            // 
            // sifretxt
            // 
            this.sifretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifretxt.Location = new System.Drawing.Point(17, 560);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(278, 30);
            this.sifretxt.TabIndex = 9;
            this.sifretxt.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sifre";
            this.label3.Visible = false;
            // 
            // kriptoloji
            // 
            this.kriptoloji.AutoSize = true;
            this.kriptoloji.Location = new System.Drawing.Point(12, 504);
            this.kriptoloji.Name = "kriptoloji";
            this.kriptoloji.Size = new System.Drawing.Size(18, 17);
            this.kriptoloji.TabIndex = 18;
            this.kriptoloji.UseVisualStyleBackColor = true;
            this.kriptoloji.CheckedChanged += new System.EventHandler(this.kriptoloji_CheckedChanged);
            // 
            // stenosifre
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
            this.Controls.Add(this.sifrele);
            this.Controls.Add(this.resimyol);
            this.Controls.Add(this.resimkutusu);
            this.Controls.Add(this.ekle);
            this.Name = "stenosifre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stenografi Şifreleme";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.stenosifre_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.resimkutusu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.PictureBox resimkutusu;
        private System.Windows.Forms.TextBox resimyol;
        private System.Windows.Forms.Button sifrele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mesaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sifrecombo;
        private System.Windows.Forms.TextBox sifretxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox kriptoloji;
    }
}
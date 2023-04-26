namespace Stenografi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sifrele = new System.Windows.Forms.Button();
            this.coz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sifrele
            // 
            this.sifrele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(178)))));
            this.sifrele.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifrele.ForeColor = System.Drawing.Color.White;
            this.sifrele.Location = new System.Drawing.Point(74, 60);
            this.sifrele.Name = "sifrele";
            this.sifrele.Size = new System.Drawing.Size(210, 118);
            this.sifrele.TabIndex = 0;
            this.sifrele.Text = "Stenografi Şifrele";
            this.sifrele.UseVisualStyleBackColor = false;
            this.sifrele.Click += new System.EventHandler(this.sifrele_Click);
            // 
            // coz
            // 
            this.coz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(178)))));
            this.coz.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.coz.ForeColor = System.Drawing.Color.White;
            this.coz.Location = new System.Drawing.Point(74, 213);
            this.coz.Name = "coz";
            this.coz.Size = new System.Drawing.Size(210, 118);
            this.coz.TabIndex = 1;
            this.coz.Text = "Stenografi    Şifre Çöz";
            this.coz.UseVisualStyleBackColor = false;
            this.coz.Click += new System.EventHandler(this.coz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(363, 435);
            this.Controls.Add(this.coz);
            this.Controls.Add(this.sifrele);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sifrele;
        private System.Windows.Forms.Button coz;
    }
}


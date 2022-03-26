namespace OgrenciBilgiSistemi
{
    partial class FrmGiris
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
            this.LblHosgeldiniz = new System.Windows.Forms.Label();
            this.LblSifre = new System.Windows.Forms.Label();
            this.LblKullanici = new System.Windows.Forms.Label();
            this.TxtKullanici = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.LblCikis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblHosgeldiniz
            // 
            this.LblHosgeldiniz.AutoSize = true;
            this.LblHosgeldiniz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.LblHosgeldiniz.Location = new System.Drawing.Point(164, 9);
            this.LblHosgeldiniz.Name = "LblHosgeldiniz";
            this.LblHosgeldiniz.Size = new System.Drawing.Size(168, 34);
            this.LblHosgeldiniz.TabIndex = 0;
            this.LblHosgeldiniz.Text = "Hoşgeldiniz";
            // 
            // LblSifre
            // 
            this.LblSifre.AutoSize = true;
            this.LblSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.LblSifre.Location = new System.Drawing.Point(142, 121);
            this.LblSifre.Name = "LblSifre";
            this.LblSifre.Size = new System.Drawing.Size(71, 34);
            this.LblSifre.TabIndex = 1;
            this.LblSifre.Text = "Şifre";
            // 
            // LblKullanici
            // 
            this.LblKullanici.AutoSize = true;
            this.LblKullanici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.LblKullanici.Location = new System.Drawing.Point(32, 67);
            this.LblKullanici.Name = "LblKullanici";
            this.LblKullanici.Size = new System.Drawing.Size(181, 34);
            this.LblKullanici.TabIndex = 2;
            this.LblKullanici.Text = "Kullanıcı Adı";
            // 
            // TxtKullanici
            // 
            this.TxtKullanici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.TxtKullanici.Location = new System.Drawing.Point(219, 64);
            this.TxtKullanici.Name = "TxtKullanici";
            this.TxtKullanici.Size = new System.Drawing.Size(245, 42);
            this.TxtKullanici.TabIndex = 3;
            // 
            // TxtSifre
            // 
            this.TxtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.TxtSifre.Location = new System.Drawing.Point(219, 118);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.PasswordChar = '*';
            this.TxtSifre.Size = new System.Drawing.Size(245, 42);
            this.TxtSifre.TabIndex = 4;
            // 
            // BtnGiris
            // 
            this.BtnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.BtnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGiris.ForeColor = System.Drawing.Color.White;
            this.BtnGiris.Location = new System.Drawing.Point(32, 178);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(432, 48);
            this.BtnGiris.TabIndex = 5;
            this.BtnGiris.Text = "Giriş Yapınız";
            this.BtnGiris.UseVisualStyleBackColor = false;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // LblCikis
            // 
            this.LblCikis.AutoSize = true;
            this.LblCikis.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.LblCikis.Location = new System.Drawing.Point(451, 9);
            this.LblCikis.Name = "LblCikis";
            this.LblCikis.Size = new System.Drawing.Size(34, 34);
            this.LblCikis.TabIndex = 6;
            this.LblCikis.Text = "X";
            this.LblCikis.Click += new System.EventHandler(this.LblCikis_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(497, 255);
            this.Controls.Add(this.LblCikis);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtKullanici);
            this.Controls.Add(this.LblKullanici);
            this.Controls.Add(this.LblSifre);
            this.Controls.Add(this.LblHosgeldiniz);
            this.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblHosgeldiniz;
        private Label LblSifre;
        private Label LblKullanici;
        private TextBox TxtKullanici;
        private TextBox TxtSifre;
        private Button BtnGiris;
        private Label LblCikis;
    }
}
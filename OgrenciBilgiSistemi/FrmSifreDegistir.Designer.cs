namespace OgrenciBilgiSistemi
{
    partial class FrmSifreDegistir
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
            this.LblSifreDegistir = new System.Windows.Forms.Label();
            this.TxtEskiSifre = new System.Windows.Forms.TextBox();
            this.LblEskiSifre = new System.Windows.Forms.Label();
            this.LblYeniSifre = new System.Windows.Forms.Label();
            this.LblYeniSifreTekrar = new System.Windows.Forms.Label();
            this.BtnOnayla = new System.Windows.Forms.Button();
            this.PnlEskiSifre = new System.Windows.Forms.Panel();
            this.PnlYeniSifre = new System.Windows.Forms.Panel();
            this.TxtYeniSifre = new System.Windows.Forms.TextBox();
            this.PnlYeniSifreTekrar = new System.Windows.Forms.Panel();
            this.TxtYeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.BtnIptalEt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblSifreDegistir
            // 
            this.LblSifreDegistir.AutoSize = true;
            this.LblSifreDegistir.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LblSifreDegistir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.LblSifreDegistir.Location = new System.Drawing.Point(138, 9);
            this.LblSifreDegistir.Name = "LblSifreDegistir";
            this.LblSifreDegistir.Size = new System.Drawing.Size(192, 37);
            this.LblSifreDegistir.TabIndex = 0;
            this.LblSifreDegistir.Text = "Şifre Değiştir";
            // 
            // TxtEskiSifre
            // 
            this.TxtEskiSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEskiSifre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtEskiSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.TxtEskiSifre.Location = new System.Drawing.Point(205, 75);
            this.TxtEskiSifre.Name = "TxtEskiSifre";
            this.TxtEskiSifre.PasswordChar = '*';
            this.TxtEskiSifre.Size = new System.Drawing.Size(250, 29);
            this.TxtEskiSifre.TabIndex = 1;
            // 
            // LblEskiSifre
            // 
            this.LblEskiSifre.AutoSize = true;
            this.LblEskiSifre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblEskiSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.LblEskiSifre.Location = new System.Drawing.Point(96, 75);
            this.LblEskiSifre.Name = "LblEskiSifre";
            this.LblEskiSifre.Size = new System.Drawing.Size(103, 27);
            this.LblEskiSifre.TabIndex = 3;
            this.LblEskiSifre.Text = "Eski Şifre";
            // 
            // LblYeniSifre
            // 
            this.LblYeniSifre.AutoSize = true;
            this.LblYeniSifre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblYeniSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.LblYeniSifre.Location = new System.Drawing.Point(86, 124);
            this.LblYeniSifre.Name = "LblYeniSifre";
            this.LblYeniSifre.Size = new System.Drawing.Size(113, 27);
            this.LblYeniSifre.TabIndex = 4;
            this.LblYeniSifre.Text = "Yeni Şifre";
            // 
            // LblYeniSifreTekrar
            // 
            this.LblYeniSifreTekrar.AutoSize = true;
            this.LblYeniSifreTekrar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblYeniSifreTekrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.LblYeniSifreTekrar.Location = new System.Drawing.Point(12, 173);
            this.LblYeniSifreTekrar.Name = "LblYeniSifreTekrar";
            this.LblYeniSifreTekrar.Size = new System.Drawing.Size(187, 27);
            this.LblYeniSifreTekrar.TabIndex = 5;
            this.LblYeniSifreTekrar.Text = "Yeni Şifre Tekrar";
            // 
            // BtnOnayla
            // 
            this.BtnOnayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.BtnOnayla.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOnayla.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnOnayla.ForeColor = System.Drawing.Color.White;
            this.BtnOnayla.Location = new System.Drawing.Point(236, 224);
            this.BtnOnayla.Name = "BtnOnayla";
            this.BtnOnayla.Size = new System.Drawing.Size(210, 51);
            this.BtnOnayla.TabIndex = 6;
            this.BtnOnayla.Text = "Onayla";
            this.BtnOnayla.UseVisualStyleBackColor = false;
            // 
            // PnlEskiSifre
            // 
            this.PnlEskiSifre.BackColor = System.Drawing.Color.Black;
            this.PnlEskiSifre.Location = new System.Drawing.Point(205, 110);
            this.PnlEskiSifre.Name = "PnlEskiSifre";
            this.PnlEskiSifre.Size = new System.Drawing.Size(250, 1);
            this.PnlEskiSifre.TabIndex = 7;
            // 
            // PnlYeniSifre
            // 
            this.PnlYeniSifre.BackColor = System.Drawing.Color.Black;
            this.PnlYeniSifre.Location = new System.Drawing.Point(205, 159);
            this.PnlYeniSifre.Name = "PnlYeniSifre";
            this.PnlYeniSifre.Size = new System.Drawing.Size(250, 1);
            this.PnlYeniSifre.TabIndex = 9;
            // 
            // TxtYeniSifre
            // 
            this.TxtYeniSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtYeniSifre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtYeniSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.TxtYeniSifre.Location = new System.Drawing.Point(205, 124);
            this.TxtYeniSifre.Name = "TxtYeniSifre";
            this.TxtYeniSifre.PasswordChar = '*';
            this.TxtYeniSifre.Size = new System.Drawing.Size(250, 29);
            this.TxtYeniSifre.TabIndex = 8;
            // 
            // PnlYeniSifreTekrar
            // 
            this.PnlYeniSifreTekrar.BackColor = System.Drawing.Color.Black;
            this.PnlYeniSifreTekrar.Location = new System.Drawing.Point(205, 208);
            this.PnlYeniSifreTekrar.Name = "PnlYeniSifreTekrar";
            this.PnlYeniSifreTekrar.Size = new System.Drawing.Size(250, 1);
            this.PnlYeniSifreTekrar.TabIndex = 9;
            // 
            // TxtYeniSifreTekrar
            // 
            this.TxtYeniSifreTekrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtYeniSifreTekrar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtYeniSifreTekrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.TxtYeniSifreTekrar.Location = new System.Drawing.Point(205, 173);
            this.TxtYeniSifreTekrar.Name = "TxtYeniSifreTekrar";
            this.TxtYeniSifreTekrar.PasswordChar = '*';
            this.TxtYeniSifreTekrar.Size = new System.Drawing.Size(250, 29);
            this.TxtYeniSifreTekrar.TabIndex = 8;
            // 
            // BtnIptalEt
            // 
            this.BtnIptalEt.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnIptalEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIptalEt.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnIptalEt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.BtnIptalEt.Location = new System.Drawing.Point(20, 224);
            this.BtnIptalEt.Name = "BtnIptalEt";
            this.BtnIptalEt.Size = new System.Drawing.Size(210, 51);
            this.BtnIptalEt.TabIndex = 10;
            this.BtnIptalEt.Text = "İptal Et";
            this.BtnIptalEt.UseVisualStyleBackColor = true;
            // 
            // FrmSifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 287);
            this.Controls.Add(this.BtnIptalEt);
            this.Controls.Add(this.PnlYeniSifreTekrar);
            this.Controls.Add(this.TxtYeniSifreTekrar);
            this.Controls.Add(this.PnlYeniSifre);
            this.Controls.Add(this.TxtYeniSifre);
            this.Controls.Add(this.PnlEskiSifre);
            this.Controls.Add(this.BtnOnayla);
            this.Controls.Add(this.LblYeniSifreTekrar);
            this.Controls.Add(this.LblYeniSifre);
            this.Controls.Add(this.LblEskiSifre);
            this.Controls.Add(this.TxtEskiSifre);
            this.Controls.Add(this.LblSifreDegistir);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmSifreDegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSifreDegistir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblSifreDegistir;
        private TextBox TxtEskiSifre;
        private Label LblEskiSifre;
        private Label LblYeniSifre;
        private Label LblYeniSifreTekrar;
        private Button BtnOnayla;
        private Panel PnlEskiSifre;
        private Panel PnlYeniSifre;
        private TextBox TxtYeniSifre;
        private Panel PnlYeniSifreTekrar;
        private TextBox TxtYeniSifreTekrar;
        private Button BtnIptalEt;
    }
}
namespace OgrenciBilgiSistemi
{
    partial class FrmYoneticiEkrani
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlSag = new System.Windows.Forms.Panel();
            this.DgvOgrenciListesi = new System.Windows.Forms.DataGridView();
            this.PnlSol = new System.Windows.Forms.Panel();
            this.BtnKayitSil = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.BtnSifreDegistir = new System.Windows.Forms.Button();
            this.BtnKayitListesi = new System.Windows.Forms.Button();
            this.BtnAnaMenu = new System.Windows.Forms.Button();
            this.PbYonetici = new System.Windows.Forms.PictureBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KullaniciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnKayitEkle = new System.Windows.Forms.Button();
            this.PnlSag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOgrenciListesi)).BeginInit();
            this.PnlSol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbYonetici)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlSag
            // 
            this.PnlSag.Controls.Add(this.DgvOgrenciListesi);
            this.PnlSag.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlSag.Location = new System.Drawing.Point(202, 0);
            this.PnlSag.Name = "PnlSag";
            this.PnlSag.Size = new System.Drawing.Size(462, 534);
            this.PnlSag.TabIndex = 0;
            // 
            // DgvOgrenciListesi
            // 
            this.DgvOgrenciListesi.AllowUserToAddRows = false;
            this.DgvOgrenciListesi.AllowUserToDeleteRows = false;
            this.DgvOgrenciListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvOgrenciListesi.BackgroundColor = System.Drawing.Color.White;
            this.DgvOgrenciListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvOgrenciListesi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvOgrenciListesi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvOgrenciListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvOgrenciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOgrenciListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.KullaniciAdi,
            this.Sifre});
            this.DgvOgrenciListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvOgrenciListesi.GridColor = System.Drawing.Color.Gainsboro;
            this.DgvOgrenciListesi.Location = new System.Drawing.Point(0, 0);
            this.DgvOgrenciListesi.Name = "DgvOgrenciListesi";
            this.DgvOgrenciListesi.ReadOnly = true;
            this.DgvOgrenciListesi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvOgrenciListesi.RowHeadersWidth = 51;
            this.DgvOgrenciListesi.RowTemplate.Height = 29;
            this.DgvOgrenciListesi.Size = new System.Drawing.Size(462, 534);
            this.DgvOgrenciListesi.TabIndex = 0;
            // 
            // PnlSol
            // 
            this.PnlSol.Controls.Add(this.BtnKayitEkle);
            this.PnlSol.Controls.Add(this.BtnKayitSil);
            this.PnlSol.Controls.Add(this.BtnCikis);
            this.PnlSol.Controls.Add(this.BtnSifreDegistir);
            this.PnlSol.Controls.Add(this.BtnKayitListesi);
            this.PnlSol.Controls.Add(this.BtnAnaMenu);
            this.PnlSol.Controls.Add(this.PbYonetici);
            this.PnlSol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSol.Location = new System.Drawing.Point(0, 0);
            this.PnlSol.Name = "PnlSol";
            this.PnlSol.Size = new System.Drawing.Size(202, 534);
            this.PnlSol.TabIndex = 1;
            // 
            // BtnKayitSil
            // 
            this.BtnKayitSil.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnKayitSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKayitSil.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnKayitSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.BtnKayitSil.Location = new System.Drawing.Point(9, 333);
            this.BtnKayitSil.Name = "BtnKayitSil";
            this.BtnKayitSil.Size = new System.Drawing.Size(184, 59);
            this.BtnKayitSil.TabIndex = 3;
            this.BtnKayitSil.Text = "Kayıt Sil";
            this.BtnKayitSil.UseVisualStyleBackColor = true;
            this.BtnKayitSil.Click += new System.EventHandler(this.BtnKayitSil_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCikis.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.BtnCikis.Location = new System.Drawing.Point(9, 463);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(184, 59);
            this.BtnCikis.TabIndex = 5;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // BtnSifreDegistir
            // 
            this.BtnSifreDegistir.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnSifreDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSifreDegistir.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSifreDegistir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.BtnSifreDegistir.Location = new System.Drawing.Point(9, 398);
            this.BtnSifreDegistir.Name = "BtnSifreDegistir";
            this.BtnSifreDegistir.Size = new System.Drawing.Size(184, 59);
            this.BtnSifreDegistir.TabIndex = 4;
            this.BtnSifreDegistir.Text = "Şifre Değiştir";
            this.BtnSifreDegistir.UseVisualStyleBackColor = true;
            this.BtnSifreDegistir.Click += new System.EventHandler(this.BtnSifreDegistir_Click);
            // 
            // BtnKayitListesi
            // 
            this.BtnKayitListesi.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnKayitListesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKayitListesi.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnKayitListesi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.BtnKayitListesi.Location = new System.Drawing.Point(9, 203);
            this.BtnKayitListesi.Name = "BtnKayitListesi";
            this.BtnKayitListesi.Size = new System.Drawing.Size(184, 59);
            this.BtnKayitListesi.TabIndex = 2;
            this.BtnKayitListesi.Text = "Kayıt Listesi";
            this.BtnKayitListesi.UseVisualStyleBackColor = true;
            this.BtnKayitListesi.Click += new System.EventHandler(this.BtnKayitListesi_Click);
            // 
            // BtnAnaMenu
            // 
            this.BtnAnaMenu.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnAnaMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnaMenu.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAnaMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.BtnAnaMenu.Location = new System.Drawing.Point(9, 138);
            this.BtnAnaMenu.Name = "BtnAnaMenu";
            this.BtnAnaMenu.Size = new System.Drawing.Size(184, 59);
            this.BtnAnaMenu.TabIndex = 1;
            this.BtnAnaMenu.Text = "Ana Menü";
            this.BtnAnaMenu.UseVisualStyleBackColor = true;
            this.BtnAnaMenu.Click += new System.EventHandler(this.BtnAnaMenu_Click);
            // 
            // PbYonetici
            // 
            this.PbYonetici.Image = global::OgrenciBilgiSistemi.Properties.Resources.user_admin;
            this.PbYonetici.Location = new System.Drawing.Point(41, 12);
            this.PbYonetici.Name = "PbYonetici";
            this.PbYonetici.Size = new System.Drawing.Size(120, 120);
            this.PbYonetici.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbYonetici.TabIndex = 0;
            this.PbYonetici.TabStop = false;
            // 
            // Id
            // 
            this.Id.FillWeight = 50F;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.HeaderText = "Kullanıcı Adı";
            this.KullaniciAdi.MinimumWidth = 6;
            this.KullaniciAdi.Name = "KullaniciAdi";
            this.KullaniciAdi.ReadOnly = true;
            // 
            // Sifre
            // 
            this.Sifre.HeaderText = "Şifre";
            this.Sifre.MinimumWidth = 6;
            this.Sifre.Name = "Sifre";
            this.Sifre.ReadOnly = true;
            // 
            // BtnKayitEkle
            // 
            this.BtnKayitEkle.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnKayitEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKayitEkle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnKayitEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.BtnKayitEkle.Location = new System.Drawing.Point(9, 268);
            this.BtnKayitEkle.Name = "BtnKayitEkle";
            this.BtnKayitEkle.Size = new System.Drawing.Size(184, 59);
            this.BtnKayitEkle.TabIndex = 6;
            this.BtnKayitEkle.Text = "Kayıt Ekle";
            this.BtnKayitEkle.UseVisualStyleBackColor = true;
            // 
            // FrmYoneticiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 534);
            this.Controls.Add(this.PnlSol);
            this.Controls.Add(this.PnlSag);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmYoneticiEkrani";
            this.Text = "FrmYoneticiEkrani";
            this.PnlSag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOgrenciListesi)).EndInit();
            this.PnlSol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbYonetici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PnlSag;
        private DataGridView DgvOgrenciListesi;
        private Panel PnlSol;
        private Button BtnKayitSil;
        private Button BtnCikis;
        private Button BtnSifreDegistir;
        private Button BtnKayitListesi;
        private Button BtnAnaMenu;
        private PictureBox PbYonetici;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn KullaniciAdi;
        private DataGridViewTextBoxColumn Sifre;
        private Button BtnKayitEkle;
    }
}
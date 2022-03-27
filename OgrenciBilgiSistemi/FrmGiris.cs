using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void LblCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SQLHelper sqlHelper = new SQLHelper();
            DataTable dataTable = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(TxtKullanici.Text))
                {
                    dataTable = sqlHelper.KullaniciKontrol(new Kullanici(TxtKullanici.Text, TxtSifre.Text));
                    if (dataTable.Rows[0]["Sifre"].ToString() == TxtSifre.Text)
                    {
                        if (dataTable.Rows[0]["KullaniciAdi"].ToString() == "admin")
                        {
                            FrmYoneticiEkrani frmYoneticiEkrani = new FrmYoneticiEkrani();
                            frmYoneticiEkrani.ShowDialog();
                        }
                        else
                        {
                            FrmKayitEkrani frmKayitEkrani = new FrmKayitEkrani();
                            frmKayitEkrani.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Yanlış şifre girdiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Kullanıcı Adı Giriniz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
            }
        }

        private void TxtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                BtnGiris_Click(null, null);
            }
        }
    }
}
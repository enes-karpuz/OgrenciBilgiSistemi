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

            try
            {
                if (sqlHelper.KullaniciKontrol(new Kullanici(TxtKullanici.Text, TxtSifre.Text)).Rows[0]["Sifre"].ToString() == TxtSifre.Text)
                {
                    FrmKayitEkrani frmKayitEkrani = new FrmKayitEkrani();
                    frmKayitEkrani.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Yanlış şifre girdiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
            }
        }
    }
}
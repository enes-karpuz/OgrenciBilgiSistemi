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
    public partial class FrmYoneticiEkrani : Form
    {
        SQLHelper sqlHelper = new SQLHelper();
        DataTable dataTable = new DataTable();
        FrmKayitEkrani frmKayitEkrani = new FrmKayitEkrani();
        FrmGiris frmGiris = new FrmGiris();
        public FrmYoneticiEkrani()
        {
            InitializeComponent();
        }
        
        private void BtnAnaMenu_Click(object sender, EventArgs e)
        {
            //!Yönetici ekranı açıldığı zaman giriş ekranını kapatma işlemi gerçekleştirilemedi.
            frmKayitEkrani.Show();
            this.Close();
        }

        private void BtnKayitListesi_Click(object sender, EventArgs e)
        {
            //TODO: Öğrenci Listesini getirecek
            //Diğer formlarla olan bağlantı sağlanamadı.
           
        }

        private void BtnKayitSil_Click(object sender, EventArgs e)
        {
            //TODO: Seçili kaydı silecek
        }

        private void BtnSifreDegistir_Click(object sender, EventArgs e)
        {
            //TODO: Seçili kaydın şifresini değiştirecek
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System.Diagnostics;

namespace OgrenciBilgiSistemi
{
    public partial class FrmKayitEkrani : Form
    {
        public FrmKayitEkrani()
        {
            InitializeComponent();
        }

        private void LblCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            SQLHelper sqlHelper = new SQLHelper();
            sqlHelper.SqlKayit(new Ogrenci(TxtAdi.Text, TxtSoyadi.Text, DtpDogumTarihi.Value, TxtEmail.Text, CbUyelik.Checked));
        }

        private void CbUyelik_CheckedChanged(object sender, EventArgs e)
        {
            if (!CbUyelik.Checked)
            {
                BtnKayitOl.Enabled = false;
            }
            else
            {
                BtnKayitOl.Enabled = true;
            }
        }

        private void PbFacebokk_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.facebook.com/Trabzonspor",
                UseShellExecute = true
            });
        }
    }
}
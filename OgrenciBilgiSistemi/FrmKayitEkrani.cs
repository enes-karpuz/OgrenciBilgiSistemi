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
            sqlHelper.SqlKayit(new Ogrenci(TxtAdi.Text, TxtSoyadi.Text, dtpDogumTarihi.Value, "abc@gmail.com", true));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    public class SQLHelper
    {
        private SqlConnection sqlConnection = new SqlConnection("Data Source=ENES-THINKPAD;Initial Catalog=OgrenciBilgiSistemi;Integrated Security=True");

        public bool SqlKayit(Ogrenci ogrenci)
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlCommand sqlCommand = new SqlCommand($"INSERT INTO Ogrenci (Ad, Soyad, DogumTarihi, Email, IsOK) " +
                $"VALUES ('{ogrenci.Ad}','{ogrenci.Soyad}','{ogrenci.DogumTarihi.ToString("yyyy-MM-dd")}','{ogrenci.Email}','{ogrenci.IsOK}')"
                , sqlConnection);

            try
            {
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public DataTable KullaniciKontrol(Kullanici kullanici)
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            try
            {
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM Kullanici " +
                    $"WHERE KullaniciAdi = '{kullanici.KullaniciAdi}'", sqlConnection);
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
                return dataTable;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}

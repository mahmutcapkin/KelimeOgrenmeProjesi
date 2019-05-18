using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace KelimeOgrenProje
{
   public class VeritabaniBaglanti
    {

        SqlConnection _baglanti = new SqlConnection(@"Data Source=DESKTOP-UP3GCNR;Initial Catalog=Kelimeler;Integrated Security=True");

        public DataTable KelimeGetir()
        {
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }
            SqlCommand command = new SqlCommand("Select * From TumKelimeler ", _baglanti);
            SqlDataReader reader = command.ExecuteReader();
            List<Kelime> kelimeler = new List<Kelime>();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _baglanti.Close();
            return dataTable;
        }
        public void TarihAyarla(Kelime kelime)
        {
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }
            SqlCommand command = new SqlCommand("SELECT Turkce,Ingilizce,Asamalar FROM TumKelimeler  WHERE Turkce=@Turkce", _baglanti);
            command.Parameters.AddWithValue("@Turkce", kelime.turkce);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                kelime.ingilizce = dt.Rows[0].Field<string>("Ingilizce");
                kelime.turkce = dt.Rows[0].Field<string>("Turkce");
                kelime.asamalar = dt.Rows[0].Field<int>("Asamalar").ToString();
                if (kelime.asamalar == "1")
                {
                    kelime.tarih = DateTime.Now.AddDays(1).ToShortDateString();
                }
                else if (kelime.asamalar == "2")
                {
                    kelime.tarih = DateTime.Now.AddDays(6).ToShortDateString();
                }
                else if (kelime.asamalar == "3")
                {
                    kelime.tarih = DateTime.Now.AddDays(23).ToShortDateString();
                }
                else if (kelime.asamalar == "4")
                {
                    kelime.tarih = DateTime.Now.AddDays(150).ToShortDateString();
                }
                else if (kelime.asamalar == "5")
                {
                    kelime.tarih = DateTime.Now.AddDays(0).ToShortDateString();
                }
                else if (kelime.asamalar == "6")
                {
                    kelime.tarih = DateTime.Now.AddDays(0).ToShortDateString();
                }
                else if (kelime.asamalar == "0")
                {
                    kelime.tarih = DateTime.Now.AddDays(1).ToShortDateString();
                }
            }
            SqlCommand cmd = new SqlCommand("UPDATE TumKelimeler SET Tarih=@Tarih WHERE Ingilizce=@ingilizce", _baglanti);
            cmd.Parameters.AddWithValue("@Tarih", kelime.tarih);
            cmd.Parameters.AddWithValue("@ingilizce", kelime.ingilizce);
            cmd.ExecuteNonQuery();

            _baglanti.Close();
        }

        public void AsamaArttir(Kelime kelime)
        {

            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }
            SqlCommand command = new SqlCommand("UPDATE TumKelimeler SET  Asamalar+=1   WHERE Turkce=@Turkce", _baglanti);
            command.Parameters.AddWithValue("@Turkce", kelime.turkce);
            command.ExecuteNonQuery();
            _baglanti.Close();
        }
        public void AsamaAzalt(Kelime kelime)
        {

            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }
            SqlCommand command = new SqlCommand("UPDATE TumKelimeler SET  Asamalar=1   WHERE Turkce=@Turkce", _baglanti);
            command.Parameters.AddWithValue("@Turkce", kelime.turkce);
            command.ExecuteNonQuery();
            _baglanti.Close();
        }
        public void KelimeEkle(Kelime kelime)
        {
            SqlConnection _baglanti = new SqlConnection(@"Data Source=DESKTOP-UP3GCNR;Initial Catalog=Kelimeler;Integrated Security=True");
            if (_baglanti.State == System.Data.ConnectionState.Closed)
            {
                _baglanti.Open();
            }

            SqlCommand command = new SqlCommand("INSERT into TumKelimeler values(@turkce,@ingilizce,@sozcuktur,@trcumle,@ingcumle,@tarih)", _baglanti);
            command.Parameters.AddWithValue("@turkce", kelime.turkce);
            command.Parameters.AddWithValue("@ingilizce", kelime.ingilizce);
            command.Parameters.AddWithValue("@sozcuktur", kelime.sozcuktur);
            command.Parameters.AddWithValue("@trcumle", kelime.trcumle);
            command.Parameters.AddWithValue("@ingcumle", kelime.ingcumle);
            command.Parameters.AddWithValue("@tarih", kelime.tarih);
            command.ExecuteNonQuery();
            _baglanti.Close();
        }

        public void KelimeSil(int Id)
        {
            SqlConnection _baglanti = new SqlConnection(@"Data Source=DESKTOP-UP3GCNR;Initial Catalog=Kelimeler;Integrated Security=True");
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }
            SqlCommand command = new SqlCommand("Delete From TumKelimeler where ID=@Id", _baglanti);
            command.Parameters.AddWithValue("@Id", Id);
            command.ExecuteNonQuery();
            _baglanti.Close();
        }
        public DataTable OgrenilenKelimeler()
        {
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }
            SqlCommand command = new SqlCommand("Select * From TumKelimeler WHERE Asamalar>=5 ", _baglanti);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            _baglanti.Close();
            return dt;
        }
        public DataTable AylikVeri()
        {
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }
            SqlCommand command = new SqlCommand("(Select * From TumKelimeler WHERE Asamalar>=4) ", _baglanti);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            _baglanti.Close();
            return dt;
        }
    }
}

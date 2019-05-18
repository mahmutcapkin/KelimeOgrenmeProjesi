using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KelimeOgrenProje
{
    public partial class FrmKelimeler : Form
    {
        public FrmKelimeler()
        {
            InitializeComponent();
        }
        Kelime kelime;
        VeritabaniBaglanti veriler = new VeritabaniBaglanti();
        List<Kelime> kelimeler = new List<Kelime>();
        SqlConnection _baglanti = new SqlConnection(@"Data Source=DESKTOP-UP3GCNR;Initial Catalog=Kelimeler;Integrated Security=True");
        void VeriGetirme()
        {
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }
            SqlCommand command = new SqlCommand("SELECT TOP 1 ID,Turkce,Ingilizce,SozcukTur,TurkceCumle,IngilizceCumle,Asamalar,Tarih From TumKelimeler  WHERE Asamalar=0  ORDER BY NEWID()", _baglanti);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                kelime = new Kelime
                {
                    id = Convert.ToInt32(reader["ID"]),
                    turkce = reader["Turkce"].ToString(),
                    ingilizce = reader["Ingilizce"].ToString(),
                    sozcuktur = reader["SozcukTur"].ToString(),
                    trcumle = reader["TurkceCumle"].ToString(),
                    ingcumle = reader["IngilizceCumle"].ToString(),
                    tarih = reader["Tarih"].ToString(),
                    asamalar = reader["Asamalar"].ToString(),

                };
                kelimeler.Add(kelime);
                lblTurkce.Text = kelime.turkce;
                lbIngilizce.Text = kelime.ingilizce;
                lblSozcukTur.Text = kelime.sozcuktur;
                lblCumle.Text = kelime.ingcumle;
                lblTurkcesi.Text = kelime.trcumle;
            };

            _baglanti.Close();
        }
        void Guncelle()
        {
            kelime.tarih = DateTime.Now.AddDays(1).ToShortDateString();
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _baglanti;
            cmd.CommandText = "UPDATE TumKelimeler SET Tarih='" + kelime.tarih + "' WHERE Turkce='" + lblTurkce.Text + "'";
            cmd.Parameters.AddWithValue("@Turkce", lblTurkce.Text);
            cmd.Parameters.AddWithValue("@Tarih", kelime.tarih);
            cmd.ExecuteNonQuery();
            _baglanti.Close();
        }

        private void FrmKelimeler_Load(object sender, EventArgs e)
        {
            VeriGetirme();
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            VeriGetirme();
            veriler.AsamaArttir(kelime);
            Guncelle();
        }

    }
}

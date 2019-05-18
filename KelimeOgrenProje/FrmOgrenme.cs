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
    public partial class FrmOgrenme : Form
    {
        public FrmOgrenme()
        {
            InitializeComponent();
        }
        VeritabaniBaglanti veri = new VeritabaniBaglanti();
        List<Kelime> kelimeler = new List<Kelime>();
        Kelime kelime = new Kelime();
        SqlConnection _baglanti = new SqlConnection(@"Data Source=DESKTOP-UP3GCNR;Initial Catalog=Kelimeler;Integrated Security=True");
        void VeriGetirme()
        {
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }
            kelime.tarih = DateTime.Now.ToShortDateString();
            SqlCommand command = new SqlCommand("SELECT TOP 1 ID,Turkce,Ingilizce,SozcukTur,TurkceCumle,IngilizceCumle,Tarih  From TumKelimeler WHERE  Asamalar>=1 and  Asamalar<=5 and Tarih=@tarih ORDER BY NEWID()", _baglanti);
            command.Parameters.AddWithValue("@tarih", kelime.tarih);
            command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                kelime.id = Convert.ToInt32(reader["ID"]);
                kelime.turkce = reader["Turkce"].ToString();
                kelime.ingilizce = reader["Ingilizce"].ToString();
                kelime.sozcuktur = reader["SozcukTur"].ToString();
                kelime.trcumle = reader["TurkceCumle"].ToString();
                kelime.ingcumle = reader["IngilizceCumle"].ToString();
                kelimeler.Add(kelime);
                txtOgrTurkce.Text = kelime.turkce;
                lblSozcukTur.Text = kelime.sozcuktur;
                lblCumle.Text = kelime.ingcumle;
                lblTurkcesi.Text = kelime.trcumle;
            }
            reader.Close();
            _baglanti.Close();
        }
        void Kontrol()
        {
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _baglanti;
            cmd.CommandText = "Select * From TumKelimeler WHERE  Turkce='" + kelime.turkce + "'and Ingilizce='" + kelime.ingilizce + "' ";
            SqlDataReader okuyucu = cmd.ExecuteReader();
            while (okuyucu.Read())
            {
                if (txtOgrIng.Text.ToLower() == kelime.ingilizce)
                {
                    btnDogru.Visible = true;
                    lblSozcukTur.Visible = true;
                    lblCumle.Visible = true;
                    lblTurkcesi.Visible = true;
                    veri.AsamaArttir(kelime);
                    veri.TarihAyarla(kelime);
                    MessageBox.Show("Tebrikler Doğru Cevap");
                }
                else
                {

                    MessageBox.Show("Yanlış");
                    MessageBox.Show("Doğrusu: " + kelime.ingilizce);
                    btnYanlis.Visible = true;
                    veri.AsamaAzalt(kelime);
                    veri.TarihAyarla(kelime);
                }
            }
            okuyucu.Close();
            _baglanti.Close();
        }

        void Temizle()
        {
            txtOgrIng.Text = "";
            txtOgrTurkce.Text = "";
            lblSozcukTur.Text = "";
            lblCumle.Text = "";
            lblTurkcesi.Text = "";
        }
        void Gorunurluk()
        {
            btnYanlis.Visible = false;
            btnDogru.Visible = false;
            lblSozcukTur.Visible = false;
            lblCumle.Visible = false;
            lblTurkcesi.Visible = false;
        }

        private void FrmOgrenme_Load(object sender, EventArgs e)
        {
            Gorunurluk();
            VeriGetirme();
        }

        private void btnCevapla_Click(object sender, EventArgs e)
        {
            Kontrol();
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            Gorunurluk();
            Temizle();
            VeriGetirme();
        }
    }
}

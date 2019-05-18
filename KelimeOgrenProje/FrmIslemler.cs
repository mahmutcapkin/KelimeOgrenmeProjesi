using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeOgrenProje
{
    public partial class FrmIslemler : Form
    {
        public FrmIslemler()
        {
            InitializeComponent();
        }
        VeritabaniBaglanti veri = new VeritabaniBaglanti();

        private void FrmIslemler_Load(object sender, EventArgs e)
        {
            gridIslemler.DataSource = veri.KelimeGetir();
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtId.Text = dr["ID"].ToString();
            txtTurkce.Text = dr["Turkce"].ToString();
            txtIngilizce.Text = dr["Ingilizce"].ToString();
            txtSozcukTur.Text = dr["SozcukTur"].ToString();
            txtCumle.Text = dr["IngilizceCumle"].ToString();
            txtTrCumle.Text = dr["TurkceCumle"].ToString();
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            veri.KelimeEkle(new Kelime
            {
                id = Convert.ToInt32(txtId.Text),
                turkce = txtTurkce.Text,
                ingilizce = txtIngilizce.Text,
                trcumle = txtTrCumle.Text,
                ingcumle = txtCumle.Text,
                sozcuktur = txtSozcukTur.Text,
                asamalar = 0.ToString(),
            });
            MessageBox.Show("Kelime Eklenmiştir");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            veri.KelimeSil(id);
            MessageBox.Show("Kelime Silinmiştir");
        }


    }
}

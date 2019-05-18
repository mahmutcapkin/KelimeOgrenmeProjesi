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
    public partial class FrmOgrenilenler : Form
    {
        public FrmOgrenilenler()
        {
            InitializeComponent();
        }
        VeritabaniBaglanti veriler = new VeritabaniBaglanti();

        private void FrmOgrenilenler_Load(object sender, EventArgs e)
        {
            gridAylik.DataSource = veriler.AylikVeri();
            gridOgrenilenler.DataSource = veriler.OgrenilenKelimeler();
        }

        private void btnİstatistik_Click(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();
            datatable = veriler.OgrenilenKelimeler();
            lblYillik.Text = datatable.Rows.Count.ToString();
            datatable = veriler.AylikVeri();
            lblAylik.Text = datatable.Rows.Count.ToString();
        }


    }
}

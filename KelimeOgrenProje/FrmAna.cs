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
    public partial class FrmAna : Form
    {
        public FrmAna()
        {
            InitializeComponent();
        }
        FrmKelimeler frmkelimeler;
        FrmOgrenme frmogrenme;
        FrmIslemler frmislem;
        FrmOgrenilenler frmogrenilenler;


        private void btnKelimeler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmkelimeler = new FrmKelimeler();
            frmkelimeler.MdiParent = this;
            frmkelimeler.Show();
        }

        private void btnOgrenme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmogrenme = new FrmOgrenme();
            frmogrenme.MdiParent = this;
            frmogrenme.Show();
        }

        private void btnIslemler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmislem = new FrmIslemler();
            frmislem.MdiParent = this;
            frmislem.Show();
        }

        private void btnOgrenilenler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmogrenilenler = new FrmOgrenilenler();
            frmogrenilenler.MdiParent = this;
            frmogrenilenler.Show();
        }
    }
}

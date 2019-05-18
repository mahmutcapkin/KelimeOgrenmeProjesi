namespace KelimeOgrenProje
{
    partial class FrmOgrenilenler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridAylik = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblAylik = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnİstatistik = new DevExpress.XtraEditors.SimpleButton();
            this.lblYillik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridOgrenilenler = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridAylik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOgrenilenler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAylik
            // 
            this.gridAylik.Location = new System.Drawing.Point(496, 12);
            this.gridAylik.MainView = this.gridView2;
            this.gridAylik.Name = "gridAylik";
            this.gridAylik.Size = new System.Drawing.Size(468, 415);
            this.gridAylik.TabIndex = 13;
            this.gridAylik.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridAylik;
            this.gridView2.Name = "gridView2";
            // 
            // lblAylik
            // 
            this.lblAylik.AutoSize = true;
            this.lblAylik.Location = new System.Drawing.Point(1112, 159);
            this.lblAylik.Name = "lblAylik";
            this.lblAylik.Size = new System.Drawing.Size(46, 17);
            this.lblAylik.TabIndex = 12;
            this.lblAylik.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1021, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "AYLIK:";
            // 
            // btnİstatistik
            // 
            this.btnİstatistik.Location = new System.Drawing.Point(1044, 228);
            this.btnİstatistik.Name = "btnİstatistik";
            this.btnİstatistik.Size = new System.Drawing.Size(114, 44);
            this.btnİstatistik.TabIndex = 10;
            this.btnİstatistik.Text = "Sonuç Göster";
            this.btnİstatistik.Click += new System.EventHandler(this.btnİstatistik_Click);
            // 
            // lblYillik
            // 
            this.lblYillik.AutoSize = true;
            this.lblYillik.Location = new System.Drawing.Point(1112, 119);
            this.lblYillik.Name = "lblYillik";
            this.lblYillik.Size = new System.Drawing.Size(46, 17);
            this.lblYillik.TabIndex = 9;
            this.lblYillik.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1021, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "YILLIK:";
            // 
            // gridOgrenilenler
            // 
            this.gridOgrenilenler.Location = new System.Drawing.Point(12, 12);
            this.gridOgrenilenler.MainView = this.gridView1;
            this.gridOgrenilenler.Name = "gridOgrenilenler";
            this.gridOgrenilenler.Size = new System.Drawing.Size(478, 415);
            this.gridOgrenilenler.TabIndex = 7;
            this.gridOgrenilenler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridOgrenilenler;
            this.gridView1.Name = "gridView1";
            // 
            // FrmOgrenilenler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 436);
            this.Controls.Add(this.gridAylik);
            this.Controls.Add(this.lblAylik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnİstatistik);
            this.Controls.Add(this.lblYillik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridOgrenilenler);
            this.Name = "FrmOgrenilenler";
            this.Text = "ÖĞRENİLENLER";
            this.Load += new System.EventHandler(this.FrmOgrenilenler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAylik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOgrenilenler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridAylik;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label lblAylik;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnİstatistik;
        private System.Windows.Forms.Label lblYillik;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridOgrenilenler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
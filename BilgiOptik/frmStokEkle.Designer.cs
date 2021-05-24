
namespace BilgiOptik
{
    partial class frmStokEkle
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
            this.numStokMiktari = new System.Windows.Forms.NumericUpDown();
            this.btnStokEkle = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.numSatisFiyat = new System.Windows.Forms.NumericUpDown();
            this.numAlisFiyat = new System.Windows.Forms.NumericUpDown();
            this.lblEklencekStok = new System.Windows.Forms.Label();
            this.lblAlisFiyat = new System.Windows.Forms.Label();
            this.lblSatisFiyat = new System.Windows.Forms.Label();
            this.lblToplamStok = new System.Windows.Forms.Label();
            this.lblStokMiktar = new System.Windows.Forms.Label();
            this.cmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.lblOdemeTuru = new System.Windows.Forms.Label();
            this.lnlUrunadi = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numStokMiktari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatisFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlisFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // numStokMiktari
            // 
            this.numStokMiktari.Location = new System.Drawing.Point(316, 13);
            this.numStokMiktari.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numStokMiktari.Name = "numStokMiktari";
            this.numStokMiktari.Size = new System.Drawing.Size(120, 20);
            this.numStokMiktari.TabIndex = 0;
            // 
            // btnStokEkle
            // 
            this.btnStokEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnStokEkle.FlatAppearance.BorderSize = 0;
            this.btnStokEkle.Location = new System.Drawing.Point(219, 282);
            this.btnStokEkle.Name = "btnStokEkle";
            this.btnStokEkle.Size = new System.Drawing.Size(100, 26);
            this.btnStokEkle.TabIndex = 18;
            this.btnStokEkle.Text = "Stok Ekle";
            this.btnStokEkle.UseVisualStyleBackColor = false;
            this.btnStokEkle.Click += new System.EventHandler(this.btnStokEkle_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.BackColor = System.Drawing.Color.Transparent;
            this.btnVazgec.FlatAppearance.BorderSize = 0;
            this.btnVazgec.Location = new System.Drawing.Point(340, 282);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(100, 26);
            this.btnVazgec.TabIndex = 19;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = false;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // numSatisFiyat
            // 
            this.numSatisFiyat.Location = new System.Drawing.Point(316, 65);
            this.numSatisFiyat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSatisFiyat.Name = "numSatisFiyat";
            this.numSatisFiyat.Size = new System.Drawing.Size(120, 20);
            this.numSatisFiyat.TabIndex = 20;
            // 
            // numAlisFiyat
            // 
            this.numAlisFiyat.Location = new System.Drawing.Point(316, 39);
            this.numAlisFiyat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numAlisFiyat.Name = "numAlisFiyat";
            this.numAlisFiyat.Size = new System.Drawing.Size(120, 20);
            this.numAlisFiyat.TabIndex = 21;
            // 
            // lblEklencekStok
            // 
            this.lblEklencekStok.AutoSize = true;
            this.lblEklencekStok.Location = new System.Drawing.Point(197, 15);
            this.lblEklencekStok.Name = "lblEklencekStok";
            this.lblEklencekStok.Size = new System.Drawing.Size(113, 13);
            this.lblEklencekStok.TabIndex = 22;
            this.lblEklencekStok.Text = "Eklenicek Stok Miktarı";
            // 
            // lblAlisFiyat
            // 
            this.lblAlisFiyat.AutoSize = true;
            this.lblAlisFiyat.Location = new System.Drawing.Point(260, 41);
            this.lblAlisFiyat.Name = "lblAlisFiyat";
            this.lblAlisFiyat.Size = new System.Drawing.Size(50, 13);
            this.lblAlisFiyat.TabIndex = 23;
            this.lblAlisFiyat.Text = "Alış Fiyatı";
            // 
            // lblSatisFiyat
            // 
            this.lblSatisFiyat.AutoSize = true;
            this.lblSatisFiyat.Location = new System.Drawing.Point(253, 67);
            this.lblSatisFiyat.Name = "lblSatisFiyat";
            this.lblSatisFiyat.Size = new System.Drawing.Size(57, 13);
            this.lblSatisFiyat.TabIndex = 24;
            this.lblSatisFiyat.Text = "Satış Fiyatı";
            // 
            // lblToplamStok
            // 
            this.lblToplamStok.AutoSize = true;
            this.lblToplamStok.Location = new System.Drawing.Point(9, 72);
            this.lblToplamStok.Name = "lblToplamStok";
            this.lblToplamStok.Size = new System.Drawing.Size(104, 13);
            this.lblToplamStok.TabIndex = 25;
            this.lblToplamStok.Text = "Toplam Stok  Miktarı";
            // 
            // lblStokMiktar
            // 
            this.lblStokMiktar.AutoSize = true;
            this.lblStokMiktar.Location = new System.Drawing.Point(119, 72);
            this.lblStokMiktar.Name = "lblStokMiktar";
            this.lblStokMiktar.Size = new System.Drawing.Size(16, 13);
            this.lblStokMiktar.TabIndex = 26;
            this.lblStokMiktar.Text = "...";
            // 
            // cmbOdemeTuru
            // 
            this.cmbOdemeTuru.FormattingEnabled = true;
            this.cmbOdemeTuru.Location = new System.Drawing.Point(316, 92);
            this.cmbOdemeTuru.Name = "cmbOdemeTuru";
            this.cmbOdemeTuru.Size = new System.Drawing.Size(121, 21);
            this.cmbOdemeTuru.TabIndex = 27;
            // 
            // lblOdemeTuru
            // 
            this.lblOdemeTuru.AutoSize = true;
            this.lblOdemeTuru.Location = new System.Drawing.Point(207, 95);
            this.lblOdemeTuru.Name = "lblOdemeTuru";
            this.lblOdemeTuru.Size = new System.Drawing.Size(103, 13);
            this.lblOdemeTuru.TabIndex = 28;
            this.lblOdemeTuru.Text = "Odeme Turu Seçiniz";
            // 
            // lnlUrunadi
            // 
            this.lnlUrunadi.AutoSize = true;
            this.lnlUrunadi.Location = new System.Drawing.Point(9, 18);
            this.lnlUrunadi.Name = "lnlUrunadi";
            this.lnlUrunadi.Size = new System.Drawing.Size(125, 13);
            this.lnlUrunadi.TabIndex = 29;
            this.lnlUrunadi.Text = "Stok Eklenilcek Ürün Adı";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Enabled = false;
            this.txtUrunAd.Location = new System.Drawing.Point(12, 34);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(154, 20);
            this.txtUrunAd.TabIndex = 31;
            // 
            // frmStokEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 320);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.lnlUrunadi);
            this.Controls.Add(this.lblOdemeTuru);
            this.Controls.Add(this.cmbOdemeTuru);
            this.Controls.Add(this.lblStokMiktar);
            this.Controls.Add(this.lblToplamStok);
            this.Controls.Add(this.lblSatisFiyat);
            this.Controls.Add(this.lblAlisFiyat);
            this.Controls.Add(this.lblEklencekStok);
            this.Controls.Add(this.numAlisFiyat);
            this.Controls.Add(this.numSatisFiyat);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnStokEkle);
            this.Controls.Add(this.numStokMiktari);
            this.Name = "frmStokEkle";
            this.Text = "frmStokEkle";
            this.Load += new System.EventHandler(this.frmStokEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numStokMiktari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatisFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlisFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numStokMiktari;
        private System.Windows.Forms.Button btnStokEkle;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.NumericUpDown numSatisFiyat;
        private System.Windows.Forms.NumericUpDown numAlisFiyat;
        private System.Windows.Forms.Label lblEklencekStok;
        private System.Windows.Forms.Label lblAlisFiyat;
        private System.Windows.Forms.Label lblSatisFiyat;
        private System.Windows.Forms.Label lblToplamStok;
        private System.Windows.Forms.Label lblStokMiktar;
        private System.Windows.Forms.ComboBox cmbOdemeTuru;
        private System.Windows.Forms.Label lblOdemeTuru;
        private System.Windows.Forms.Label lnlUrunadi;
        private System.Windows.Forms.TextBox txtUrunAd;
    }
}
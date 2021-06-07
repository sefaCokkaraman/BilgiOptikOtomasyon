namespace BilgiOptik
{
    partial class frmUrunler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunler));
            this.pnlUst = new System.Windows.Forms.Panel();
            this.btnStokEkle = new System.Windows.Forms.Button();
            this.btnMarkaEkle = new System.Windows.Forms.Button();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.btnGelir = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.dgwUrunler = new System.Windows.Forms.DataGridView();
            this.cmsUrunlerGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSil = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbListele = new System.Windows.Forms.ComboBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.pnlKategori = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.btnOdemeler = new System.Windows.Forms.Button();
            this.btnBilgiler = new System.Windows.Forms.Button();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnAvatar = new System.Windows.Forms.Button();
            this.btnEklentiler = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).BeginInit();
            this.cmsUrunlerGrid.SuspendLayout();
            this.pnlKategori.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnlUst.Controls.Add(this.btnStokEkle);
            this.pnlUst.Controls.Add(this.btnMarkaEkle);
            this.pnlUst.Controls.Add(this.btnKategoriEkle);
            this.pnlUst.Controls.Add(this.btnGelir);
            this.pnlUst.Controls.Add(this.btnUrunEkle);
            this.pnlUst.Location = new System.Drawing.Point(3, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(997, 75);
            this.pnlUst.TabIndex = 11;
            // 
            // btnStokEkle
            // 
            this.btnStokEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnStokEkle.FlatAppearance.BorderSize = 0;
            this.btnStokEkle.Location = new System.Drawing.Point(450, 24);
            this.btnStokEkle.Name = "btnStokEkle";
            this.btnStokEkle.Size = new System.Drawing.Size(100, 26);
            this.btnStokEkle.TabIndex = 18;
            this.btnStokEkle.Text = "Stok Ekle";
            this.btnStokEkle.UseVisualStyleBackColor = false;
            this.btnStokEkle.Click += new System.EventHandler(this.btnStokEkle_Click);
            // 
            // btnMarkaEkle
            // 
            this.btnMarkaEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnMarkaEkle.FlatAppearance.BorderSize = 0;
            this.btnMarkaEkle.Location = new System.Drawing.Point(758, 24);
            this.btnMarkaEkle.Name = "btnMarkaEkle";
            this.btnMarkaEkle.Size = new System.Drawing.Size(100, 26);
            this.btnMarkaEkle.TabIndex = 16;
            this.btnMarkaEkle.Text = "Marka Ekle";
            this.btnMarkaEkle.UseVisualStyleBackColor = false;
            this.btnMarkaEkle.Click += new System.EventHandler(this.btnMarkaEkle_Click);
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnKategoriEkle.FlatAppearance.BorderSize = 0;
            this.btnKategoriEkle.Location = new System.Drawing.Point(604, 24);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(100, 26);
            this.btnKategoriEkle.TabIndex = 17;
            this.btnKategoriEkle.Text = "Kategori Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = false;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // btnGelir
            // 
            this.btnGelir.BackColor = System.Drawing.Color.Transparent;
            this.btnGelir.FlatAppearance.BorderSize = 0;
            this.btnGelir.Location = new System.Drawing.Point(296, 24);
            this.btnGelir.Name = "btnGelir";
            this.btnGelir.Size = new System.Drawing.Size(100, 26);
            this.btnGelir.TabIndex = 14;
            this.btnGelir.Text = "Gelirler";
            this.btnGelir.UseVisualStyleBackColor = false;
            this.btnGelir.Click += new System.EventHandler(this.btnGelir_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnUrunEkle.FlatAppearance.BorderSize = 0;
            this.btnUrunEkle.Location = new System.Drawing.Point(142, 24);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(100, 26);
            this.btnUrunEkle.TabIndex = 13;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // txtArama
            // 
            this.txtArama.BackColor = System.Drawing.SystemColors.Menu;
            this.txtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.Location = new System.Drawing.Point(180, 119);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(527, 31);
            this.txtArama.TabIndex = 12;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // dgwUrunler
            // 
            this.dgwUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrunler.ContextMenuStrip = this.cmsUrunlerGrid;
            this.dgwUrunler.Location = new System.Drawing.Point(180, 165);
            this.dgwUrunler.MultiSelect = false;
            this.dgwUrunler.Name = "dgwUrunler";
            this.dgwUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwUrunler.Size = new System.Drawing.Size(770, 285);
            this.dgwUrunler.TabIndex = 14;
            this.dgwUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUrunler_CellClick);
            this.dgwUrunler.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwUrunler_CellMouseDoubleClick);
            this.dgwUrunler.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwUrunler_CellMouseDown);
            // 
            // cmsUrunlerGrid
            // 
            this.cmsUrunlerGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEkle,
            this.cmsSil,
            this.cmsDuzenle});
            this.cmsUrunlerGrid.Name = "cmsUrunlerGrid";
            this.cmsUrunlerGrid.Size = new System.Drawing.Size(117, 70);
            // 
            // cmsEkle
            // 
            this.cmsEkle.Name = "cmsEkle";
            this.cmsEkle.Size = new System.Drawing.Size(116, 22);
            this.cmsEkle.Text = "Ekle";
            this.cmsEkle.Click += new System.EventHandler(this.cmsEkle_Click);
            // 
            // cmsSil
            // 
            this.cmsSil.Name = "cmsSil";
            this.cmsSil.Size = new System.Drawing.Size(116, 22);
            this.cmsSil.Text = "Sil";
            this.cmsSil.Click += new System.EventHandler(this.cmsSil_Click);
            // 
            // cmsDuzenle
            // 
            this.cmsDuzenle.Name = "cmsDuzenle";
            this.cmsDuzenle.Size = new System.Drawing.Size(116, 22);
            this.cmsDuzenle.Text = "Düzenle";
            this.cmsDuzenle.Click += new System.EventHandler(this.cmsDuzenle_Click);
            // 
            // cmbListele
            // 
            this.cmbListele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.cmbListele.FormattingEnabled = true;
            this.cmbListele.Location = new System.Drawing.Point(713, 119);
            this.cmbListele.Name = "cmbListele";
            this.cmbListele.Size = new System.Drawing.Size(237, 33);
            this.cmbListele.TabIndex = 15;
            this.cmbListele.SelectedIndexChanged += new System.EventHandler(this.cmbListele_SelectedIndexChanged);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.Location = new System.Drawing.Point(180, 456);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 26);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Ürün Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.Location = new System.Drawing.Point(850, 456);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 26);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Ürün Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // pnlKategori
            // 
            this.pnlKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnlKategori.Controls.Add(this.btnMenu);
            this.pnlKategori.Controls.Add(this.btnAnasayfa);
            this.pnlKategori.Controls.Add(this.btnSatinAl);
            this.pnlKategori.Controls.Add(this.btnOdemeler);
            this.pnlKategori.Controls.Add(this.btnBilgiler);
            this.pnlKategori.Controls.Add(this.btnUrunler);
            this.pnlKategori.Controls.Add(this.btnKayit);
            this.pnlKategori.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlKategori.Location = new System.Drawing.Point(0, 0);
            this.pnlKategori.Name = "pnlKategori";
            this.pnlKategori.Size = new System.Drawing.Size(130, 525);
            this.pnlKategori.TabIndex = 16;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(44, 75);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.FlatAppearance.BorderSize = 0;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfa.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAnasayfa.Image = global::BilgiOptik.Properties.Resources.home1;
            this.btnAnasayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnasayfa.Location = new System.Drawing.Point(0, 75);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnAnasayfa.Size = new System.Drawing.Size(140, 75);
            this.btnAnasayfa.TabIndex = 6;
            this.btnAnasayfa.Text = " Anasayfa";
            this.btnAnasayfa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnasayfa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.FlatAppearance.BorderSize = 0;
            this.btnSatinAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatinAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatinAl.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSatinAl.Image = global::BilgiOptik.Properties.Resources.satınAl;
            this.btnSatinAl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatinAl.Location = new System.Drawing.Point(0, 450);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnSatinAl.Size = new System.Drawing.Size(140, 75);
            this.btnSatinAl.TabIndex = 4;
            this.btnSatinAl.Text = " Satın Alma";
            this.btnSatinAl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatinAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSatinAl.UseVisualStyleBackColor = true;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // btnOdemeler
            // 
            this.btnOdemeler.FlatAppearance.BorderSize = 0;
            this.btnOdemeler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdemeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeler.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOdemeler.Image = global::BilgiOptik.Properties.Resources.card;
            this.btnOdemeler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdemeler.Location = new System.Drawing.Point(0, 375);
            this.btnOdemeler.Name = "btnOdemeler";
            this.btnOdemeler.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnOdemeler.Size = new System.Drawing.Size(140, 75);
            this.btnOdemeler.TabIndex = 3;
            this.btnOdemeler.Text = " Ödemeler";
            this.btnOdemeler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdemeler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOdemeler.UseVisualStyleBackColor = true;
            this.btnOdemeler.Click += new System.EventHandler(this.btnOdemeler_Click);
            // 
            // btnBilgiler
            // 
            this.btnBilgiler.FlatAppearance.BorderSize = 0;
            this.btnBilgiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBilgiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgiler.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBilgiler.Image = global::BilgiOptik.Properties.Resources.edit;
            this.btnBilgiler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBilgiler.Location = new System.Drawing.Point(0, 300);
            this.btnBilgiler.Name = "btnBilgiler";
            this.btnBilgiler.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnBilgiler.Size = new System.Drawing.Size(140, 75);
            this.btnBilgiler.TabIndex = 2;
            this.btnBilgiler.Text = " Bilgiler";
            this.btnBilgiler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBilgiler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBilgiler.UseVisualStyleBackColor = true;
            this.btnBilgiler.Click += new System.EventHandler(this.btnBilgiler_Click);
            // 
            // btnUrunler
            // 
            this.btnUrunler.FlatAppearance.BorderSize = 0;
            this.btnUrunler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunler.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUrunler.Image = global::BilgiOptik.Properties.Resources.box1;
            this.btnUrunler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunler.Location = new System.Drawing.Point(0, 225);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnUrunler.Size = new System.Drawing.Size(140, 75);
            this.btnUrunler.TabIndex = 1;
            this.btnUrunler.Text = " Ürünler";
            this.btnUrunler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUrunler.UseVisualStyleBackColor = true;
            // 
            // btnKayit
            // 
            this.btnKayit.FlatAppearance.BorderSize = 0;
            this.btnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKayit.Image = global::BilgiOptik.Properties.Resources.login1;
            this.btnKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKayit.Location = new System.Drawing.Point(0, 150);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnKayit.Size = new System.Drawing.Size(140, 75);
            this.btnKayit.TabIndex = 0;
            this.btnKayit.Text = " Kayıt";
            this.btnKayit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKayit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnlMenu.Controls.Add(this.btnAvatar);
            this.pnlMenu.Controls.Add(this.btnEklentiler);
            this.pnlMenu.Controls.Add(this.btnProfil);
            this.pnlMenu.Controls.Add(this.btnCikis);
            this.pnlMenu.Location = new System.Drawing.Point(862, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(126, 75);
            this.pnlMenu.TabIndex = 41;
            // 
            // btnAvatar
            // 
            this.btnAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAvatar.FlatAppearance.BorderSize = 0;
            this.btnAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAvatar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAvatar.Image = ((System.Drawing.Image)(resources.GetObject("btnAvatar.Image")));
            this.btnAvatar.Location = new System.Drawing.Point(0, 0);
            this.btnAvatar.Name = "btnAvatar";
            this.btnAvatar.Size = new System.Drawing.Size(126, 75);
            this.btnAvatar.TabIndex = 4;
            this.btnAvatar.UseVisualStyleBackColor = false;
            this.btnAvatar.Click += new System.EventHandler(this.btnAvatar_Click);
            // 
            // btnEklentiler
            // 
            this.btnEklentiler.FlatAppearance.BorderSize = 0;
            this.btnEklentiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEklentiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEklentiler.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEklentiler.Image = ((System.Drawing.Image)(resources.GetObject("btnEklentiler.Image")));
            this.btnEklentiler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEklentiler.Location = new System.Drawing.Point(0, 131);
            this.btnEklentiler.Name = "btnEklentiler";
            this.btnEklentiler.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnEklentiler.Size = new System.Drawing.Size(126, 56);
            this.btnEklentiler.TabIndex = 9;
            this.btnEklentiler.Text = " Eklentiler";
            this.btnEklentiler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEklentiler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEklentiler.UseVisualStyleBackColor = true;
            this.btnEklentiler.Click += new System.EventHandler(this.btnEklentiler_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.FlatAppearance.BorderSize = 0;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProfil.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProfil.Image = ((System.Drawing.Image)(resources.GetObject("btnProfil.Image")));
            this.btnProfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfil.Location = new System.Drawing.Point(0, 75);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnProfil.Size = new System.Drawing.Size(126, 56);
            this.btnProfil.TabIndex = 8;
            this.btnProfil.Text = " Profil";
            this.btnProfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfil.UseVisualStyleBackColor = true;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.Location = new System.Drawing.Point(0, 187);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnCikis.Size = new System.Drawing.Size(126, 56);
            this.btnCikis.TabIndex = 10;
            this.btnCikis.Text = " Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 525);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlKategori);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.cmbListele);
            this.Controls.Add(this.dgwUrunler);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.pnlUst);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUrunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.frmUrunler_Load);
            this.pnlUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).EndInit();
            this.cmsUrunlerGrid.ResumeLayout(false);
            this.pnlKategori.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.DataGridView dgwUrunler;
        private System.Windows.Forms.ComboBox cmbListele;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.ContextMenuStrip cmsUrunlerGrid;
        private System.Windows.Forms.ToolStripMenuItem cmsEkle;
        private System.Windows.Forms.ToolStripMenuItem cmsSil;
        private System.Windows.Forms.ToolStripMenuItem cmsDuzenle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGelir;
        private System.Windows.Forms.Button btnMarkaEkle;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.Button btnStokEkle;
        private System.Windows.Forms.Panel pnlKategori;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.Button btnOdemeler;
        private System.Windows.Forms.Button btnBilgiler;
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnAvatar;
        private System.Windows.Forms.Button btnEklentiler;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnCikis;
    }
}
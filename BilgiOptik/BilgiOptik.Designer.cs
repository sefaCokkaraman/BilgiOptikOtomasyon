namespace BilgiOptik
{
    partial class BilgiOptik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BilgiOptik));
            this.lblKayit = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblSifremiUnuttum = new System.Windows.Forms.Label();
            this.lblKad = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.btnSifreKapali = new System.Windows.Forms.Button();
            this.btnSifreAcık = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKayit
            // 
            this.lblKayit.AutoSize = true;
            this.lblKayit.BackColor = System.Drawing.Color.Transparent;
            this.lblKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayit.ForeColor = System.Drawing.Color.Black;
            this.lblKayit.Location = new System.Drawing.Point(117, 414);
            this.lblKayit.Name = "lblKayit";
            this.lblKayit.Size = new System.Drawing.Size(79, 20);
            this.lblKayit.TabIndex = 0;
            this.lblKayit.Text = "Yeni Kayıt";
            this.lblKayit.Click += new System.EventHandler(this.lblKayit_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Black;
            this.btnGiris.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(60, 356);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(193, 32);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.txtSifre.ForeColor = System.Drawing.Color.Black;
            this.txtSifre.Location = new System.Drawing.Point(61, 280);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(193, 34);
            this.txtSifre.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(60, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(61, 220);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(193, 34);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // lblSifremiUnuttum
            // 
            this.lblSifremiUnuttum.AutoSize = true;
            this.lblSifremiUnuttum.BackColor = System.Drawing.Color.Transparent;
            this.lblSifremiUnuttum.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblSifremiUnuttum.ForeColor = System.Drawing.Color.Black;
            this.lblSifremiUnuttum.Location = new System.Drawing.Point(139, 324);
            this.lblSifremiUnuttum.Name = "lblSifremiUnuttum";
            this.lblSifremiUnuttum.Size = new System.Drawing.Size(114, 19);
            this.lblSifremiUnuttum.TabIndex = 5;
            this.lblSifremiUnuttum.Text = "Şifremi Unuttum";
            this.lblSifremiUnuttum.Click += new System.EventHandler(this.lblSifremiUnuttum_Click);
            // 
            // lblKad
            // 
            this.lblKad.AutoSize = true;
            this.lblKad.BackColor = System.Drawing.Color.Transparent;
            this.lblKad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblKad.ForeColor = System.Drawing.Color.Black;
            this.lblKad.Location = new System.Drawing.Point(56, 195);
            this.lblKad.Name = "lblKad";
            this.lblKad.Size = new System.Drawing.Size(35, 21);
            this.lblKad.TabIndex = 0;
            this.lblKad.Text = "Ad:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblSifre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblSifre.ForeColor = System.Drawing.Color.Black;
            this.lblSifre.Location = new System.Drawing.Point(56, 255);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(48, 21);
            this.lblSifre.TabIndex = 0;
            this.lblSifre.Text = "Şifre:";
            // 
            // btnSifreKapali
            // 
            this.btnSifreKapali.BackColor = System.Drawing.Color.White;
            this.btnSifreKapali.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSifreKapali.BackgroundImage")));
            this.btnSifreKapali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSifreKapali.FlatAppearance.BorderSize = 0;
            this.btnSifreKapali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifreKapali.ForeColor = System.Drawing.Color.Black;
            this.btnSifreKapali.Location = new System.Drawing.Point(221, 281);
            this.btnSifreKapali.Name = "btnSifreKapali";
            this.btnSifreKapali.Size = new System.Drawing.Size(32, 32);
            this.btnSifreKapali.TabIndex = 1;
            this.btnSifreKapali.UseVisualStyleBackColor = false;
            this.btnSifreKapali.Click += new System.EventHandler(this.btnSifreKapali_Click);
            // 
            // btnSifreAcık
            // 
            this.btnSifreAcık.BackColor = System.Drawing.Color.White;
            this.btnSifreAcık.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSifreAcık.BackgroundImage")));
            this.btnSifreAcık.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSifreAcık.FlatAppearance.BorderSize = 0;
            this.btnSifreAcık.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifreAcık.Location = new System.Drawing.Point(221, 281);
            this.btnSifreAcık.Name = "btnSifreAcık";
            this.btnSifreAcık.Size = new System.Drawing.Size(32, 32);
            this.btnSifreAcık.TabIndex = 0;
            this.btnSifreAcık.UseVisualStyleBackColor = false;
            this.btnSifreAcık.Click += new System.EventHandler(this.btnSifreAcık_Click);
            // 
            // BilgiOptik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(312, 455);
            this.Controls.Add(this.btnSifreAcık);
            this.Controls.Add(this.btnSifreKapali);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKad);
            this.Controls.Add(this.lblSifremiUnuttum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.lblKayit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BilgiOptik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgi Optik";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKayit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblSifremiUnuttum;
        private System.Windows.Forms.Label lblKad;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Button btnSifreKapali;
        private System.Windows.Forms.Button btnSifreAcık;
    }
}
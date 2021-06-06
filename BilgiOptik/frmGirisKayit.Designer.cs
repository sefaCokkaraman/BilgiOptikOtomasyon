
namespace BilgiOptik
{
    partial class frmGirisKayit
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
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.mtbTelefon = new System.Windows.Forms.MaskedTextBox();
            this.rtbAdres = new System.Windows.Forms.RichTextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtTCKimlik = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblTCKimlikNo = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.btnKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.BackColor = System.Drawing.Color.Transparent;
            this.lblAd.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblAd.ForeColor = System.Drawing.Color.Black;
            this.lblAd.Location = new System.Drawing.Point(40, 13);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(41, 25);
            this.lblAd.TabIndex = 28;
            this.lblAd.Text = "Ad:";
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.White;
            this.txtAd.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.txtAd.ForeColor = System.Drawing.Color.Black;
            this.txtAd.Location = new System.Drawing.Point(90, 10);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(257, 35);
            this.txtAd.TabIndex = 1;
            // 
            // mtbTelefon
            // 
            this.mtbTelefon.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.mtbTelefon.ForeColor = System.Drawing.Color.Black;
            this.mtbTelefon.Location = new System.Drawing.Point(90, 157);
            this.mtbTelefon.Mask = "(999) 000-0000";
            this.mtbTelefon.Name = "mtbTelefon";
            this.mtbTelefon.Size = new System.Drawing.Size(257, 32);
            this.mtbTelefon.TabIndex = 4;
            // 
            // rtbAdres
            // 
            this.rtbAdres.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.rtbAdres.ForeColor = System.Drawing.Color.Black;
            this.rtbAdres.Location = new System.Drawing.Point(90, 252);
            this.rtbAdres.Name = "rtbAdres";
            this.rtbAdres.Size = new System.Drawing.Size(257, 77);
            this.rtbAdres.TabIndex = 6;
            this.rtbAdres.Text = "";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefon.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTelefon.ForeColor = System.Drawing.Color.Black;
            this.lblTelefon.Location = new System.Drawing.Point(2, 157);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(79, 25);
            this.lblTelefon.TabIndex = 41;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblMail.ForeColor = System.Drawing.Color.Black;
            this.lblMail.Location = new System.Drawing.Point(26, 109);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(55, 25);
            this.lblMail.TabIndex = 40;
            this.lblMail.Text = "Mail:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblSoyad.ForeColor = System.Drawing.Color.Black;
            this.lblSoyad.Location = new System.Drawing.Point(12, 61);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(69, 25);
            this.lblSoyad.TabIndex = 39;
            this.lblSoyad.Text = "Soyad:";
            // 
            // txtTCKimlik
            // 
            this.txtTCKimlik.BackColor = System.Drawing.Color.White;
            this.txtTCKimlik.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.txtTCKimlik.ForeColor = System.Drawing.Color.Black;
            this.txtTCKimlik.Location = new System.Drawing.Point(90, 203);
            this.txtTCKimlik.MaxLength = 11;
            this.txtTCKimlik.Multiline = true;
            this.txtTCKimlik.Name = "txtTCKimlik";
            this.txtTCKimlik.Size = new System.Drawing.Size(257, 35);
            this.txtTCKimlik.TabIndex = 5;
            // 
            // txtEposta
            // 
            this.txtEposta.BackColor = System.Drawing.Color.White;
            this.txtEposta.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.txtEposta.ForeColor = System.Drawing.Color.Black;
            this.txtEposta.Location = new System.Drawing.Point(90, 108);
            this.txtEposta.Multiline = true;
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(257, 35);
            this.txtEposta.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.White;
            this.txtSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.txtSoyad.ForeColor = System.Drawing.Color.Black;
            this.txtSoyad.Location = new System.Drawing.Point(90, 59);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(257, 35);
            this.txtSoyad.TabIndex = 2;
            // 
            // lblTCKimlikNo
            // 
            this.lblTCKimlikNo.AutoSize = true;
            this.lblTCKimlikNo.BackColor = System.Drawing.Color.Transparent;
            this.lblTCKimlikNo.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTCKimlikNo.ForeColor = System.Drawing.Color.Black;
            this.lblTCKimlikNo.Location = new System.Drawing.Point(39, 209);
            this.lblTCKimlikNo.Name = "lblTCKimlikNo";
            this.lblTCKimlikNo.Size = new System.Drawing.Size(42, 25);
            this.lblTCKimlikNo.TabIndex = 42;
            this.lblTCKimlikNo.Text = "T.C:";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.BackColor = System.Drawing.Color.Transparent;
            this.lblAdres.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblAdres.ForeColor = System.Drawing.Color.Black;
            this.lblAdres.Location = new System.Drawing.Point(15, 255);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(66, 25);
            this.lblAdres.TabIndex = 43;
            this.lblAdres.Text = "Adres:";
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.Black;
            this.btnKayit.FlatAppearance.BorderSize = 0;
            this.btnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayit.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold);
            this.btnKayit.ForeColor = System.Drawing.Color.White;
            this.btnKayit.Location = new System.Drawing.Point(90, 337);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(257, 42);
            this.btnKayit.TabIndex = 46;
            this.btnKayit.Text = "KAYIT";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // frmGirisKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(364, 387);
            this.Controls.Add(this.mtbTelefon);
            this.Controls.Add(this.rtbAdres);
            this.Controls.Add(this.txtTCKimlik);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblTCKimlikNo);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblAd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGirisKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt";
            this.Load += new System.EventHandler(this.frmGirisKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox mtbTelefon;
        private System.Windows.Forms.RichTextBox rtbAdres;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtTCKimlik;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblTCKimlikNo;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Button btnKayit;
    }
}
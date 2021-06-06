
namespace BilgiOptik
{
    partial class frmNotDefteri
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.rtbMesaj = new System.Windows.Forms.RichTextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.kaydet = new System.Windows.Forms.SaveFileDialog();
            this.lstGecmisNotlar = new System.Windows.Forms.ListBox();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Location = new System.Drawing.Point(12, 173);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(105, 40);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // rtbMesaj
            // 
            this.rtbMesaj.Location = new System.Drawing.Point(12, 44);
            this.rtbMesaj.Name = "rtbMesaj";
            this.rtbMesaj.Size = new System.Drawing.Size(396, 121);
            this.rtbMesaj.TabIndex = 2;
            this.rtbMesaj.Text = "";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnTemizle.Location = new System.Drawing.Point(499, 173);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(105, 40);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lstGecmisNotlar
            // 
            this.lstGecmisNotlar.FormattingEnabled = true;
            this.lstGecmisNotlar.Location = new System.Drawing.Point(415, 44);
            this.lstGecmisNotlar.Name = "lstGecmisNotlar";
            this.lstGecmisNotlar.Size = new System.Drawing.Size(190, 121);
            this.lstGecmisNotlar.TabIndex = 5;
            this.lstGecmisNotlar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstGecmisNotlar_MouseDoubleClick);
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(12, 12);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(592, 20);
            this.txtBaslik.TabIndex = 1;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.Location = new System.Drawing.Point(161, 173);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(105, 40);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSil.Location = new System.Drawing.Point(328, 173);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(105, 40);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmNotDefteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(616, 224);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.lstGecmisNotlar);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.rtbMesaj);
            this.Controls.Add(this.btnKaydet);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNotDefteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not Defteri";
            this.Load += new System.EventHandler(this.frmNotDefteri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.RichTextBox rtbMesaj;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.SaveFileDialog kaydet;
        private System.Windows.Forms.ListBox lstGecmisNotlar;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
    }
}
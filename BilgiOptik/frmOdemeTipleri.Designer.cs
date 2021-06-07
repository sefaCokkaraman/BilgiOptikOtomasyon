
namespace BilgiOptik
{
    partial class frmOdemeTipleri
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
            this.btnSil = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnBas = new System.Windows.Forms.Button();
            this.lblKategoriler = new System.Windows.Forms.Label();
            this.lstboxOdemeTipleri = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSil.Location = new System.Drawing.Point(182, 26);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(72, 34);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(182, 100);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(75, 34);
            this.btnVazgec.TabIndex = 9;
            this.btnVazgec.Text = "Kapat";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnBas
            // 
            this.btnBas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBas.Location = new System.Drawing.Point(12, 140);
            this.btnBas.Name = "btnBas";
            this.btnBas.Size = new System.Drawing.Size(164, 34);
            this.btnBas.TabIndex = 8;
            this.btnBas.Text = "Yeni Ödeme Türü Ekle";
            this.btnBas.UseVisualStyleBackColor = false;
            this.btnBas.Click += new System.EventHandler(this.btnBas_Click);
            // 
            // lblKategoriler
            // 
            this.lblKategoriler.AutoSize = true;
            this.lblKategoriler.Location = new System.Drawing.Point(9, 10);
            this.lblKategoriler.Name = "lblKategoriler";
            this.lblKategoriler.Size = new System.Drawing.Size(124, 13);
            this.lblKategoriler.TabIndex = 7;
            this.lblKategoriler.Text = "Aktif Ödeme Seçenekleri";
            // 
            // lstboxOdemeTipleri
            // 
            this.lstboxOdemeTipleri.FormattingEnabled = true;
            this.lstboxOdemeTipleri.Location = new System.Drawing.Point(12, 26);
            this.lstboxOdemeTipleri.Name = "lstboxOdemeTipleri";
            this.lstboxOdemeTipleri.Size = new System.Drawing.Size(164, 108);
            this.lstboxOdemeTipleri.TabIndex = 6;
            this.lstboxOdemeTipleri.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstboxOdemeTipleri_MouseDoubleClick);
            // 
            // frmOdemeTipleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 190);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnBas);
            this.Controls.Add(this.lblKategoriler);
            this.Controls.Add(this.lstboxOdemeTipleri);
            this.Name = "frmOdemeTipleri";
            this.Text = "frmOdemeTipleri";
            this.Load += new System.EventHandler(this.frmOdemeTipleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnBas;
        private System.Windows.Forms.Label lblKategoriler;
        private System.Windows.Forms.ListBox lstboxOdemeTipleri;
    }
}
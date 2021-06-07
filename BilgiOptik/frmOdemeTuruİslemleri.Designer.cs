
namespace BilgiOptik
{
    partial class frmOdemeTuruİslemleri
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
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtOdemeTuruAdi = new System.Windows.Forms.TextBox();
            this.lblOdemeTuru = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(141, 57);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 11;
            this.btnIptal.Text = "Iptal Et";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(22, 57);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtOdemeTuruAdi
            // 
            this.txtOdemeTuruAdi.Location = new System.Drawing.Point(102, 19);
            this.txtOdemeTuruAdi.Name = "txtOdemeTuruAdi";
            this.txtOdemeTuruAdi.Size = new System.Drawing.Size(100, 20);
            this.txtOdemeTuruAdi.TabIndex = 9;
            // 
            // lblOdemeTuru
            // 
            this.lblOdemeTuru.AutoSize = true;
            this.lblOdemeTuru.Location = new System.Drawing.Point(12, 22);
            this.lblOdemeTuru.Name = "lblOdemeTuru";
            this.lblOdemeTuru.Size = new System.Drawing.Size(84, 13);
            this.lblOdemeTuru.TabIndex = 8;
            this.lblOdemeTuru.Text = "Ödeme Türü Adı";
            // 
            // frmOdemeTuruİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 97);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtOdemeTuruAdi);
            this.Controls.Add(this.lblOdemeTuru);
            this.Name = "frmOdemeTuruİslemleri";
            this.Text = "frmOdemeTuruİslemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOdemeTuruİslemleri_FormClosing);
            this.Load += new System.EventHandler(this.frmOdemeTuruİslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtOdemeTuruAdi;
        private System.Windows.Forms.Label lblOdemeTuru;
    }
}
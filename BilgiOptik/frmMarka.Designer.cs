
namespace BilgiOptik
{
    partial class frmMarka
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblKategoriler = new System.Windows.Forms.Label();
            this.lstboxMarkalar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSil.Location = new System.Drawing.Point(182, 36);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(72, 34);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(101, 150);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(75, 34);
            this.btnVazgec.TabIndex = 9;
            this.btnVazgec.Text = "Kapat";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEkle.Location = new System.Drawing.Point(12, 150);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(72, 34);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Yeni Marka Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblKategoriler
            // 
            this.lblKategoriler.AutoSize = true;
            this.lblKategoriler.Location = new System.Drawing.Point(9, 20);
            this.lblKategoriler.Name = "lblKategoriler";
            this.lblKategoriler.Size = new System.Drawing.Size(48, 13);
            this.lblKategoriler.TabIndex = 7;
            this.lblKategoriler.Text = "Markalar";
            // 
            // lstboxMarkalar
            // 
            this.lstboxMarkalar.FormattingEnabled = true;
            this.lstboxMarkalar.Location = new System.Drawing.Point(12, 36);
            this.lstboxMarkalar.Name = "lstboxMarkalar";
            this.lstboxMarkalar.Size = new System.Drawing.Size(164, 108);
            this.lstboxMarkalar.TabIndex = 6;
            this.lstboxMarkalar.SelectedIndexChanged += new System.EventHandler(this.lstboxMarkalar_SelectedIndexChanged);
            this.lstboxMarkalar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstboxMarkalar_MouseDoubleClick);
            // 
            // frmMarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 211);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblKategoriler);
            this.Controls.Add(this.lstboxMarkalar);
            this.Name = "frmMarka";
            this.Text = "Marka";
            this.Load += new System.EventHandler(this.frmMarka_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblKategoriler;
        private System.Windows.Forms.ListBox lstboxMarkalar;
    }
}
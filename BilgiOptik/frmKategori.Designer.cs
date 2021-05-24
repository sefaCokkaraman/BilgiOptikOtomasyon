
namespace BilgiOptik
{
    partial class frmKategori
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
            this.lstboxKategoriler = new System.Windows.Forms.ListBox();
            this.lblKategoriler = new System.Windows.Forms.Label();
            this.btnBas = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstboxKategoriler
            // 
            this.lstboxKategoriler.FormattingEnabled = true;
            this.lstboxKategoriler.Location = new System.Drawing.Point(12, 35);
            this.lstboxKategoriler.Name = "lstboxKategoriler";
            this.lstboxKategoriler.Size = new System.Drawing.Size(164, 108);
            this.lstboxKategoriler.TabIndex = 0;
            this.lstboxKategoriler.SelectedIndexChanged += new System.EventHandler(this.lstboxKategoriler_SelectedIndexChanged);
            this.lstboxKategoriler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstboxKategoriler_MouseDoubleClick);
            // 
            // lblKategoriler
            // 
            this.lblKategoriler.AutoSize = true;
            this.lblKategoriler.Location = new System.Drawing.Point(9, 19);
            this.lblKategoriler.Name = "lblKategoriler";
            this.lblKategoriler.Size = new System.Drawing.Size(99, 13);
            this.lblKategoriler.TabIndex = 1;
            this.lblKategoriler.Text = "Eklenen Kategoriler";
            // 
            // btnBas
            // 
            this.btnBas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBas.Location = new System.Drawing.Point(12, 149);
            this.btnBas.Name = "btnBas";
            this.btnBas.Size = new System.Drawing.Size(72, 34);
            this.btnBas.TabIndex = 2;
            this.btnBas.Text = "Yeni Kategori Ekle";
            this.btnBas.UseVisualStyleBackColor = false;
            this.btnBas.Click += new System.EventHandler(this.btnBas_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(101, 149);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(75, 34);
            this.btnVazgec.TabIndex = 4;
            this.btnVazgec.Text = "Kapat";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSil.Location = new System.Drawing.Point(182, 35);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(72, 34);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 250);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnBas);
            this.Controls.Add(this.lblKategoriler);
            this.Controls.Add(this.lstboxKategoriler);
            this.Name = "frmKategori";
            this.Text = "frmKategori";
            this.Load += new System.EventHandler(this.frmKategori_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxKategoriler;
        private System.Windows.Forms.Label lblKategoriler;
        private System.Windows.Forms.Button btnBas;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnSil;
    }
}
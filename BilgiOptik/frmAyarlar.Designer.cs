namespace BilgiOptik
{
    partial class frmAyarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAyarlar));
            this.btnAjanda = new System.Windows.Forms.Button();
            this.btnNotDefteri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbAjanda = new System.Windows.Forms.RadioButton();
            this.rbNotDefteri = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnAjanda
            // 
            this.btnAjanda.FlatAppearance.BorderSize = 0;
            this.btnAjanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjanda.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAjanda.Image = ((System.Drawing.Image)(resources.GetObject("btnAjanda.Image")));
            this.btnAjanda.Location = new System.Drawing.Point(21, 12);
            this.btnAjanda.Name = "btnAjanda";
            this.btnAjanda.Size = new System.Drawing.Size(60, 70);
            this.btnAjanda.TabIndex = 13;
            this.btnAjanda.UseVisualStyleBackColor = true;
            this.btnAjanda.Click += new System.EventHandler(this.btnAjanda_Click);
            // 
            // btnNotDefteri
            // 
            this.btnNotDefteri.FlatAppearance.BorderSize = 0;
            this.btnNotDefteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotDefteri.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNotDefteri.Image = ((System.Drawing.Image)(resources.GetObject("btnNotDefteri.Image")));
            this.btnNotDefteri.Location = new System.Drawing.Point(139, 12);
            this.btnNotDefteri.Name = "btnNotDefteri";
            this.btnNotDefteri.Size = new System.Drawing.Size(65, 70);
            this.btnNotDefteri.TabIndex = 12;
            this.btnNotDefteri.UseVisualStyleBackColor = true;
            this.btnNotDefteri.Click += new System.EventHandler(this.btnNotDefteri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "AJANDA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(119, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "NOT DEFTERİ";
            // 
            // rbAjanda
            // 
            this.rbAjanda.AutoSize = true;
            this.rbAjanda.Enabled = false;
            this.rbAjanda.Location = new System.Drawing.Point(46, 118);
            this.rbAjanda.Name = "rbAjanda";
            this.rbAjanda.Size = new System.Drawing.Size(14, 13);
            this.rbAjanda.TabIndex = 16;
            this.rbAjanda.TabStop = true;
            this.rbAjanda.UseVisualStyleBackColor = true;
            // 
            // rbNotDefteri
            // 
            this.rbNotDefteri.AutoSize = true;
            this.rbNotDefteri.Enabled = false;
            this.rbNotDefteri.Location = new System.Drawing.Point(164, 118);
            this.rbNotDefteri.Name = "rbNotDefteri";
            this.rbNotDefteri.Size = new System.Drawing.Size(14, 13);
            this.rbNotDefteri.TabIndex = 17;
            this.rbNotDefteri.TabStop = true;
            this.rbNotDefteri.UseVisualStyleBackColor = true;
            // 
            // frmAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(236, 140);
            this.Controls.Add(this.rbNotDefteri);
            this.Controls.Add(this.rbAjanda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAjanda);
            this.Controls.Add(this.btnNotDefteri);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAyarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjanda;
        private System.Windows.Forms.Button btnNotDefteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbAjanda;
        private System.Windows.Forms.RadioButton rbNotDefteri;
    }
}
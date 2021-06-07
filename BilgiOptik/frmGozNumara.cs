using BilgiOptik.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiOptik
{
    public partial class frmGozNumara : Form
    {
        public frmGozNumara()
        {
            InitializeComponent();
        }

        BilgiOptikContext db = new BilgiOptikContext();
     

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //SOL GÖZ
            {   gozUzak uzak = new gozUzak();
        gozYakin yakin = new gozYakin();
        gozDaimi daimi = new gozDaimi();
                //GÖZ ID = sol,sağ
                //GÖZ DERECE = uzak,yakın,daimi

                //Sol - Sağ Uzak
                if (txtSolUzakAxis.Text != null || txtSolUzakCyl.Text != null || txtSolUzakSph.Text != null)
                {
                    uzak.musteriID = Program.id;
                    uzak.solAxis = decimal.Parse(txtSolUzakAxis.Text);
                    uzak.solCyl = decimal.Parse(txtSolUzakCyl.Text);
                    uzak.solSph = decimal.Parse(txtSolUzakSph.Text);

                    if (txtSagUzakAxis.Text != null || txtSagUzakAxis.Text != null || txtSagUzakAxis.Text != null)
                    {
                        uzak.musteriID = Program.id;
                        uzak.sagAxis = decimal.Parse(txtSagUzakAxis.Text);
                        uzak.sagCyl = decimal.Parse(txtSagUzakCyl.Text);
                        uzak.sagSph = decimal.Parse(txtSagUzakSph.Text);
                    }
                    uzak.tarih = DateTime.Now;
                    db.gozUzak.Add(uzak);
                    db.SaveChanges();
                }

                //Sol - Sağ Yakın
                if (txtSolYakinAxis.Text != null || txtSolYakinCyl.Text != null || txtSolYakinSph.Text != null)
                {
                    yakin.musteriID = Program.id;
                    yakin.solAxis = decimal.Parse(txtSolYakinAxis.Text);
                    yakin.solCyl = decimal.Parse(txtSolYakinCyl.Text);
                    yakin.solSph = decimal.Parse(txtSolYakinSph.Text);

                    if (txtSagYakinAxis.Text != null || txtSagYakinCyl.Text != null || txtSagYakinSph.Text != null)
                    {
                        yakin.musteriID = Program.id;
                        yakin.sagAxis = decimal.Parse(txtSagYakinAxis.Text);
                        yakin.sagCyl = decimal.Parse(txtSagYakinCyl.Text);
                        yakin.sagSph = decimal.Parse(txtSagYakinSph.Text);
                    }
                    yakin.tarih = DateTime.Now;
                    db.gozYakin.Add(yakin);
                    db.SaveChanges();
                }

                //Sol - Sağ Daimi
                if (txtSolDaimiAxis.Text != null || txtSolDaimiCyl.Text != null || txtSolDaimiSph.Text != null)
                {
                    daimi.musteriID = Program.id;
                    daimi.solAxis = decimal.Parse(txtSolDaimiAxis.Text);
                    daimi.solCyl = decimal.Parse(txtSolDaimiCyl.Text);
                    daimi.solSph = decimal.Parse(txtSolDaimiSph.Text);

                    if (txtSagDaimiAxis.Text != null || txtSagDaimiCyl.Text != null || txtSagDaimiSph.Text != null)
                    {
                        daimi.musteriID = Program.id;
                        daimi.sagAxis = decimal.Parse(txtSagDaimiAxis.Text);
                        daimi.sagCyl = decimal.Parse(txtSagDaimiCyl.Text);
                        daimi.sagSph = decimal.Parse(txtSagDaimiSph.Text);
                    }
                    daimi.tarih = DateTime.Now;
                    db.gozDaimi.Add(daimi);
                    db.SaveChanges();
                }
                GozGecmis gozGecmis = new GozGecmis();
                gozGecmis.gozDaimiID = daimi.gozDaimiID;
                gozGecmis.gozUzakID= uzak.gozUzakID;
                gozGecmis.gozYakinID = yakin.gozYakinID;
                gozGecmis.gozGecmisID = Program.SatisGozArasiID;
                db.GozGecmis.Add(gozGecmis);
                db.SaveChanges();

                MessageBox.Show("Göz Numaraları Alınmıştır", "Göz Numara", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult dialog = MessageBox.Show("Satın Alma İşleminiz Başarıyla Gerçekleştirilmiştir." +
                "\nÖdeme Alanına gitmek için Evet gitmemek için Hayır butonuna basınız.",
                "Satın Alma Başarıyla Gerçekleşti", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    formlarArasıGecis.odemeler.Show();
                    this.Hide();
                }
                else if (dialog == DialogResult.No)
                {
                    FormAcma.satinAl.Show();
                    this.Hide();
                }
            }
        }

        private void frmGozNumara_Load(object sender, EventArgs e)
        {

        }

        private void txtSolYakinSph_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSolDaimiSph_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSolDaimiCyl_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSolYakinCyl_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSolUzakCyl_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSolUzakAxis_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSolUzakSph_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSolYakinAxis_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSolDaimiAxis_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSagDaimiSph_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSagYakinSph_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSagUzakSph_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSagUzakCyl_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSagYakinCyl_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSagDaimiCyl_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSagDaimiAxis_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSagYakinAxis_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSagUzakAxis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();
        }

        private void btnAjanda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yakında Eklenilcek...");

            //if (Program.ajanda == false)
            //{
            //    Program.ajanda = true;
            //    rbAjanda.Checked = true;
            //}
            //else
            //{
            //    Program.ajanda = false;
            //    rbAjanda.Checked = false;
            //}
        }

        private void btnNotDefteri_Click(object sender, EventArgs e)
        {
            if (Program.notDefteri == false)
            {
                Program.notDefteri = true;
                rbNotDefteri.Checked = true;
                frmAnasayfa anasayfa = new frmAnasayfa();
                anasayfa.NotDefteriGoster();
            }
            else
            {
                Program.notDefteri = false;
                rbNotDefteri.Checked = false;
                frmAnasayfa anasayfa = new frmAnasayfa();
                anasayfa.NotDefteriGoster();
            }
        }
    }
}

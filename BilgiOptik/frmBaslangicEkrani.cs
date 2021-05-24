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
    public partial class frmBaslangicEkrani : Form
    {
        public frmBaslangicEkrani()
        {
            InitializeComponent();
        }

        private void zaman_Tick(object sender, EventArgs e)
        {
            panel2.Width += 7;
            if(panel2.Width >= 1000)
            {
                zaman.Stop();
                formlarArasıGecis.giris.Show();
                this.Hide();
            }
        }
    }
}

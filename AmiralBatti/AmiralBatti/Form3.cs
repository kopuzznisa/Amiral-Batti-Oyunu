using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace AmiralBatti
{
    public partial class Form3 : Form
    {
        int buOyunHamle, buOyunDakika, buOyunSaniye, enİyiHamle, enİyiDakika, enİyiSaniye;

        public Form3(int hamle, int hamle2, int dakika, int dakika2, int saniye, int saniye2)
        {
            buOyunHamle = hamle;
            buOyunDakika = dakika;
            buOyunSaniye = saniye;
            enİyiHamle = hamle2;
            enİyiDakika = dakika2;
            enİyiSaniye = saniye2;
            InitializeComponent();
            label1.Text += buOyunHamle.ToString();
            label2.Text += buOyunDakika.ToString("00") + ":" + buOyunSaniye.ToString("00");
            label3.Text += enİyiHamle.ToString();
            label4.Text += enİyiDakika.ToString("00") + ":" + enİyiSaniye.ToString("00");
        }

        private void YenidenOyna_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

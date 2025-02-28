using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmiralBatti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void OyunuBaslat_Click(object sender, EventArgs e)
        {
            Form2 Oyun = new Form2();
            Oyun.Location = this.Location;
            Oyun.FormClosed += FormKapandi;
            Oyun.Show();
            this.Hide();
        }

        private void NasilOynanir_Click(object sender, EventArgs e)
        {
            Form4 Oynanis = new Form4();
            Oynanis.Location = this.Location;
            Oynanis.FormClosed += FormKapandi;
            Oynanis.Show();
            this.Hide();
        }

        private void FormKapandi(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}

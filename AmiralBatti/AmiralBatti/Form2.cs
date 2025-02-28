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
    public partial class Form2 : Form
    {
        Button[,] butonlar = new Button[15, 15];
        List<Gemi> Gemiler = new List<Gemi>();
        int hamleSayisi, enİyiHamle = 0, dakika, saniye, enİyiDakika = -1, enİyiSaniye, sesAcik = 1;

        public class Gemi
        {
            public int x1, y1, x2, y2;
            public Gemi(int satir1, int sutun1, int satir2, int sutun2)
            {
                x1 = satir1;
                y1 = sutun1;
                x2 = satir2;
                y2 = sutun2;
            }
        }

        public Form2()
        {
            InitializeComponent();
            DuzlemOlustur();
            OyunKur();
        }

        private void MenuyeDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Yenile_Click(object sender, EventArgs e)
        {
            OyunKur();
        }

        private void SesAyarla_Click(object sender, EventArgs e)
        {
            if (sesAcik == 1)
            {
                sesAcik = 0;
                SesAyarla.BackgroundImage = Properties.Resources.ses_kapalı;
                SesAyarla.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                sesAcik = 1;
                SesAyarla.BackgroundImage = Properties.Resources.ses_açık;
                SesAyarla.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void DuzlemOlustur()
        {
            const int butonBuyukluk = 30;
            const int solKenar = 140;
            const int ustKenar = 70;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    butonlar[i, j] = new Button();
                    butonlar[i, j].Size = new Size(butonBuyukluk, butonBuyukluk);
                    butonlar[i, j].Left = solKenar + j * (butonBuyukluk);
                    butonlar[i, j].Top = ustKenar + i * (butonBuyukluk);
                    butonlar[i, j].BackColor = SystemColors.Control;
                    butonlar[i, j].Cursor = Cursors.Hand;
                    butonlar[i, j].TabStop = false;
                    butonlar[i, j].Click += new EventHandler(Hamle);
                    this.Controls.Add(butonlar[i, j]);
                }
            }
        }

        private void OyunKur()
        {
            Gemiler.Clear();
            foreach (Button btn in butonlar)
            {
                btn.BackgroundImage = null;
                btn.BackColor = SystemColors.Control;
                btn.Enabled = true;
                btn.Tag = null;
            }
            GemiYerlestir(4, 1);
            GemiYerlestir(3, 2);
            GemiYerlestir(2, 3);
            GemiYerlestir(1, 4);
            hamleSayisi = 0;
            dakika = 0;
            saniye = 0;
            label1.Text = "Hamle sayısı: " + hamleSayisi.ToString();
            label2.Text = "Süre: " + dakika.ToString("00") + ":" + saniye.ToString("00");
            timer1.Start();
        }

        private void GemiYerlestir(int kareSayisi, int adet)
        {
            Random rnd = new Random();
            bool cakisma;
            int i, satir1, sutun1, satir2, sutun2, pozisyon;
            while (adet > 0)
            {
                adet--;
                pozisyon = rnd.Next(1, 3);
                do
                {
                    satir1 = rnd.Next(15);
                    sutun1 = rnd.Next(15);
                    if (pozisyon == 1)
                    {
                        satir2 = satir1 + kareSayisi - 1;
                        sutun2 = sutun1;
                    }
                    else
                    {
                        satir2 = satir1;
                        sutun2 = sutun1 + kareSayisi - 1;
                    }
                    cakisma = CakismaVarMi(satir1, sutun1, satir2, sutun2);
                } while (satir2 >= 15 || sutun2 >= 15 || cakisma);
                if (pozisyon == 1)
                {
                    for (i = 0; i < kareSayisi; i++)
                        butonlar[satir1 + i, sutun1].Tag = "gemi";
                }
                else
                {
                    for (i = 0; i < kareSayisi; i++)
                        butonlar[satir1, sutun1 + i].Tag = "gemi";
                }
                Gemi yeniGemi = new Gemi(satir1, sutun1, satir2, sutun2);
                Gemiler.Add(yeniGemi);
            }
        }


        private bool CakismaVarMi(int satir1, int sutun1, int satir2, int sutun2)
        {
            int[] yatay = { 0, 0, -1, 1, -1, -1, 1, 1 };
            int[] dikey = { -1, 1, 0, 0, -1, 1, -1, 1 };
            for (int i = satir1; i <= satir2 && i < 15; i++)
            {
                for (int j = sutun1; j <= sutun2 && j < 15; j++)
                {
                    if (butonlar[i, j].Tag != null && butonlar[i, j].Tag.ToString() == "gemi")
                        return true;
                    for (int k = 0; k < 8; k++)
                    {
                        int x = i + yatay[k];
                        int y = j + dikey[k];
                        if (x >= 0 && x < 15 && y >= 0 && y < 15 && butonlar[x, y].Tag != null && butonlar[x, y].Tag.ToString() == "gemi")
                            return true;
                    }
                }
            }
            return false;
        }

        private void GemiVuruldu()
        {
            int[] yatay = { 0, 0, -1, 1, -1, -1, 1, 1 };
            int[] dikey = { -1, 1, 0, 0, -1, 1, -1, 1 };
            int i, j, k, kontrol;
            foreach (var gemi in Gemiler)
            {
                kontrol = 0;
                for (i = gemi.x1; i <= gemi.x2; i++)
                {
                    for (j = gemi.y1; j <= gemi.y2; j++)
                    {
                        if (butonlar[i, j].Tag != null && butonlar[i, j].Tag.ToString() == "gemi")
                            kontrol++;
                    }
                }
                if (kontrol == 0)
                {
                    for (i = gemi.x1; i <= gemi.x2; i++)
                    {
                        for (j = gemi.y1; j <= gemi.y2; j++)
                        {
                            for (k = 0; k < 8; k++)
                            {
                                int x = i + yatay[k];
                                int y = j + dikey[k];
                                if (x >= 0 && x < 15 && y >= 0 && y < 15 && butonlar[x, y].BackgroundImage == null)
                                {
                                    butonlar[x, y].BackgroundImage = Properties.Resources.boş;
                                    butonlar[x, y].BackgroundImageLayout = ImageLayout.Stretch;
                                    butonlar[x, y].Enabled = false;
                                }
                            }
                        }
                    }
                    SoundPlayer efekt = new SoundPlayer(Properties.Resources.vuruldu);
                    SesCal(efekt);
                    Gemiler.Remove(gemi);
                    break;
                }
            }
        }

        private void Hamle(object sender, EventArgs e)
        {
            hamleSayisi++;
            label1.Text = "Hamle sayısı:" + hamleSayisi.ToString();
            Button tiklanan = (Button)sender;
            if (tiklanan.Tag != null && tiklanan.Tag.ToString() == "gemi")
            {
                tiklanan.Tag = null;
                tiklanan.BackgroundImage = Properties.Resources.gemi;
                tiklanan.BackgroundImageLayout = ImageLayout.Stretch;
                tiklanan.Enabled = false;
                SoundPlayer efekt = new SoundPlayer(Properties.Resources.isabet);
                SesCal(efekt);
                GemiVuruldu();
            }
            else
            {
                tiklanan.Enabled = false;
                tiklanan.BackgroundImage = Properties.Resources.boş;
                tiklanan.BackgroundImageLayout = ImageLayout.Stretch;
                SoundPlayer efekt = new SoundPlayer(Properties.Resources.ıska);
                SesCal(efekt);
            }
            if (Gemiler.Count == 0)
            {
                timer1.Stop();
                if (enİyiHamle == 0 || enİyiHamle > hamleSayisi)
                    enİyiHamle = hamleSayisi;
                if (enİyiDakika == -1 || enİyiDakika > dakika || (enİyiDakika == dakika && enİyiSaniye > saniye))
                {
                    enİyiDakika = dakika;
                    enİyiSaniye = saniye;
                }
                SoundPlayer efekt = new SoundPlayer(Properties.Resources.zafer);
                SesCal(efekt);
                Form3 Son = new Form3(hamleSayisi, enİyiHamle, dakika, enİyiDakika, saniye, enİyiSaniye);
                Son.Location = this.Location;
                Son.Show();
                this.Hide();
                Son.FormClosed+=SonKapandi;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (saniye == 60)
            {
                dakika++;
                saniye = 0;
            }
            label2.Text = "Süre: " + dakika.ToString("00") + ":" + saniye.ToString("00");
        }

        private void SonKapandi(object sender, FormClosedEventArgs e)
        {
            this.Show();
            OyunKur();
        }

        private void SesCal(SoundPlayer Ses)
        {
            if (sesAcik == 1)
                Ses.Play();
        }
    }
}
using System;
using System.Windows.Forms;

namespace TasKagitMakasOyunu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        int bilgisayarPuan = 0;
        int oyuncuPuan = 0;

        private void btnOyna_Click(object sender, EventArgs e)
        {
            /* 
            Taş-kâğıt-makas, genellikle iki oyuncuyla ve üç durumdan birinin seçilmesiyle oynanan bir el oyunudur. 
            Taş makası, makas kağıdı, kâğıt da taşı yener. 
            Eğer oyuncular aynı durumu seçerse oyun berabere biter. 
             */

            string[] secim = { "Taş", "Kağıt", "Makas" };
            //Random oyuncu = new Random();
            Random bilgisayar = new Random();
            //var oyuncuRandom =  oyuncu.Next(0, secim.Length);
            var bilgisayarRandom = bilgisayar.Next(0, secim.Length);
            //var oyuncuSecim = secim[oyuncuRandom];
            var bilgisayarSecim = secim[bilgisayarRandom];

            var oyuncuSecim = string.Empty;

            if (rdTas.Checked)
            {
                oyuncuSecim = rdTas.Text;
            }

            else if (rdKagit.Checked)
            {
                oyuncuSecim = rdKagit.Text;
            }
            else if (rdMakas.Checked)
            {
                oyuncuSecim = rdMakas.Text;
            }
            else
            {
                MessageBox.Show(@"Lütfen seçim yapınız");
                return;
            }

            MessageBox.Show(string.Concat("Oyuncunun Seçimi= ", oyuncuSecim, " Bilgisayarın Seçimi= ", bilgisayarSecim));

            if (oyuncuSecim == bilgisayarSecim)
            {
                bilgisayarPuan += 1;
                oyuncuPuan += 1;
                lblPuan.Text = oyuncuPuan.ToString();
                MessageBox.Show(string.Concat("Berabere Bitti Oyuncunun Puanı= ", oyuncuPuan.ToString(), " Bilgisayarın Puanı= ", bilgisayarPuan.ToString()));
            }
            else
            {
                if (oyuncuSecim == secim[0] && bilgisayarSecim == secim[2])
                {
                    MessageBox.Show(@"Oyuncu Kazandı");
                    oyuncuPuan += 1;
                }

                else if (bilgisayarSecim == secim[0] && oyuncuSecim == secim[2])
                {
                    MessageBox.Show(@"Bilgisayar Kazandı");
                    bilgisayarPuan += 1;
                }

                else if (oyuncuSecim == secim[2] && bilgisayarSecim == secim[1])
                {
                    MessageBox.Show(@"Oyuncu Kazandı");
                    oyuncuPuan += 1;
                }

                else if (bilgisayarSecim == secim[2] && oyuncuSecim == secim[1])
                {
                    MessageBox.Show(@"Bilgisayar Kazandı");
                    bilgisayarPuan += 1;
                }

                else if (oyuncuSecim == secim[1] && bilgisayarSecim == secim[0])
                {
                    MessageBox.Show(@"Oyuncu Kazandı");
                    oyuncuPuan += 1;
                }

                else if (bilgisayarSecim == secim[1] && oyuncuSecim == secim[0])
                {
                    MessageBox.Show(@"Bilgisayar Kazandı");
                    bilgisayarPuan += 1;
                }
                else
                {
                    MessageBox.Show(@"Seçimde bir sorun var lütfen sistem yöneticisine durumu belirtin");
                }

                lblPuan.Text = oyuncuPuan.ToString();
                MessageBox.Show(string.Concat("Oyuncunun Puanı= ", oyuncuPuan.ToString(), " Bilgisayarın Puanı= ", bilgisayarPuan.ToString()));

            }

        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            OyunBitti();
        }

        private void OyunBitti()
        {
            MessageBox.Show($@"Oyuncunun Puanı= {oyuncuPuan.ToString()} Bilgisayarın Puanı=  {bilgisayarPuan.ToString()}");
            //MessageBox.Show(string.Format(@"Oyuncu Puanı = {0} Bilgisayar Puanı = {1}", oyuncuPuan.ToString(), bilgisayarPuan.ToString()));
            bilgisayarPuan = 0;
            oyuncuPuan = 0;
            lblPuan.Text = oyuncuPuan.ToString();
            MessageBox.Show(@"Oyun Puanları 0 landı");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

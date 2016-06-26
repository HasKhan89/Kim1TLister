using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kim1TLister
{
    public partial class Form1 : Form
    {
        //ArrayList sorular = new ArrayList();
        List<Soru> Sorular = new List<Soru>();
        List<Cevap> SinavCevaplar = new List<Cevap>();

        int Sayac = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void soruHazırlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpSoruHazirla.Enabled = true;
            grpSinav.Enabled = false;
            mnuSoruHazirlaBitir.Enabled = true;
            mnuSoruHazirla.Enabled = false;
            mnuSinavBasla.Enabled = false;

            Temizle();
        }

        private void mnuSoruHazirlaBitir_Click(object sender, EventArgs e)
        {
            grpSoruHazirla.Enabled = false;
            mnuSinavBasla.Enabled = true;
            mnuSoruHazirla.Enabled = true;
            mnuSoruHazirlaBitir.Enabled = false;

            Temizle();
        }

        private void mnuSinavBasla_Click(object sender, EventArgs e)
        {
            grpSinav.Enabled = true;
            mnuSoruHazirla.Enabled = false;
            mnuSinavBasla.Enabled = false;
            btnSonraki.Visible = true;

            Sayac = 0;
            SinavCevaplar.Clear();

            for (int i = 0; i < Sorular.Count; i++)
            {
                Cevap cevap = new Cevap();
                cevap.Index = i;
                cevap.SoruCevap = "";

                SinavCevaplar.Add(cevap);
            }

            if (Sorular.Count > 0)
            {
                SiradakiSoruyuVer();
            }
            else
            {
                MessageBox.Show("Sınav yapılacak soru tanımlanmamıştır.");
            }

        }

        private void SiradakiSoruyuVer()
        {
            Soru soru = Sorular[Sayac];

            lblSoru.Text = soru.SinavSorusu;
            rbCevapA1.Text = soru.CevapA;
            rbCevapB1.Text = soru.CevapB;
            rbCevapC1.Text = soru.CevapC;
            rbCevapD1.Text = soru.CevapD;

            Sayac++;

            if (Sayac >= Sorular.Count)
            {
                btnSonraki.Visible = false;
            }
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            mnuSinavBasla.Enabled = true;
            mnuSoruHazirla.Enabled = true;
            grpSinav.Enabled = false;

            // Son sorunun cevabını burada kaydetmemiz gerekiyor.
            // Çünkü sonraki butonu gizlenmiş durumda..

            Cevap cevap = SinavCevaplar[Sayac - 1];

            foreach (Control control in grpSinav.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton rdb = (RadioButton)control;

                    if (rdb.Checked)
                    {
                        cevap.SoruCevap = rdb.Tag.ToString();

                        // Kullanıcının verdiği cevabı aldık, 
                        // diğer kontrollerde dönmeye gerek yok artık..
                        break;
                    }
                }
            }

            SinavTemizle();

            SonuclariHesapla();

        }

        private void SonuclariHesapla()
        {
            int dogruSayisi = 0;
            int yanlisSayisi = 0;
            int bosSayisi = 0;

            foreach (Soru soru in Sorular)
            {
                int index = Sorular.IndexOf(soru);
                Cevap cevap = SinavCevaplar[index];

                // doğru cevabı bilmiş.
                if(soru.DogruCevap == cevap.SoruCevap)
                {
                    dogruSayisi++;
                }

                // Boş geçmiş..
                if (cevap.SoruCevap == "")
                {
                    bosSayisi++;
                }

                // Bir cevabı var ama doğru değil.
                if (cevap.SoruCevap != "" && cevap.SoruCevap != soru.DogruCevap)
                {
                    yanlisSayisi++;
                }
            }

            MessageBox.Show(
                "Doğru Cevap Sayısı : " + dogruSayisi.ToString() + "\n" +
                "Yanlış Cevap Sayısı : " + yanlisSayisi.ToString() + "\n" +
                "Boş Cevap Sayısı : " + bosSayisi.ToString());
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Soru soru = new Soru();
            soru.SinavSorusu = txtSoru.Text;
            soru.CevapA = txtCevapA.Text;
            soru.CevapB = txtCevapB.Text;
            soru.CevapC = txtCevapC.Text;
            soru.CevapD = txtCevapD.Text;

            //if(rbCevapA.Checked)
            //{
            //    soru.DogruCevap = "A";
            //}
            //else if (rbCevapB.Checked)
            //{
            //    soru.DogruCevap = "B";
            //}
            //else if (rbCevapC.Checked)
            //{
            //    soru.DogruCevap = "C";
            //}
            //else
            //{
            //    soru.DogruCevap = "D";
            //}

            foreach (Control control in grpSoruHazirla.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton rdb = (RadioButton)control;

                    // RadioButton Checked ise; soru.DogruCevap değerini 
                    // radioButton'un text inden al.
                    // Sonra foreach'den çık(break).
                    if (rdb.Checked)
                    {
                        soru.DogruCevap = rdb.Text;
                        break;
                    }
                }
            }

            Sorular.Add(soru);

            Temizle();
            Listele();
        }

        private void Listele()
        {
            lstSorular.Items.Clear();

            // Listbox'da soruların SinavSorusu kısmı listelenir.
            foreach (Soru s in Sorular)
            {
                lstSorular.Items.Add(s.SinavSorusu);
            }
        }

        private void Temizle()
        {
            // grpSoruHazirla içindeki tüm kontrollerde dön.. 
            foreach (Control control in grpSoruHazirla.Controls)
            {
                // O anki kontrol textbox tipinde ise..
                if (control is TextBox)
                {
                    // Kontrol değişkenindeki nesneyi Textbox tipine çevir ki;
                    // textbox özelliklerine erişebileyim.
                    TextBox txt = (TextBox)control;
                    txt.Clear();
                }

                if (control is RadioButton)
                {
                    // Kontrol değişkenindeki nesneyi RadioButton tipine çevir ki;
                    // RadioButton özelliklerine erişebileyim.
                    RadioButton rdb = (RadioButton)control;
                    rdb.Checked = false;
                }
            }

            rbCevapA.Checked = true;
            txtSoru.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            int index = lstSorular.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Lütfen bir soru seçiniz.");
                return;
            }

            Soru soru = Sorular[index];

            soru.SinavSorusu = txtSoru.Text;
            soru.CevapA = txtCevapA.Text;
            soru.CevapB = txtCevapB.Text;
            soru.CevapC = txtCevapC.Text;
            soru.CevapD = txtCevapD.Text;

            foreach (Control control in grpSoruHazirla.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton rdb = (RadioButton)control;

                    // RadioButton Checked ise; soru.DogruCevap değerini 
                    // radioButton'un text inden al.
                    // Sonra foreach'den çık(break).
                    if (rdb.Checked)
                    {
                        soru.DogruCevap = rdb.Text;
                        break;
                    }
                }
            }

            Temizle();
            Listele();
        }

        private void lstSorular_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstSorular.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Lütfen bir soru seçiniz.");
                return;
            }

            Soru soru = Sorular[index];

            txtSoru.Text = soru.SinavSorusu;
            txtCevapA.Text = soru.CevapA;
            txtCevapB.Text = soru.CevapB;
            txtCevapC.Text = soru.CevapC;
            txtCevapD.Text = soru.CevapD;

            foreach (Control control in grpSoruHazirla.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton rdb = (RadioButton)control;

                    if (rdb.Text == soru.DogruCevap)
                    {
                        rdb.Checked = true;
                    }
                    else
                    {
                        rdb.Checked = false;
                    }
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int index = lstSorular.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Lütfen bir soru seçiniz.");
                return;
            }

            Sorular.RemoveAt(index);

            Temizle();
            Listele();
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            Cevap cevap = SinavCevaplar[Sayac - 1];

            foreach (Control control in grpSinav.Controls)
            {
                if(control is RadioButton)
                {
                    RadioButton rdb = (RadioButton)control;

                    if(rdb.Checked)
                    {
                        cevap.SoruCevap = rdb.Tag.ToString();

                        // Kullanıcının verdiği cevabı aldık, 
                        // diğer kontrollerde dönmeye gerek yok artık..
                        break; 
                    }
                }
            }

            SinavTemizle();
            SiradakiSoruyuVer();
        }

        private void SinavTemizle()
        {
            lblSoru.Text = "";
            rbCevapA1.Text = "";
            rbCevapB1.Text = "";
            rbCevapC1.Text = "";
            rbCevapD1.Text = "";

            rbCevapA1.Checked = false;
            rbCevapB1.Checked = false;
            rbCevapC1.Checked = false;
            rbCevapD1.Checked = false;
        }

        private void mnuKaydet_Click(object sender, EventArgs e)
        {
            string[] yazilacaklar = new string[Sorular.Count];

            for (int i = 0; i < Sorular.Count; i++)
            {
                Soru soru = Sorular[i];

                yazilacaklar[i] =
                    string.Format("{0}|{1}|{2}|{3}|{4}|{5}",
                        soru.SinavSorusu, soru.CevapA, soru.CevapB, soru.CevapC, soru.CevapD, soru.DogruCevap);
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Kaydet";
            sfd.Filter = "Metin Dosyası(*.txt)|*.txt";
            sfd.FilterIndex = 1;
            sfd.FileName = "sorular.txt";
            sfd.RestoreDirectory = true;    // son açtığı klasör konumunu saklar.
            // Varsayılan olarak Masaüstü konumu açık gelir.
            sfd.InitialDirectory = 
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //DialogResult secim = sfd.ShowDialog();

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllLines(sfd.FileName, yazilacaklar);

                MessageBox.Show("Sorular kaydedilmiştir..");
            }
        }

        private void mnuAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Aç";
            ofd.Filter = "Metin Dosyası(*.txt)|*.txt";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;    // son açtığı klasör konumunu saklar.

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string[] okunanlar = System.IO.File.ReadAllLines(ofd.FileName);

                Sorular.Clear();

                foreach (string okunan in okunanlar)
                {
                    string[] soruIfadeleri = okunan.Split('|');

                    Soru soru = new Soru();
                    soru.SinavSorusu = soruIfadeleri[0];
                    soru.CevapA = soruIfadeleri[1];
                    soru.CevapB = soruIfadeleri[2];
                    soru.CevapC = soruIfadeleri[3];
                    soru.CevapD = soruIfadeleri[4];
                    soru.DogruCevap = soruIfadeleri[5];

                    Sorular.Add(soru);
                }

                mnuSinavBasla.Enabled = true;

                Temizle();
                Listele();
            }
        }

        private void mnuCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

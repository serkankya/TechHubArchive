using System;
using System.Drawing;
using System.Windows.Forms;

namespace techHub1._1
{
    public partial class frmNGS : Form
    {
        public frmNGS()
        {
            InitializeComponent();
        }

        // frmNGS formu yüklendiğinde gerçekleşen olay işleyicisi.
        private void frmNGS_Load(object sender, EventArgs e)
        {
            // Boş metot, şu anda bir şey yapmıyor.
        }

        // Sonuç düğmesine tıklandığında gerçekleşen olay işleyicisi.
        private void btnSonuc_Click(object sender, EventArgs e)
        {
            // Öğrenci adı ve soyadı girilmişse
            if (!string.IsNullOrEmpty(txtOgrenci.Text))
            {
                // Formun boyutunu genişletir, notları hesaplar ve girdileri temizler.
                this.Size = new Size(816, 424);
                hesapla();
                clear();
            }
            else
                // Öğrenci adı ve soyadı girilmemişse hata mesajı gösterir.
                MessageBox.Show("Lütfen öğrenci adı ve soyadını giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Not hesaplama metodunu gerçekleştirir.
        string harfNotu;
        private void hesapla()
        {
            // Notları ağırlıklarına göre hesaplar.
            double sonuc = (Convert.ToDouble(numBir.Value) * 0.15) +
                           (Convert.ToDouble(numIki.Value) * 0.15) +
                           (Convert.ToDouble(numUc.Value) * 0.15) +
                           (Convert.ToDouble(numDort.Value) * 0.15) +
                           (Convert.ToDouble(numBes.Value) * 0.40);

            // Hesaplanan sonuca göre harf notunu belirler.
            if (sonuc >= 0 && sonuc < 50)
                harfNotu = "FF";
            else if (sonuc >= 50 && sonuc < 60)
                harfNotu = "DD";
            else if (sonuc >= 60 && sonuc < 70)
                harfNotu = "CC";
            else if (sonuc >= 70 && sonuc < 85)
                harfNotu = "BB";
            else if (sonuc >= 85 && sonuc <= 100)
                harfNotu = "AA";

            // Sonuçları listeye ekler.
            lbSonuclar.Items.Add(txtOgrenci.Text + " / " + sonuc.ToString() + " / " + harfNotu);
        }

        // Girdileri temizleyen metod.
        void clear()
        {
            // Sayısal girişleri temizler.
            foreach (Control item in grpNotGiris.Controls)
            {
                if (item is NumericUpDown)
                {
                    NumericUpDown numericUpDown = (NumericUpDown)item;
                    item.Text = "0";
                }
            }
            // Öğrenci adı ve soyadını temizler.
            txtOgrenci.Text = string.Empty;
        }

        // İptal düğmesine tıklandığında gerçekleşen olay işleyicisi.
        private void btnIptal_Click(object sender, EventArgs e)
        {
            // Girdileri temizler.
            clear();
        }

        // Ana menüye dön düğmesine tıklandığında gerçekleşen olay işleyicisi.
        private void btnMain_Click(object sender, EventArgs e)
        {
            // Ana forma döner.
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }
    }
}

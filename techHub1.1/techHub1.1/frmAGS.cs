using System;
using System.Collections;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace techHub1._1
{
    public partial class frmAGS : Form
    {
        // Sınıf bilgilerini tutan bir ArrayList.
        public ArrayList classInfos = new ArrayList();

        public frmAGS()
        {
            InitializeComponent();
        }

        // Sınıf seviyelerindeki öğrenci sayılarını hesaplar ve grafik ve etiketler üzerine yerleştirir.
        int bir = 0, iki = 0, uc = 0, dort = 0;

        // Ana menüye dön düğmesine tıklandığında gerçekleşen olay işleyicisi.
        private void btnMain_Click(object sender, EventArgs e)
        {
            // Uygulamadan çıkar.
            Application.Exit();
        }

        // Çıkış düğmesine tıklandığında gerçekleşen olay işleyicisi.
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Ana forma döner.
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }

        // frmAGS formu yüklendiğinde gerçekleşen olay işleyicisi.
        private void frmAGS_Load(object sender, EventArgs e)
        {
            // Sınıf seviyelerindeki öğrenci sayılarını hesaplar.
            foreach (int item in classInfos)
            {
                if (item == 1)
                    bir++;
                else if (item == 2)
                    iki++;
                else if (item == 3)
                    uc++;
                else if (item == 4)
                    dort++;
            }

            // Grafik alanını temizler ve verileri ekler.
            chart1.Series.Clear();
            chart1.Series.Add("Öğrenci Sayısı");
            chart1.Series["Öğrenci Sayısı"].ChartType = SeriesChartType.Column;
            chart1.Series["Öğrenci Sayısı"].Points.AddXY("1. Sınıf", bir);
            chart1.Series["Öğrenci Sayısı"].Points.AddXY("2. Sınıf", iki);
            chart1.Series["Öğrenci Sayısı"].Points.AddXY("3. Sınıf", uc);
            chart1.Series["Öğrenci Sayısı"].Points.AddXY("4. Sınıf", dort);

            // Toplam öğrenci sayısını hesaplar.
            int toplam = bir + iki + uc + dort;

            // Etiketlerde sınıf seviyelerinin yüzdelik dilimlerini gösterir.
            lbl1.Text = "1. Sınıfların toplam öğrenci içerisindeki yüzdesi : " + ((bir / (double)toplam) * 100).ToString("F2") + "%";
            lbl2.Text = "2. Sınıfların toplam öğrenci içerisindeki yüzdesi : " + ((iki / (double)toplam) * 100).ToString("F2") + "%";
            lbl3.Text = "3. Sınıfların toplam öğrenci içerisindeki yüzdesi : " + ((uc / (double)toplam) * 100).ToString("F2") + "%";
            lbl4.Text = "4. Sınıfların toplam öğrenci içerisindeki yüzdesi : " + ((dort / (double)toplam) * 100).ToString("F2") + "%";
        }
    }
}

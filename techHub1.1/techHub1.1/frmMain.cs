using System;
using System.Windows.Forms;

namespace techHub1._1
{
    public partial class frmMain : Form
    {
        // Kullanıcı adını tutan bir değişken.
        public string k_Adi;

        public frmMain()
        {
            InitializeComponent();
        }

        // frmMain formu yüklendiğinde gerçekleşen olay işleyicisi.
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Kullanıcı adını hoş geldin etiketi üzerine yerleştirir.
            lblUser.Text = "Hoş geldin, " + k_Adi;

            // Zamanı göstermek için zamanlayıcıyı başlatır.
            timer1.Start();
        }

        // Zamanlayıcı etkin olduğunda gerçekleşen olay işleyicisi.
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Etikete geçerli zamanı yerleştirir.
            lblDate.Text = DateTime.Now.ToString("F");
        }

        // Öğrenci bilgi düğmesine tıklandığında gerçekleşen olay işleyicisi.
        private void btnOgrBilgi_Click(object sender, EventArgs e)
        {
            // Öğrenci bilgi formunu başlatır ve mevcut formu gizler.
            frmOBS obs = new frmOBS();
            obs.Show();
            this.Hide();
        }

        // Not bilgi düğmesine tıklandığında gerçekleşen olay işleyicisi.
        private void btnNotBilgi_Click(object sender, EventArgs e)
        {
            // Not bilgi formunu başlatır ve mevcut formu gizler.
            frmNGS ngs = new frmNGS();
            ngs.Show();
            this.Hide();
        }

        // Güvenli çıkış düğmesine tıklandığında gerçekleşen olay işleyicisi.
        private void btnSafeExit_Click(object sender, EventArgs e)
        {
            // Kullanıcıya çıkış yapılacağına dair bilgi verir.
            MessageBox.Show("Çıkış yapılıyor...", "Güvenli Çıkış", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Uygulamadan çıkar.
            Application.Exit();
        }
    }
}

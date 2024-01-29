using System;
using System.Drawing;
using System.Windows.Forms;

namespace techHub1._1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        // Form yüklendiğinde gerçekleşen olay işleyicisi.
        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Form'un maksimum ve minimum boyutlarını ayarlar.
            this.MaximumSize = new System.Drawing.Size(483, 241);
            this.MinimumSize = new System.Drawing.Size(483, 241);

            // txtPassword kontrolünün karakterini gizler.
            txtPassword.PasswordChar = '*';
        }

        // Kullanıcı adı metin kutusu odak kazandığında gerçekleşen olay işleyicisi.
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            // Metin kutusunun arka plan rengini değiştirir.
            TextBox t = (TextBox)sender;
            t.BackColor = Color.Yellow;
        }

        // Kullanıcı adı metin kutusu odaktan çıktığında gerçekleşen olay işleyicisi.
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            // Metin kutusunun arka plan rengini değiştirir.
            TextBox t = (TextBox)sender;
            t.BackColor = Color.FromArgb(252, 227, 255);
        }

        // Deneme hakkı sayacı.
        int denemeHakki = 3;

        // Giriş düğmesine tıklandığında gerçekleşen olay işleyicisi.
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre boş değilse
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                // Kullanıcı adı ve şifre doğruysa
                if (txtUsername.Text == "deneme" && txtPassword.Text == "12345")
                {
                    // Hoş geldin ile bir mesaj kutusu gösterir.
                    MessageBox.Show("Hoş geldiniz, " + txtUsername.Text + ".", "Yükleniyor", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Ana formu başlatır ve kullanıcı adını aktarır.
                    frmMain main = new frmMain();
                    main.k_Adi = txtUsername.Text;
                    main.Show();
                    this.Hide(); // Giriş formunu gizler.
                }
                else
                {
                    // Hatalı kullanıcı adı veya şifre durumunda
                    denemeHakki--; // Deneme hakkı sayacını azaltır.
                    if (denemeHakki == 0)
                    {
                        // Deneme hakkı bittiğinde uygulamadan çıkar.
                        MessageBox.Show("Hatalı kullanıcı adı veya şifre.\nGiriş hakkınız dolmuştur. Uygulamadan çıkış yapılıyor...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    else
                    {
                        // Kullanıcı adı veya şifre hatalıysa ve deneme hakkı varsa
                        MessageBox.Show("Hatalı kullanıcı adı veya şifre. Lütfen tekrar deneyin.\nKalan Deneme Hakkı : " + denemeHakki.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Text = string.Empty; // Şifre kutusunu temizler.
                    }
                }
            }
            else
                // Kullanıcı adı veya şifre boşsa
                MessageBox.Show("Lütfen kullanıcı adı ve şifrenizi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // İptal düğmesine tıklandığında gerçekleşen olay işleyicisi.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Uygulamadan çıkar.
            Application.Exit();
        }

        // Göster/Gizle simgesine tıklandığında gerçekleşen olay işleyicisi.
        bool clicked = false;
        private void picHide_Click(object sender, EventArgs e)
        {
            // clicked değişkenini tersine çevirir.
            if (clicked == false)
                clicked = true;
            else
                clicked = false;

            // Şifre kutusunu göster veya gizler.
            if (clicked)
                txtPassword.PasswordChar = '\0'; // Karakterleri gösterir.
            else
                txtPassword.PasswordChar = '*'; // Karakterleri gizler.
        }
    }
}

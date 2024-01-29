using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace techHub1._1
{
    public partial class frmOBS : Form
    {
        public frmOBS()
        {
            InitializeComponent();
        }

        // Form yüklendiğinde gerçekleşen olay işleyicisi
        private void frmOBS_Load(object sender, EventArgs e)
        {
            // Formun boyutunu ve diğer bileşenleri başlatır
            this.Size = new Size(440, 427);
            lstStudents.HorizontalScrollbar = true;
            txtNo.Enabled = false;
        }

        // Öğrenci bilgilerini tutan ArrayList'ler
        ArrayList studentInfo = new ArrayList();
        ArrayList classInfo = new ArrayList();
        // Sınıf ve cinsiyet bilgileri
        int sClass, checkedClass = 0, checkedGender = 0;
        string gender;

        // "Öğrenci Ekle" butonuna tıklandığında gerçekleşen olay işleyicisi
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Gerekli alanların dolu olup olmadığını kontrol eder
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtSurname.Text) && !string.IsNullOrEmpty(txtNo.Text))
            {
                // Seçilen sınıfı belirler
                if (rb1.Checked)
                {
                    sClass = 1;
                    checkedClass = 1;
                }
                else if (rb2.Checked)
                {
                    sClass = 2;
                    checkedClass = 1;
                }
                else if (rb3.Checked)
                {
                    sClass = 3;
                    checkedClass = 1;
                }
                else if (rb4.Checked)
                {
                    sClass = 4;
                    checkedClass = 1;
                }

                // Seçilen cinsiyeti belirler
                if (rbKiz.Checked)
                {
                    gender = "Kız";
                    checkedGender = 1;
                }
                else if (rbErkek.Checked)
                {
                    gender = "Erkek";
                    checkedGender = 1;
                }

                // Gerekli alanların doldurulup doldurulmadığını kontrol eder
                if (checkedGender != 0 && checkedClass != 0)
                {
                    // Kullanıcıya öğrenci kaydını onaylayıp onaylamadığını sorar
                    DialogResult add = MessageBox.Show(txtName.Text + " " + txtSurname.Text + " isimli öğrencinin kaydını onaylıyor musunuz ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (add == DialogResult.Yes)
                    {
                        // Öğrenci bilgilerini ArrayList'e ekler
                        studentInfo.Add(txtName.Text + " " + txtSurname.Text + " - " + txtNo.Text + " - " + gender + " - " + sClass.ToString() + ". Sınıf");
                        classInfo.Add(sClass);

                        // Öğrenci listesini günceller
                        lstStudents.Items.Clear();
                        this.Size = new Size(817, 427); // Form boyutunu günceller

                        foreach (var item in studentInfo)
                        {
                            lstStudents.Items.Add(item);
                        }

                        clearAll(); // Alanları temizler
                        MessageBox.Show("Öğrenci başarı ile kaydedildi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt iptal edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                    MessageBox.Show("Lütfen ilgili yerleri doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Lütfen ilgili yerleri doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // "Grafikler" butonuna tıklandığında gerçekleşen olay işleyicisi
        private void btnGraphics_Click(object sender, EventArgs e)
        {
            // frmAGS formunu başlatır ve mevcut formu gizler
            frmAGS ags = new frmAGS();
            ags.classInfos = classInfo;
            ags.Show();
            this.Hide();
        }

        // "İptal" butonuna tıklandığında gerçekleşen olay işleyicisi
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // frmMain formunu başlatır, kullanıcıya bilgi verir ve mevcut formu gizler
            frmMain main = new frmMain();
            MessageBox.Show("İşlem iptal edildi. Ana sayfaya dönülüyor.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            main.Show();
            this.Hide();
        }

        // Alanları temizleyen metod
        private void clearAll()
        {
            // TextBox bileşenlerini temizler
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
            }

            // Sınıf seçeneklerini temizler
            foreach (Control item in grpBoxClasses.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton radioButton = item as RadioButton;
                    radioButton.Checked = false;
                }
            }

            // Cinsiyet seçeneklerini temizler
            foreach (Control item in grpBoxGender.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton radioButton = item as RadioButton;
                    radioButton.Checked = false;
                }
            }
            txtName.Text = string.Empty; 
            txtNo.Text = string.Empty;
            txtSurname.Text = string.Empty;
        }

        // "Öğrenci Numarası Üret" butonuna tıklandığında gerçekleşen olay işleyicisi
        private void btnGenerator_Click(object sender, EventArgs e)
        {
            //NumberGenerator adlı classımızdan veri çeker
            // Öğrenci numarasını oluşturur ve TextBox'a yerleştirir
            string studentNo = NumberGenerator.Create();
            txtNo.Text = studentNo;
        }
    }
}

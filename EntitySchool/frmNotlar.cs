using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitySchool
{
    public partial class frmNotlar : Form
    {
        public frmNotlar()
        {
            InitializeComponent();
        }
        DbSınavOgrenciEntities db = new DbSınavOgrenciEntities();
        public void TemizleNot()
        {
            txtSınav1.Clear();
            txtSınav2.Clear();
            txtSınav3.Clear();
            txtSınavOrt.Clear();
            txtDurum.Clear();
        }
        public void NotListele()
        {
            try
            {
                //linq sorgusu oluşturucam                    //item ın bağlı olduğu tabloya ait prop ları karşıma çıkarıyor.
                var query = from item in db.TblNotlar
                            select new
                            {
                                item.NotId,
                                item.TblOgrenci.Ad,
                                item.TblOgrenci.Soyad,
                                item.Ders,
                                item.Sınav1,
                                item.Sınav2,
                                item.Sınav3,
                                item.Ortalama,
                                item.Durum
                            };
                dataGridView1.DataSource = query.ToList(); //queryden gelen isteği bana liste şeklinde yazdır > ve datagridview in datasourceuna aktarır.
                                                           //dataGridView1.DataSource = db.TblNotlar.ToList();
            }
            catch (SqlException ex)
            {
                // Veritabanı bağlantı hataları için özel işleme
                Console.WriteLine("Veritabanı hatası: " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                // Null değer referansı için özel işleme
                Console.WriteLine("Boş bir değer referansı hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Diğer genel hatalar için
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }
        }
        private void btnNotListesi_Click(object sender, EventArgs e)
        {
            NotListele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSınav1.Text) && !string.IsNullOrWhiteSpace(txtSınav2.Text) && !string.IsNullOrWhiteSpace(txtSınav3.Text))
            {
                TblNotlar not = new TblNotlar();
                not.Sınav1 = short.Parse(txtSınav1.Text);
                not.Sınav2 = short.Parse(txtSınav2.Text);
                not.Sınav3 = short.Parse(txtSınav3.Text);
                db.TblNotlar.Add(not); // add mmetodunun içine ürettiğin entity i yaz > ogrenci nesnesi
                db.SaveChanges();
                MessageBox.Show("Notlar eklendi.","BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NotListele();
            }
        }

        private void frmNotlar_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtSınav1.Text) && !string.IsNullOrWhiteSpace(txtSınav2.Text) && !string.IsNullOrWhiteSpace(txtSınav3.Text))
                {
                    // Güncellenecek Not ID'sini al
                    int id = int.Parse(txtNotID.Text);
                    // Veritabanından Not kaydını bul
                    var not = db.TblNotlar.Find(id);
                    not.Sınav1 = short.Parse(txtSınav1.Text);
                    not.Sınav2 = short.Parse(txtSınav2.Text);
                    not.Sınav3 = short.Parse(txtSınav3.Text);
                    db.SaveChanges();
                        MessageBox.Show("Not Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NotListele();
                }
            }
            catch (SqlException ex)
            {
                // Veritabanı bağlantı hataları için özel işleme
                Console.WriteLine("Veritabanı hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Diğer genel hatalar için
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtNotID.Text))
                {
                    int id = int.Parse(txtNotID.Text);
                    //silmek / güncellemek / görüntülemek istediğimiz Id yi hafızada tutmak için : 
                    var x = db.TblNotlar.Find(id);
                    db.TblNotlar.Remove(x);
                    db.SaveChanges();
                    MessageBox.Show("Not Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NotListele();
                }
            }
            catch (SqlException ex)
            {
                // Veritabanı bağlantı hataları için özel işleme
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA : " + ex.Message);
            }
        }

        private void btnProcedure_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = db.NotListesi(); //prosedürü çağırıp uzun sql sorguları yerine sadece prosedür metodunu/nesnesini çağırdım
            }
            catch (SqlException ex)
            {
                // Veritabanı bağlantı hataları için özel işleme
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA : " + ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Seçilen satırı al
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Veritabanındaki sütun adlarına göre verileri TextBox'lara ata
                    txtNotID.Text = selectedRow.Cells["NotId"].Value.ToString(); // "Id" sütun adı
                    txtSınav1.Text = selectedRow.Cells["Sınav1"].Value.ToString(); // "Sınav1" sütun adı
                    txtSınav2.Text = selectedRow.Cells["Sınav2"].Value.ToString(); // "Sınav2" sütun adı
                    txtSınav3.Text = selectedRow.Cells["Sınav3"].Value.ToString(); // "Sınav3" sütun adı
                }
            }
            catch (SqlException ex)
            {
                // Veritabanı bağlantı hataları için özel işleme
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA : " + ex.Message);
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                double ortalama = (int.Parse(txtSınav1.Text) * 30 / 100) + (int.Parse(txtSınav2.Text) * 30 / 100) + (int.Parse(txtSınav3.Text) * 30 / 100);
                if (ortalama >= 40)
                {
                    txtSınavOrt.Text = ortalama.ToString();
                    txtDurum.Text = "Geçti";
                    // Güncellenecek Not ID'sini al
                    int id = int.Parse(txtNotID.Text);
                    // Veritabanından Not kaydını bul
                    var not = db.TblNotlar.Find(id);
                    not.Durum = true;
                    not.Ortalama = decimal.Parse(txtSınavOrt.Text);
                    db.SaveChanges();
                    NotListele();
                }
                else
                {
                    txtSınavOrt.Text = ortalama.ToString();
                    txtDurum.Text = "Kaldı";
                    // Güncellenecek Not ID'sini al
                    int id = int.Parse(txtNotID.Text);
                    // Veritabanından Not kaydını bul
                    var not = db.TblNotlar.Find(id);
                    not.Durum = false;
                    not.Ortalama = decimal.Parse(txtSınavOrt.Text);
                    db.SaveChanges();
                    NotListele();

                }
            }
            catch (SqlException ex)
            {
                // Veritabanı bağlantı hataları için özel işleme
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA : " + ex.Message);
            }
        }

        private void btnTemizleSınav_Click(object sender, EventArgs e)
        {
            txtDurum.Clear();
            txtNotID.Clear();
            txtSınav1.Clear();
            txtSınav2.Clear();
            txtSınav3.Clear();
            txtSınavOrt.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitySchool
{
    public partial class frmOgrenci : Form
    {
        public frmOgrenci()
        {
            InitializeComponent();
        }
        DbSınavOgrenciEntities db = new DbSınavOgrenciEntities();
        public void OgrenciListele()
        {
            try
            {
                dgvOgrenci.DataSource = db.TblOgrenci.ToList(); //tblOgrenci ye ait tüm verileri listele
                dgvOgrenci.Columns[3].Visible = false;
                dgvOgrenci.Columns[4].Visible = false;

            }
            catch (EntityException ex)
            {
                Console.WriteLine("HATA : " + ex);
                throw;
            }
        }
        public void TemizleOgr()
        {
            txtOgrenciId.Clear();
            txtOgrenciAd.Clear();
            txtOgrenciSoyad.Clear();
        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtOgrenciId.Text))
                {
                    // Güncellenecek öğrenci ID'sini al
                    int id = int.Parse(txtOgrenciId.Text);
                    // Veritabanından öğrenci kaydını bul
                    var ogrenci = db.TblOgrenci.Find(id);
                    ogrenci.Ad = txtOgrenciAd.Text;
                    ogrenci.Soyad = txtOgrenciSoyad.Text;
                    db.SaveChanges();
                    MessageBox.Show("Öğrenci güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OgrenciListele();
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

        private void btnOgrenciListele_Click(object sender, EventArgs e)
        {
            OgrenciListele();
        }

        private void btnTemizleOgr_Click(object sender, EventArgs e)
        {
            TemizleOgr();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtOgrenciAd.Text) && !string.IsNullOrWhiteSpace(txtOgrenciSoyad.Text))
                {
                    TblOgrenci ogrenci = new TblOgrenci();
                    ogrenci.Ad = txtOgrenciAd.Text;
                    ogrenci.Soyad = txtOgrenciSoyad.Text;

                    db.TblOgrenci.Add(ogrenci); // add mmetodunun içine ürettiğin entity i yaz > ogrenci nesnesi
                    db.SaveChanges();
                    MessageBox.Show("Öğrenci listeye eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OgrenciListele();
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtOgrenciId.Text))
                {
                    int id = int.Parse(txtOgrenciId.Text);
                    //silmek / güncellemek / görüntülemek istediğimiz Id yi hafızada tutmak için : 
                    var x = db.TblOgrenci.Find(id);
                    db.TblOgrenci.Remove(x);
                    db.SaveChanges();
                    MessageBox.Show("Öğrenci listeden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    OgrenciListele();
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

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                //Where(x => x. ) ile db.TblOgrenci de ki bütün alanları getirir.
                //txtOgrenciAd.Text > buradaki veriye göre arama yap :
                //ilgili textboxta ki verilere göre listele (küçük / büyük harf duyarlılığı yok)
                //direkt isme göre arama yapmak istiyorsan >> dataGridView1.DataSource = db.TblOgrenci.Where(x => x.Ad == txtOgrenciAd.Text).ToList(); 
                //birden fazla sorgulama yapabiliriz && ile :
                dgvOgrenci.DataSource = db.TblOgrenci.Where(x => x.Ad == txtOgrenciAd.Text && x.Soyad == txtOgrenciSoyad.Text).ToList();
                // || veya dersen yukarıdaki kod için  o isme veya o soyadına sahip olan herkesi listeler
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

        private void txtOgrenciAd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtOgrenciAd.SelectionStart = txtOgrenciAd.Text.Length; // İmleci sona alır.

                string arananDeger = txtOgrenciAd.Text;
                //ad textbox ına bir veri girdiğim anda o isme sahip kişileri listelesin
                var result = from ogr in db.TblOgrenci
                             where ogr.Ad.Contains(arananDeger) //hepsini listelememesi için bir koşul yazıyoruz > eğer ogr adı "arananDeger" içeriyorsa > listele 
                             where ogr.Ad.StartsWith(arananDeger) //yukarıdaki direkt içeriyorsa > ama bu satır direkt "arananDeger" ile başlayanları getirir.
                             select ogr;
                dgvOgrenci.DataSource = result.ToList();
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
                dgvOgrenci.DataSource = db.NotListesi(); //prosedürü çağırıp uzun sql sorguları yerine sadece prosedür metodunu/nesnesini çağırdım
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

        private void frmOgrenci_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOgrenci.SelectedRows.Count > 0)
            {
                var selectedRow = dgvOgrenci.SelectedRows[0];
                var student = selectedRow.DataBoundItem as TblOgrenci;

                if (student != null)
                {
                    txtOgrenciId.Text = student.Id.ToString();
                    txtOgrenciAd.Text = student.Ad;
                    txtOgrenciSoyad.Text = student.Soyad;
                }
            }
        }
    }
}

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
    public partial class frmDersler : Form
    {
        public frmDersler()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }
        DbSınavOgrenciEntities db = new DbSınavOgrenciEntities();
        public void DersListele()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-TN04UGV\SQLEXPRESS;Initial Catalog=DbSınavOgrenci;Integrated Security=True");

            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("select * from tblDers", sqlConnection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                Console.WriteLine("HATA : " + ex);
            }
            finally { sqlConnection.Close(); }
        }
        public void TemizleDers()
        {
            txtDersId.Clear();
            txtDersAd.Clear();
        }
        private void btnDersListesi_Click(object sender, EventArgs e)
        {
            DersListele();
        }

        private void btnTemizleDers_Click(object sender, EventArgs e)
        {
            TemizleDers();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtDersAd.Text))
                {
                    TblDers tblDers = new TblDers();
                    tblDers.DersAd = txtDersAd.Text;
                    db.TblDers.Add(tblDers);
                    db.SaveChanges();
                    MessageBox.Show("Ders listeye eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DersListele();
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

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtDersId.Text))
                {
                    int id = int.Parse(txtDersId.Text);
                    var ders = db.TblDers.Find(id);
                    ders.DersAd = txtDersAd.Text;
                    db.SaveChanges();
                    MessageBox.Show("Ders güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DersListele();
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
                if (!string.IsNullOrWhiteSpace(txtDersId.Text))
                {
                    int id = int.Parse(txtDersId.Text);
                    //silmek / güncellemek / görüntülemek istediğimiz Id yi hafızada tutmak için : 
                    var y = db.TblDers.Find(id);
                    db.TblDers.Remove(y);
                    db.SaveChanges();
                    MessageBox.Show("Ders listeden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DersListele();
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

        private void frmDersler_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Başlık satırına tıklanmadığından emin olun
            if (e.RowIndex >= 0)
            {
                // Tıklanan satırı al
                var selectedRow = dataGridView1.Rows[e.RowIndex];

                // DataBoundItem ile tıklanan satırdaki veriyi model sınıfına dönüştür
                var lesson = selectedRow.DataBoundItem as TblDers;

                // Eğer dönüşüm başarılıysa, verileri TextBox'lara ata
                if (lesson != null)
                {
                    txtDersId.Text = lesson.DersId.ToString();
                    txtDersAd.Text = lesson.DersAd;
                }
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
                    txtDersId.Text = selectedRow.Cells["DersId"].Value.ToString(); // "DersId" sütun adı
                    txtDersAd.Text = selectedRow.Cells["DersAd"].Value.ToString(); // "DersAd" sütun adı
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity.Core;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EntitySchool
{
    public partial class frmTasarım : Form
    {
        public frmTasarım()
        {
            InitializeComponent();
        }
        //modelime ulaşmak için kullanacağım sınıf
        DbSınavOgrenciEntities db = new DbSınavOgrenciEntities();
        private readonly string connectionString = @"Data Source=DESKTOP-TN04UGV\SQLEXPRESS;Initial Catalog=DbSınavOgrenci;Integrated Security=True";
        public void TemizleOgr()
        {
            txtOgrenciId.Clear();
            txtOgrenciAd.Clear();
            txtOgrenciSoyad.Clear();
            txtOgrenciFoto.Clear();
        }
        public void TemizleDers()
        {
            txtDersId.Clear();
            txtDersAd.Clear();
        }
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
        public void OgrenciListele()
        {
            try
            {
                dataGridView1.DataSource = db.TblOgrenci.ToList(); //tblOgrenci ye ait tüm verileri listele
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;

            }
            catch (EntityException ex)
            {
                Console.WriteLine("HATA : " + ex);
                throw;
            }
        }
        private void btnDersListesi_Click(object sender, EventArgs e)
        {
            DersListele();
        }

        private void btnOgrenciListele_Click(object sender, EventArgs e)
        {
            OgrenciListele();
        }

        private void btnNotListesi_Click(object sender, EventArgs e)
        {
            NotListele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                bool ogrenciEklendi = false;
                bool dersEklendi = false;

                if (!string.IsNullOrWhiteSpace(txtOgrenciAd.Text) && !string.IsNullOrWhiteSpace(txtOgrenciSoyad.Text))
                {
                    TblOgrenci ogrenci = new TblOgrenci();
                    ogrenci.Ad = txtOgrenciAd.Text;
                    ogrenci.Soyad = txtOgrenciSoyad.Text;

                    db.TblOgrenci.Add(ogrenci); // add mmetodunun içine ürettiğin entity i yaz > ogrenci nesnesi
                    db.SaveChanges();
                    ogrenciEklendi = true;
                }

                if (!string.IsNullOrWhiteSpace(txtDersAd.Text))
                {
                    TblDers tblDers = new TblDers();
                    tblDers.DersAd = txtDersAd.Text;
                    db.TblDers.Add(tblDers);
                    db.SaveChanges();
                    dersEklendi = true;
                }

                if (dersEklendi || ogrenciEklendi)
                {
                    if (dersEklendi && ogrenciEklendi)
                    {
                        MessageBox.Show("Öğrenci ve Ders listeye eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OgrenciListele();
                    }
                    else if (ogrenciEklendi)
                    {
                        MessageBox.Show("Öğrenci listeye eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OgrenciListele();
                    }
                    else if (dersEklendi)
                    {
                        MessageBox.Show("Ders listeye eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DersListele();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA : " + ex);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                bool ogrenciSilindi = false;
                bool dersSilindi = false;

                if (!string.IsNullOrWhiteSpace(txtOgrenciId.Text))
                {
                    int id = int.Parse(txtOgrenciId.Text);
                    //silmek / güncellemek / görüntülemek istediğimiz Id yi hafızada tutmak için : 
                    var x = db.TblOgrenci.Find(id);
                    db.TblOgrenci.Remove(x);
                    db.SaveChanges();
                    ogrenciSilindi = true;
                }

                if (!string.IsNullOrWhiteSpace(txtDersId.Text))
                {
                    int id = int.Parse(txtDersId.Text);
                    //silmek / güncellemek / görüntülemek istediğimiz Id yi hafızada tutmak için : 
                    var y = db.TblDers.Find(id);
                    db.TblDers.Remove(y);
                    db.SaveChanges();
                    dersSilindi = true;
                }

                if (dersSilindi || ogrenciSilindi)
                {
                    if (dersSilindi && ogrenciSilindi)
                    {
                        MessageBox.Show("Öğrenci ve Ders listeden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        OgrenciListele();
                    }
                    else if (ogrenciSilindi)
                    {
                        MessageBox.Show("Öğrenci listeden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        OgrenciListele();
                    }
                    else if (dersSilindi)
                    {
                        MessageBox.Show("Ders listeden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DersListele();
                    }
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
                bool ogrenciGuncellendi = false;
                bool dersGuncellendi = false;

                if (!string.IsNullOrWhiteSpace(txtOgrenciId.Text))
                {
                    // Güncellenecek öğrenci ID'sini al
                    int id = int.Parse(txtOgrenciId.Text);
                    // Veritabanından öğrenci kaydını bul
                    var ogrenci = db.TblOgrenci.Find(id);
                    ogrenci.Ad = txtOgrenciAd.Text;
                    ogrenci.Soyad = txtOgrenciSoyad.Text;
                    ogrenci.Fotograf = txtOgrenciFoto.Text;
                    db.SaveChanges();
                    ogrenciGuncellendi = true;
                }

                if (!string.IsNullOrWhiteSpace(txtDersId.Text))
                {
                    int id = int.Parse(txtDersId.Text);
                    var ders = db.TblDers.Find(id);
                    ders.DersAd = txtDersAd.Text;
                    db.SaveChanges();
                    dersGuncellendi = true;
                }

                if (dersGuncellendi || ogrenciGuncellendi)
                {
                    if (dersGuncellendi && ogrenciGuncellendi)
                    {
                        MessageBox.Show("Öğrenci ve Ders güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OgrenciListele();
                    }
                    else if (ogrenciGuncellendi)
                    {
                        MessageBox.Show("Öğrenci güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OgrenciListele();
                    }
                    else if (dersGuncellendi)
                    {
                        MessageBox.Show("Ders güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DersListele();
                    }
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

        private void txtTemizle_Click(object sender, EventArgs e)
        {
            TemizleOgr();
            txtOgrenciAd.Focus();
        }

        private void btnTemizleDers_Click(object sender, EventArgs e)
        {
            TemizleDers();
            txtDersAd.Focus();
        }

        private void btnTemizleSınav_Click(object sender, EventArgs e)
        {
            TemizleNot();
            txtSınav1.Focus();
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

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                //Where(x => x. ) ile db.TblOgrenci de ki bütün alanları getirir.
                //txtOgrenciAd.Text > buradaki veriye göre arama yap :
                //ilgili textboxta ki verilere göre listele (küçük / büyük harf duyarlılığı yok)
                //direkt isme göre arama yapmak istiyorsan >> dataGridView1.DataSource = db.TblOgrenci.Where(x => x.Ad == txtOgrenciAd.Text).ToList(); 
                //birden fazla sorgulama yapabiliriz && ile :
                dataGridView1.DataSource = db.TblOgrenci.Where(x => x.Ad == txtOgrenciAd.Text && x.Soyad == txtOgrenciSoyad.Text).ToList();
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
                // Metin kutusunun içeriğini büyük harfe çevirir.
                txtOgrenciAd.Text = txtOgrenciAd.Text.ToUpper();
                txtOgrenciAd.SelectionStart = txtOgrenciAd.Text.Length; // İmleci sona alır.

                string arananDeger = txtOgrenciAd.Text;
                //ad textbox ına bir veri girdiğim anda o isme sahip kişileri listelesin
                var result = from ogr in db.TblOgrenci
                             where ogr.Ad.Contains(arananDeger) //hepsini listelememesi için bir koşul yazıyoruz > eğer ogr adı "arananDeger" içeriyorsa > listele 
                             where ogr.Ad.StartsWith(arananDeger) //yukarıdaki direkt içeriyorsa > ama bu satır direkt "arananDeger" ile başlayanları getirir.
                             select ogr;
                dataGridView1.DataSource = result.ToList();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbOrder.Checked == true) //ilgili radioButton seçili ise
                {
                    //Asc - Ascending
                    List<TblOgrenci> OgrList = db.TblOgrenci.OrderBy(x => x.Ad).ToList(); //isimlere göre sırala
                    dataGridView1.DataSource = OgrList; //bu listeyi datagrid de göster
                }
                if (rdbDescendingOrder.Checked == true) //ilgili radioButton seçili ise
                {
                    //Desc - Desscending
                    List<TblOgrenci> OgrList = db.TblOgrenci.OrderByDescending(x => x.Ad).ToList(); //isimlere göre tersten sırala
                    dataGridView1.DataSource = OgrList; //bu listeyi datagrid de göster
                }
                if (rdbKayıtlar.Checked == true) //ilgili radioButton seçili ise
                {
                    List<TblOgrenci> OgrList = db.TblOgrenci.OrderBy(x => x.Ad).Take(int.Parse(txtKayıt.Text)).ToList(); //sıralamanın Take(x) : ilk x tanesini al
                    dataGridView1.DataSource = OgrList; //bu listeyi datagrid de göster
                }
                if (rdbIdVeriGetir.Checked == true) //ilgili radioButton seçili ise
                {
                    int istenenID = int.Parse(txtIdVeriGetir.Text);
                    List<TblOgrenci> OgrList = db.TblOgrenci.Where(x => x.Id == istenenID).ToList(); //istenen Id ye sahip olanı listele ve OgrList ata
                    
                    if (OgrList.Count > 0)// Bu listeyi DataGridView'de göster// Eğer liste boş değilse, yani istenen ID bulunduysa > yani listede eleman var ise
                        dataGridView1.DataSource = OgrList; 

                    else
                        MessageBox.Show("Belirtilen ID'ye sahip öğrenci bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (rdbAra.Checked == true) //ilgili radioButton seçili ise
                {
                    List<TblOgrenci> OgrList = db.TblOgrenci.Where(x => x.Ad.StartsWith(txtAra.Text)).ToList(); //istenen harf ile başlayanı listele ve OgrList ata
                    
                    if (OgrList.Count > 0)// Bu listeyi DataGridView'de göster// Eğer liste boş değilse, yani istenen harf ile başlayan bulunduysa > yani listede eleman var ise
                        dataGridView1.DataSource = OgrList; //bu listeyi datagrid de göster

                    else
                        MessageBox.Show("Belirtilen harfle adı başlayan öğrenci bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (rdbAramaSon.Checked == true) //ilgili radioButton seçili ise
                {
                    List<TblOgrenci> OgrList = db.TblOgrenci.Where(x => x.Ad.EndsWith(txtAramaSon.Text)).ToList(); //istenen harf ile biteni listele ve OgrList ata

                    if (OgrList.Count > 0)// Bu listeyi DataGridView'de göster// Eğer liste boş değilse, yani istenen harf ile biten bulunduysa > yani listede eleman var ise
                        dataGridView1.DataSource = OgrList; //bu listeyi datagrid de göster

                    else
                        MessageBox.Show("Belirtilen harfle adı biten öğrenci bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (rdbDegerVarMı.Checked == true) //ilgili radioButton seçili ise
                {
                    bool deger = db.TblOgrenci.Any();
                    if (deger)
                        MessageBox.Show("Öğrenci tablosunda datalar var.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Öğrenci tabloda data yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (rdbDataAdet.Checked == true) //ilgili radioButton seçili ise
                {
                    int toplam = db.TblOgrenci.Count();
                    if (toplam != 0)
                        MessageBox.Show($"Öğrenci tablosunda ki data sayısı : {toplam}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Öğrenci tablosunda tabloda data yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            int ortalama = (int.Parse(txtSınav1.Text) * 30 / 100) + (int.Parse(txtSınav2.Text) * 30 / 100) + (int.Parse(txtSınav3.Text) * 40 / 100);
            txtSınavOrt.Text = ortalama.ToString();
            if (ortalama > 50)
                txtDurum.Text = "Geçti";
            else
                txtDurum.Text = "Kaldı";
        }
    }
}

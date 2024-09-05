using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitySchool
{
    public partial class frmLINQ : Form
    {
        DbSınavOgrenciEntities db = new DbSınavOgrenciEntities();
        public frmLINQ()
        {
            InitializeComponent();
            NotListele();
        }
        public void Ortalama()
        {

            var ogrenciDurumlari = db.TblNotlar
                    .Select(x => new
                    {
                        OgrenciID = x.NotId, // Öğrenci ID'sini al
                        Ortalama = x.Sınav1 * 0.3 + x.Sınav2 * 0.3 + x.Sınav3 * 0.4,
                        GectiMi = (x.Sınav1 * 0.3 + x.Sınav2 * 0.3 + x.Sınav3 * 0.4) >= 40
                    })
                    .ToList();
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
                                item.TblOgrenci.Ad,        //tablo bazlı devam edesek JOIN işlemi yapmış oluruz yani tabloları birleştiriiz.
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
        private void btnLINQ_Click(object sender, EventArgs e)
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
                if (rdbSınav1Toplam.Checked == true)
                {
                    var toplam = db.TblNotlar.Sum(x => x.Sınav1);
                    MessageBox.Show($"Topla Sınav1 puanı : {toplam}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (rdbSınav1Ortalama.Checked == true)
                {
                    var ortalama = db.TblNotlar.Average(x => x.Sınav1);
                    MessageBox.Show($"Sınav1 Ortalama : {ortalama}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (rdbSınav2Toplam.Checked == true)
                {
                    var toplam = db.TblNotlar.Sum(x => x.Sınav2);
                    MessageBox.Show($"Topla Sınav2 puanı : {toplam}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (rdbSınav2Ortalama.Checked == true)
                {
                    var ortalama = db.TblNotlar.Average(x => x.Sınav2);
                    MessageBox.Show($"Sınav2 Ortalama : {ortalama}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (rdbSınav3Toplam.Checked == true)
                {
                    var toplam = db.TblNotlar.Sum(x => x.Sınav3);
                    MessageBox.Show($"Topla Sınav3 puanı : {toplam}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (rdbSınav3Ortalama.Checked == true)
                {
                    var ortalama = db.TblNotlar.Average(x => x.Sınav3);
                    MessageBox.Show($"Sınav3 Ortalama : {ortalama}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (rdbDersiGecenler.Checked == true)
                {
                    //BURADA JOIN İŞLEMİDE YAPIYORUZ AYNI ZAMANDA
                    var result = db.TblNotlar.Where(x => x.Ortalama >= 40) //ortalaması 39 dan büyük olanlar Geçti
                        .Select(x => new                           //datagridviewwde istediğim sütunları göstertmek için resulttan select ifadesiyle istediğim sütunları alırım.
                        {
                            x.NotId,
                            x.TblOgrenci.Ad,
                            x.TblOgrenci.Soyad,
                            x.Ortalama,
                            x.Durum
                        }).ToList();
                    dataGridView1.DataSource = result;
                }
                if (rdbdersKaldı.Checked == true)
                {
                    var result = db.TblNotlar.Where(x => x.Ortalama < 40) //ortalaması 40 dan küçük olanlar Kaldı
                        .Select(x => new                                 //datagridviewwde istediğim sütunları göstertmek için resulttan select ifadesiyle istediğim sütunları alırım.
                        {
                            x.NotId,
                            x.TblOgrenci.Ad,
                            x.TblOgrenci.Soyad,
                            x.Ortalama,
                            x.Durum
                        }).ToList();
                    dataGridView1.DataSource = result;
                }
                if (rdbOrtMax.Checked == true)
                {
                    var maxOrt = db.TblNotlar.Max(x => x.Ortalama);

                    var maxOgr = db.TblNotlar.Where(x => x.Ortalama == maxOrt)
                        .Select(x => new
                        {
                            x.NotId,
                            x.TblOgrenci.Ad,
                            x.TblOgrenci.Soyad,
                            x.Ortalama,
                            x.Durum
                        }).ToList();
                    dataGridView1.DataSource = maxOgr;
                }
                if (rdbOrtMin.Checked == true)
                {
                    var minOrt = db.TblNotlar.Min(x => x.Ortalama);
                    var minOgr = db.TblNotlar.Where(x => x.Ortalama == minOrt)
                        .Select(x => new {
                            x.NotId,
                            x.TblOgrenci.Ad,
                            x.TblOgrenci.Soyad,
                            x.Ortalama,
                            x.Durum
                        }).ToList();
                    dataGridView1.DataSource = minOgr;
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
        private void frmLINQ_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void btnNotListesi_Click(object sender, EventArgs e)
        {
            NotListele();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            try
            {
                var result = db.TblNotlar.Join(db.TblOgrenci, 
                                                not => not.Ogr, 
                                                ogr => ogr.Id, 
                                                (not, ogr) => new { ogr, not })
                                         .Join(db.TblDers, notComb => notComb.not.Ders,
                                                ders => ders.DersId,
                                                (notComb, ders) => new
                                                {
                                                    ID = notComb.not.NotId,
                                                    Öğrenci = notComb.ogr.Ad + " " + notComb.ogr.Soyad,
                                                    Ders = ders.DersAd,
                                                    Sınav1 = notComb.not.Sınav1, 
                                                    Sınav2 = notComb.not.Sınav2,
                                                    Sınav3 = notComb.not.Sınav3,
                                                    Ortalama = notComb.not.Ortalama,
                                                    DURUM = notComb.not.Durum
                                                }).ToList();
                dataGridView1.DataSource = result;
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

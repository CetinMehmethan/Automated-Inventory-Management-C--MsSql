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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TezProje
{
    public partial class AnaSayfa : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MMKQMEM\\SQLEXPRESS;Initial Catalog = Stok2;Integrated Security=True");
        public AnaSayfa()
        {
            InitializeComponent();
        }
        DataSet daset = new DataSet();
        public string kullaniciAdi { get; set; }
        public string KullaniciTuru { get; set; }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stok2DataSet2.KategoriTablo' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kategoriTabloTableAdapter1.Fill(this.stok2DataSet2.KategoriTablo);
            // TODO: Bu kod satırı 'stok2DataSet2.SatıcıTablo' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.satıcıTabloTableAdapter1.Fill(this.stok2DataSet2.SatıcıTablo);

        }
        private void Temizle()
        {
            txtStokKod.Text = "";
            txtStokAd.Text = "";
            txtKalanMiktar.Text = "";
            txtKategoriNo.Text = "";
            txtSatisFiyati.Text = "";
            txtAlisFiyati.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kullanici Kgir = new Kullanici();
             Kgir.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtStokAd.Text == "" || txtKalanMiktar.Text == "" || txtKategoriNo.Text == "" || txtSatisFiyati.Text == "" || txtAlisFiyati.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Değerleri Eksiksiz Giriniz !", "Stok Takip", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                baglanti.Open();

                string islem5 = "insert into SatıcıTablo(StokKodu,StokAdi,KalanMiktar,KategoriNo,SatisFiyati,AlisFiyati) Values(@a6,@a1,@a2,@a3,@a4,@a5)";
                SqlCommand komut5 = new SqlCommand(islem5, baglanti);
                komut5.Parameters.AddWithValue("@a6", txtStokKod.Text);
                komut5.Parameters.AddWithValue("@a1", txtStokAd.Text);
                komut5.Parameters.AddWithValue("@a2", txtKalanMiktar.Text);
                komut5.Parameters.AddWithValue("@a3", txtKategoriNo.Text);
                komut5.Parameters.AddWithValue("@a4", txtSatisFiyati.Text);
                komut5.Parameters.AddWithValue("@a5", txtAlisFiyati.Text);
                komut5.ExecuteNonQuery();

                MessageBox.Show(txtStokAd.Text + "  Stoklara Eklenmiştir.", "Stok Takip", MessageBoxButtons.OK, MessageBoxIcon.Information);

                baglanti.Close();
                
                Temizle();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtStokAd.Text == "" || txtKalanMiktar.Text == "" || txtKategoriNo.Text == "" || txtSatisFiyati.Text == "" || txtAlisFiyati.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Değerleri Eksiksiz Giriniz !", "Stok Takip", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                baglanti.Open();
                string islem7 = "Update SatıcıTablo Set StokAdi = @a1, KalanMiktar = @a2, AlisFiyati = @a3, SatisFiyati = @a4, KategoriNo = @a5 where StokKodu = '" + txtStokKod.Text + "'";
                SqlCommand komut7 = new SqlCommand(islem7, baglanti);
                komut7.Parameters.AddWithValue("@a1", txtStokAd.Text);
                komut7.Parameters.AddWithValue("@a2", txtKalanMiktar.Text);
                komut7.Parameters.AddWithValue("@a3", txtAlisFiyati.Text);
                komut7.Parameters.AddWithValue("@a4", txtSatisFiyati.Text);
                komut7.Parameters.AddWithValue("@a5", txtKategoriNo.Text);
                komut7.ExecuteNonQuery();

                MessageBox.Show(txtStokAd.Text + "  Ürünü Güncellenmiştir.", "Stok Takip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();

                
                Temizle();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtStokKod.Text == "")
            {
                MessageBox.Show("Lütfen Ürün Kodu Değerini Giriniz !", "Stok Takip", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                baglanti.Open();

                string islem9 = "Delete From SatıcıTablo where StokKodu = '" + txtStokKod.Text + "'";
                SqlCommand komut9 = new SqlCommand(islem9, baglanti);
                komut9.ExecuteNonQuery();
                MessageBox.Show(txtStokAd.Text + "  Ürünü Başarıyla Silindi.", "Stok Takip", MessageBoxButtons.OK, MessageBoxIcon.Information);


                baglanti.Close();
                
                Temizle();
            }
    }

        private void button2_Click(object sender, EventArgs e)
        {
            int kategori = 0;
            string tip = "";
            if (txtAra.Text != "")
            {
                if (radioStokKodu.Checked == true || radioUrunAdi.Checked == true || checkBox1.Checked == true)
                {
                    if (radioStokKodu.Checked == true)
                    {
                        tip = "StokKodu";
                    }
                    else if (radioUrunAdi.Checked == true)
                    {
                        tip = "StokAdi";
                    }


                    if (checkBox1.Checked == true)
                    {

                        if (comboBox1.Text == "Pamuk Şeker")
                        {
                            kategori = 1;
                        }
                        else if (comboBox1.Text == "Elma Şeker")
                        {
                            kategori = 2;
                        }
                        else if (comboBox1.Text == "Sosyete Şeker")
                        {
                            kategori = 3;
                        }
                        else if (comboBox1.Text == "Polonya Şeker")
                        {
                            kategori = 4;
                        }
                        else if (comboBox1.Text == "Diğer Şeker")
                        {
                            kategori = 5;
                        }
                        else if (comboBox1.Text == "Osmanlı Macun")
                        {
                            kategori = 6;
                        }
                        baglanti.Open();

                        string islem1 = "Select StokKodu As [Ürün Kodu], StokAdi As [Ürün Adı], KalanMiktar As [Kalan Miktar], SatisFiyati As [Fiyatı],KategoriNo As [Kategori No] From SatıcıTablo where " + tip + "='" + txtAra.Text + "' AND KategoriNo='" + kategori + "'";
                        SqlDataAdapter komut1 = new SqlDataAdapter(islem1, baglanti);
                        DataTable df1 = new DataTable();
                        komut1.Fill(df1);
                        dataGridView1.DataSource = df1;

                        baglanti.Close();

                    }
                    baglanti.Open();

                    string islem2 = "Select StokKodu As [Ürün Kodu], StokAdi As [Ürün Adı], KalanMiktar As [Kalan Miktar], SatisFiyati As [Fiyatı],KategoriNo As [Kategori No] From SatıcıTablo where " + tip + "='" + txtAra.Text + "'";
                    SqlDataAdapter komut2 = new SqlDataAdapter(islem2, baglanti);
                    DataTable df2 = new DataTable();
                    komut2.Fill(df2);
                    dataGridView1.DataSource = df2;

                    baglanti.Close();


                }
                else
                {
                    MessageBox.Show("Lütfen Bir Arama Kriteri Seçiniz !", "Stok Takip", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                comboBox1.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
            }
        }

        private void radioStokKodu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtStokAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtStokKod.Text = dataGridView1.Rows[secilen].Cells["Ürün Kodu"].Value.ToString();
            txtStokAd.Text = dataGridView1.Rows[secilen].Cells["Ürün Adı"].Value.ToString();
            txtKalanMiktar.Text = dataGridView1.Rows[secilen].Cells["Kalan Miktar"].Value.ToString();
            txtKategoriNo.Text = dataGridView1.Rows[secilen].Cells["Kategori No"].Value.ToString();
            txtSatisFiyati.Text = dataGridView1.Rows[secilen].Cells["Fiyatı"].Value.ToString();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from SatıcıTablo", baglanti);
            adtr.Fill(daset, "SatıcıTablo");
            dataGridView1.DataSource = daset.Tables["SatıcıTablo"];


            baglanti.Close();

        }

        private void txtStokKod_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
           

            if (txtStokKod.Text == "*")
                {
                txtStokKod.Text = "";
                }
                Temizle();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select *from SatıcıTablo where StokKodu like '" + txtStokKod.Text + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                txtStokAd.Text = read["urunadi"].ToString();
                txtSatisFiyati.Text = read["satisfiyati"].ToString();

                }
                baglanti.Close();
            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string islem6 = "select * from SatıcıTablo";
            SqlCommand komut5 = new SqlCommand(islem6, baglanti);
            komut5.ExecuteNonQuery();
            SqlDataAdapter komut2 = new SqlDataAdapter(islem6, baglanti);
            DataTable df2 = new DataTable();
            komut2.Fill(df2);
            dataGridView1.DataSource = df2;
            baglanti.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            islem ms = new islem();
            ms.ShowDialog();
            
            
        }
    }
    }
    


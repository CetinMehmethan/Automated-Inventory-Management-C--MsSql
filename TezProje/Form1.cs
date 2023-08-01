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

namespace TezProje
{
    public partial class islem : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MMKQMEM\\SQLEXPRESS;Initial Catalog = Stok2;Integrated Security=True");
        public islem()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime odemeGunu = dateTimePicker1.Value;
            if (comboBox1.Text == "" || txtMal.Text == "" || txtToplamB.Text == "" || txtKalanB.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Değerleri Eksiksiz Giriniz !", "Stok Takip", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                baglanti.Open();

                string islem5 = "insert into islemTablo(KullaniciID,AlınanMal,ToplamBorc,KalanBorc,tarih) Values(@a6,@a1,@a2,@a3,@a5)";
                SqlCommand komut5 = new SqlCommand(islem5, baglanti);
                komut5.Parameters.AddWithValue("@a6", Convert.ToInt32(comboBox1.SelectedValue));
                komut5.Parameters.AddWithValue("@a1", txtMal.Text);
                komut5.Parameters.AddWithValue("@a2", txtToplamB.Text);
                komut5.Parameters.AddWithValue("@a3", txtKalanB.Text);
                komut5.Parameters.AddWithValue("@a5", dateTimePicker1.Value);

                komut5.ExecuteNonQuery();

                MessageBox.Show("  Kayıt Eklenmiştir.", "Stok Takip", MessageBoxButtons.OK, MessageBoxIcon.Information);

                baglanti.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO: Bu kod satırı 'stok2DataSet4.islemTablo' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.islemTabloTableAdapter1.Fill(this.stok2DataSet4.islemTablo);
            // TODO: Bu kod satırı 'stok2DataSet3.islemTablo' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.islemTabloTableAdapter.Fill(this.stok2DataSet3.islemTablo);
            // TODO: Bu kod satırı 'stok2DataSet3.Kullanicilar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullanicilarTableAdapter.Fill(this.stok2DataSet3.Kullanicilar);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == "" || txtMal.Text == "" || txtToplamB.Text == "" || txtKalanB.Text == "" || ıslem1.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Değerleri Eksiksiz Giriniz !", "Stok Takip", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                baglanti.Open();
                string islem7 = "Update islemTablo Set KullaniciID = @a6, AlınanMal = @a1, ToplamBorc = @a2, KalanBorc = @a3, tarih = @a5 where islemID = '" + ıslem1.Text + "'";
                SqlCommand komut7 = new SqlCommand(islem7, baglanti);
                komut7.Parameters.AddWithValue("@a6", Convert.ToInt32(comboBox1.SelectedValue));
                komut7.Parameters.AddWithValue("@a1", txtMal.Text);
                komut7.Parameters.AddWithValue("@a2", txtToplamB.Text);
                komut7.Parameters.AddWithValue("@a3", txtKalanB.Text);
                komut7.Parameters.AddWithValue("@a5", dateTimePicker1.Value);
                komut7.ExecuteNonQuery();

                MessageBox.Show(ıslem1.Text + "  Ürünü Güncellenmiştir.", "Stok Takip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ıslem1.Text == "")
            {
                MessageBox.Show("Lütfen İşlem ID Değerini Giriniz !", "Stok Takip", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                baglanti.Open();

                string islem9 = "Delete From islemTablo where islemID = '" + ıslem1.Text + "'";
                SqlCommand komut9 = new SqlCommand(islem9, baglanti);
                komut9.ExecuteNonQuery();
                MessageBox.Show(ıslem1.Text + "  Kayıt Başarıyla Silindi.", "Stok Takip", MessageBoxButtons.OK, MessageBoxIcon.Information);


                baglanti.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string islem6 = "select * from islemTablo";
            SqlCommand komut5 = new SqlCommand(islem6, baglanti);
            komut5.ExecuteNonQuery();
            SqlDataAdapter komut2 = new SqlDataAdapter(islem6, baglanti);
            DataTable df2 = new DataTable();
            komut2.Fill(df2);
            dataGridView1.DataSource = df2;
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {   this.Hide();
            AnaSayfa ic = new AnaSayfa();
            ic.ShowDialog();
        }
    }
}

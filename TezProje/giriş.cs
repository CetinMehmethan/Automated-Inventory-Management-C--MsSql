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
    
    public partial class giriş : Form
    {
        
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MMKQMEM\\SQLEXPRESS;Initial Catalog = Stok2;Integrated Security=True");
        
        public giriş()
        {
            InitializeComponent();
        }

        private void giriş_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Kullanicilar where KullaniciAdi = '" + txtkadi.Text + "' and Sifre ='" + txtpassword.Text+"'",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            { AnaSayfa AnaSayfa = new AnaSayfa();
                this.Hide();
                AnaSayfa.ShowDialog();
                txtpassword.Clear();
                baglanti.Close();
              
            }
            else
            {
                MessageBox.Show("KULLANICI ADI VEYA ŞİFRE YANLIŞ");
                baglanti.Close();
            }
            
        }
    }
}

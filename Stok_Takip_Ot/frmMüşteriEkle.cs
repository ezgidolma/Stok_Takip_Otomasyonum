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

namespace Stok_Takip_Ot
{
    public partial class frmMüşteriEkle : Form
    {
        public frmMüşteriEkle()
        {
            InitializeComponent();
        }
        //Sql'i bağlama
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=StokDatabase;Integrated Security=True");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmMüşteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();//bağlantıtı aç
            SqlCommand komut = new SqlCommand("insert into müşteri(tc,adsoyad,telefon,adres,email) values(@tc,@adsoyad,@telefon,@adres,@email)", baglanti);
            komut.Parameters.AddWithValue("@tc",txtTC.Text);//Müşterileri anahtar kilit ilişkisiyle birleştir.
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);
            komut.ExecuteNonQuery();//onaylama işlemi
            baglanti.Close();//bağlantı kaptma
            MessageBox.Show("Müşteri kaydı eklendi");
            foreach (Control item in this.Controls)//kontrollerde itemler Textbox ise içlerini boşalt
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}

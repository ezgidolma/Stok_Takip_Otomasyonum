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

namespace Stok_Takip_Ot
{
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StokDatabase;Integrated Security=True;Connect Timeout=30;" +
            "Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        DataSet daset = new DataSet();

        private void SepetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from sepet", baglanti);
            adtr.Fill(daset,"sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            baglanti.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet ",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
          
            MessageBox.Show("Ürünler sepetten çıkarıldı.");
            daset.Tables["sepet"].Clear();
            SepetListele();
            Hesapla();
        }

        private void btnMüşteriEkleme_Click(object sender, EventArgs e)
        {
            frmMüşteriEkle ekle = new frmMüşteriEkle();
            ekle.ShowDialog();
        }

        private void btnMüşteriListeleme_Click(object sender, EventArgs e)
        {
            frmMüşteriListele müşteriListele = new frmMüşteriListele();
            müşteriListele.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnÜrünEkleme_Click(object sender, EventArgs e)
        {
            frmÜrünEkle ekle = new frmÜrünEkle();
            ekle.ShowDialog();
        }
        private void Hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyati)  from sepet",baglanti);
                lblgeneltoplam.Text = komut.ExecuteScalar() + "TL";
                baglanti.Close();

            }
            catch (Exception)
            {

                ;
            }
        }
        private void btnSatışlarıListeleme_Click(object sender, EventArgs e)
        {
            frmSatisListele listele = new frmSatisListele();
            listele.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            SepetListele();
        }

        private void btnÜrünListeleme_Click(object sender, EventArgs e)
        {
            frmÜrünListele ürünListele = new frmÜrünListele();
            ürünListele.ShowDialog();

        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            if (txtTC.Text=="")
            {
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from müşteri where tc like '%"+txtTC.Text+"%'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
               
            }
            baglanti.Close();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            Temizle();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from urun where barkodno like '" + txtBarkodNo.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtÜrünAdı.Text = read["urunadi"].ToString();
                txtSatışFiyatı.Text = read["satisfiyati"].ToString();

            }
            baglanti.Close();
        }

        private void Temizle()
        {
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item != txtMiktarı)
                    {
                        item.Text = "";
                    }

                }

            }
        }

        private void txtSatışFiyatı_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktarı.Text) * double.Parse(txtSatışFiyatı.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }

        }

        bool durum;

        private void BarkodKontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from sepet",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text == read["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            BarkodKontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into sepet(tc,adsoyad,telefon,barkodno,urunadi,toplamfiyati,satisfiyati,tarih,miktari) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@toplamfiyati,@satisfiyati,@tarih,@miktari) ", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTC.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@urunadi", txtÜrünAdı.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktarı.Text));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(txtToplamFiyat.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatışFiyatı.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                
            }
            else
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update sepet miktari=miktari+'"+int.Parse(txtMiktarı.Text)+ "'where barkodno='" + txtBarkodNo.Text + "'", baglanti);
                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("update sepet toplamfiyati=miktari*satisfiyati where barkodno='" + txtBarkodNo.Text + "'", baglanti);
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }
            Hesapla();
           
            txtMiktarı.Text = "1";
            daset.Tables["sepet"].Clear();
            SepetListele();
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item != txtMiktarı)
                    {
                        item.Text = "";
                    }

                }

            }

        }

        private void txtMiktarı_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text =(double.Parse( txtMiktarı.Text )*double.Parse( txtSatışFiyatı.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() +"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
   
            MessageBox.Show("Ürün sepetten çıkarıldı.");
            daset.Tables["sepet"].Clear();
            SepetListele();
            Hesapla();
        }

        private void lblgeneltoplam_Click(object sender, EventArgs e)
        {

        }

        private void btnSatışYap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)//kaç tane kayıt varsa
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into satis (tc,adsoyad,telefon,barkodno,urunadi,toplamfiyati,satisfiyati,tarih,miktari) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@toplamfiyati,@satisfiyati,@tarih,@miktari) ", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTC.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());//kaç tane kayıt varsa onu barkodno sutününe aktar
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
                komut.Parameters.AddWithValue("@miktari", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                SqlCommand komut2 = new SqlCommand("update urun set miktari =miktari-'" + int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()) + "' where barkodno= '" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
        

            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from sepet", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["sepet"].Clear();
            SepetListele();
            Hesapla();
        }
    }
}

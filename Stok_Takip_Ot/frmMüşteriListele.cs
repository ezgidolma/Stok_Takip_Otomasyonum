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
    public partial class frmMüşteriListele : Form
    {
        public frmMüşteriListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=StokDatabase;Integrated Security=True");

        DataSet daset = new DataSet(); //Kayıtları burada geçici olarak tutmak için
        private void frmMüşteriListele_Load(object sender, EventArgs e)
        {
            Kayıt_Göster();

        }

        private void Kayıt_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from müşteri", baglanti);//bütün kayıtları göstermek için
            adapter.Fill(daset, "müşteri");// veri tabanındaki tabloyu yazıyor
            dataGridView1.DataSource = daset.Tables["müşteri"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTC.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();//hücre hangi hücreyse onu yazarız
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update müşteri set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email where tc=@tc", baglanti);
            komut.Parameters.AddWithValue("@tc", txtTC.Text);//Müşterileri anahtar kilit ilişkisiyle birleştir.
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);
            komut.ExecuteNonQuery();//onaylama işlemi
            baglanti.Close();//bağlantı kaptma
            daset.Tables["müşteri"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Müşteri kaydı güncelledi");
            foreach (Control item in this.Controls)//kontrollerde itemler Textbox ise içlerini boşalt
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from müşteri where tc='" + dataGridView1.CurrentRow.Cells["tc"].Value.ToString() +"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["müşteri"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Kayıt silindi");
        }


        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo =new DataTable();
            baglanti.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from müşteri where tc like '%" + txtTcAra.Text + "%'", baglanti);
            dataAdapter.Fill(tablo);//kayıtları tabloya aktarma kısmı
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
    }
}
        
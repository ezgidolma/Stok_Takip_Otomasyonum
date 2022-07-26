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
    public partial class frmÜrünListele : Form
    {
        public frmÜrünListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StokDatabase;Integrated Security=True;Connect Timeout=30;" +
            "Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        DataSet dataSet = new DataSet();
        private void KategoriGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboKategori.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }
        private void frmÜrünListele_Load(object sender, EventArgs e)
        {
            ÜrünListele();
            KategoriGetir();
        }

        private void ÜrünListele()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from urun ", baglanti);
            adapter.Fill(dataSet, "urun");
            dataGridView1.DataSource = dataSet.Tables["urun"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BarkodNotxt.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            Kategoritxt.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            ÜrünAdıtxt.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            Miktarıtxt.Text = dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            AlışFiyatıtxt.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            SatışFiyatıtxt.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();
            Markatxt.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set urunadi=@urunadi,miktari=@miktari,alisfiyati=@alisfiyati,satisfiyati=@satisfiyati where barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@barkodno", BarkodNotxt.Text);
            komut.Parameters.AddWithValue("@urunadi", ÜrünAdıtxt.Text);
            komut.Parameters.AddWithValue("@alisfiyati", double.Parse(AlışFiyatıtxt.Text));
            komut.Parameters.AddWithValue("@satisfiyati",double.Parse( SatışFiyatıtxt.Text));
            komut.Parameters.AddWithValue("@miktari", int.Parse(Miktarıtxt.Text));

            komut.ExecuteNonQuery();
            baglanti.Close();
            dataSet.Tables["urun"].Clear();
            ÜrünListele();
            MessageBox.Show("Güncelleme yapıldı.");

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }


        }

        private void MarkaGüncelle_Click(object sender, EventArgs e)
        {
             if (BarkodNotxt.Text != "")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("update urun set kategori=@kategori,marka=@marka where barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", BarkodNotxt.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme yapıldı.");
                dataSet.Tables["urun"].Clear();
                ÜrünListele();

            }
            else
            {
                MessageBox.Show("Barkodno yazılı değil");
            }
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
             
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from markabilgileri where kategori='" + comboKategori.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from urun where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            dataSet.Tables["urun"].Clear();
            ÜrünListele();
            MessageBox.Show("Kayıt silindi");

        }

        private void Markatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from urun where barkodno like '%" + txtBarkodNoAra.Text + "%'", baglanti);
            dataAdapter.Fill(tablo);//kayıtları tabloya aktarma kısmı
            dataGridView1.DataSource = tablo;
            baglanti.Close(); 
        }
    }
}

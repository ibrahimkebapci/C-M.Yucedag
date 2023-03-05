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

namespace Ders8_VeriTabanİSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=DESKTOP-T2496AJ\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        
        public void Temizle()
        {
            TxtId.Text = "";
            TxtAd.Text = "";
            TxtDurum.Text = "";
            TxtMeslek.Text = "";
            TxtSoyad.Text = "";
            CmbSehir.Text = "";
            MtxtMaas.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand Kaydet = new SqlCommand("insert into Tbl_Personel(PersonelAd,PersonelSoyad,PersonelŞehir,PersonelMaas,PersonelMeslek,PersonelDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)" , Baglanti);
            Kaydet.Parameters.AddWithValue("@p1",TxtAd.Text);
            Kaydet.Parameters.AddWithValue("@p2",TxtSoyad.Text);
            Kaydet.Parameters.AddWithValue("@p3",CmbSehir.Text);
            Kaydet.Parameters.AddWithValue("@p4",MtxtMaas.Text);
            Kaydet.Parameters.AddWithValue("@p5",TxtMeslek.Text);
            Kaydet.Parameters.AddWithValue("@p6",TxtDurum.Text);
            Kaydet.ExecuteNonQuery();
            Baglanti.Close();
            MessageBox.Show("Personel Eklendi");
        }
         

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet2.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter1.Fill(this.personelVeriTabaniDataSet2.Tbl_Personel);
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet1.Tbl_Personel' table. You can move, or remove it, as needed.

        }

        private void BtnListe_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet1.Tbl_Personel);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
            TxtDurum.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                TxtDurum.Text = "False";
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
        
            TxtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MtxtMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtDurum.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void TxtDurum_TextChanged(object sender, EventArgs e)
        {
            if(TxtDurum.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if(TxtDurum.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

        }
    }
}

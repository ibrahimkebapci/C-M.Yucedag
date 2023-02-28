﻿using System;
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
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

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
            TxtDurum.Text = "True";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            TxtDurum.Text = "False";
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}

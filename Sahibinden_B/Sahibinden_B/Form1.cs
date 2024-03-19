using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Sahibinden_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ÖĞRENCİ\\Desktop\\Batuhan Subaşı\\Sahibinden_B\\AracBilgileri.mdb");

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici = textBox1.Text;
            string sifre = textBox2.Text;
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM SistemKullanicilari WHERE KullaniciAdi= '" + kullanici + "' AND Sifre = '" + sifre + "'", baglan);
            OleDbDataReader oku = komut.ExecuteReader();
            if (oku.Read()) 
            {
                MessageBox.Show("Sistem Sayfasına Yönlendiriliyorsunuz...");
                Form2 frm2 = new Form2();
                this.Hide();
                frm2.Show();
            }
            baglan.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/batuhansbs08");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://instagram.com/batu.iwnl_");
        }
    }
}

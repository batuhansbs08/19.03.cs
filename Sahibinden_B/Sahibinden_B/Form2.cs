using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahibinden_B
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            this.Hide();
            frm3.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Çıkış Yapmak İstediğinizden Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                Form1 frm1 = new Form1();
                this.Close();
                frm1.Show();
            }
            else 
            {
                MessageBox.Show("Çıkış İşlemi Yapılmamıştır");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            this.Hide();
            frm4.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

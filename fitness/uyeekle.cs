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

namespace fitness
{
    public partial class uyeekle : Form
    {
        public uyeekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\OMER\Documents\sporDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uyeekle_Load(object sender, EventArgs e)
        {

        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            if (adsoyad.Text==""||tel.Text==""||ucret.Text==""||yas.Text=="")
            {
                MessageBox.Show("eksik bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "insert into uyeTbl values ('" + adsoyad.Text + "','" + tel.Text + "','" + cinsiyet.SelectedItem.ToString() + "','" + yas.Text + "','" + ucret.Text + "','" + zaman.SelectedItem.ToString() + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("başarıyla eklendi");
                    baglanti.Close();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            adsoyad.Text = "";
            cinsiyet.Text = "";
            ucret.Text = "";
            tel.Text = "";
            yas.Text = "";
            zaman.Text = "";
        }

        private void geribtn_Click(object sender, EventArgs e)
        {
            anasayfa log = new anasayfa();
            log.Show();
            this.Hide();
        }
    }
}

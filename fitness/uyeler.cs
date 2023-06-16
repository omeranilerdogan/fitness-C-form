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
using static Guna.UI2.Native.WinApi;

namespace fitness
{
    public partial class uyeler : Form
    {
        public uyeler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\OMER\Documents\sporDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void Uyeleri()
        {
            baglanti.Open();
            string query = "select * from uyeTbl";
            SqlDataAdapter sda=new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder= new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            uyedvg.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void uyeler_Load(object sender, EventArgs e)
        {
            Uyeleri();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            anasayfa ana = new anasayfa();
            ana.Show();
            this.Hide();
        }
        private void adfiltrele()
        {
            baglanti.Open();
            string query = "select * from uyeTbl where uAdsoyad='" + arauyetb.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            uyedvg.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adfiltrele();
            arauyetb.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uyeleri();
        }
    }
}

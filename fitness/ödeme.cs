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
using System.Data.Common;

namespace fitness
{
    public partial class ödeme : Form
    {
        public ödeme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\OMER\Documents\sporDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void fillname()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select uAdsoyad from uyeTbl", baglanti);
            SqlDataReader rdr;
            rdr= komut.ExecuteReader();
            DataTable dt= new DataTable();
            dt.Columns.Add("uAdsoyad",typeof(string));
            dt.Load(rdr);
            comboBox1.ValueMember = "uAdsoyad";
            comboBox1.DataSource = dt;
            baglanti.Close();

        }
        private void Uyeleri()
        {
            baglanti.Open();
            string query = "select * from odemeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            uyedvg.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void adfiltrele()
        {
            baglanti.Open();
            string query = "select * from odemeTbl where oUye='"+aratb.Text+"';";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            uyedvg.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void ödeme_Load(object sender, EventArgs e)
        {
            fillname();
            Uyeleri();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            tutartb.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            anasayfa ana=new anasayfa();
            ana.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text==""||tutartb.Text=="")
            {
                MessageBox.Show("eksik bilgi");
            }
            else
            {
                string odemeperiyotu=tarihdt.Value.Month.ToString()+tarihdt.Value.Year.ToString();

                baglanti.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from odemeTbl where oUye='" + comboBox1.SelectedValue.ToString() + "' and oAy='" + odemeperiyotu + "'", baglanti); 
                DataTable dt=new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString()=="1")
                {
                    MessageBox.Show("zaten ödeme yapıldı");
                }
                else
                {
                    string query = "insert into OdemeTbl values ('" + odemeperiyotu + "','" + comboBox1.SelectedValue.ToString() + "','" + tutartb.Text + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("tutar başarıyla ödendi");
                }
                baglanti.Close();
                Uyeleri();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            adfiltrele();
            aratb.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Uyeleri();
        }
    }
}

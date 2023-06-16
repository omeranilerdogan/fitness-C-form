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

namespace fitness
{
    public partial class guncellesil : Form
    {
        public guncellesil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\OMER\Documents\sporDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void Uyeleri()
        {
            baglanti.Open();
            string query = "select * from uyeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            uyedvg.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void guncellesil_Load(object sender, EventArgs e)
        {
            Uyeleri();
        }
        int key = 0;
        private void uyedvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(uyedvg.SelectedRows[0].Cells[0].Value.ToString());
            adsoyadtb.Text = uyedvg.SelectedRows[0].Cells[1].Value.ToString();
            teltb.Text = uyedvg.SelectedRows[0].Cells[2].Value.ToString();
           
            cinsiyetcb.Text = uyedvg.SelectedRows[0].Cells[3].Value.ToString();
            yastb.Text = uyedvg.SelectedRows[0].Cells[4].Value.ToString();
            ucrettb.Text = uyedvg.SelectedRows[0].Cells[5].Value.ToString();
            zamancb.Text = uyedvg.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void reset_Click(object sender, EventArgs e)
        {
            if (key==0)
            {
                MessageBox.Show("silinecek öyeyi seçin");

            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "delete from uyeTbl where uId=" + key + ";";
                    SqlCommand komut=new SqlCommand(query,baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("üye başarıyla silindi");
                    baglanti.Close();
                    Uyeleri();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            if (key == 0 || adsoyadtb.Text == "" || teltb.Text == "" || cinsiyetcb.Text == "" || yastb.Text == "" || ucrettb.Text == "" || zamancb.Text == "")
            {
                MessageBox.Show("eksik bilgi");

            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update   uyeTbl set uAdsoyad='"+adsoyadtb.Text+"',uTel='"+teltb.Text+"',uCinsiyet='"+cinsiyetcb.Text+"',uYas='"+yastb.Text+"',uOdeme='"+ucrettb.Text+"',uZamanlama='"+zamancb.Text+"' where uId="+key+";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("üye başarıyla güncellendi");
                    baglanti.Close();
                    Uyeleri();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
    
}

namespace fitness
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resetbt_Click(object sender, EventArgs e)
        {
            kuladtb.Text = "";
            sifretb.Text = "";

        }

        private void girisbt_Click(object sender, EventArgs e)
        {
            if (kuladtb.Text==""||sifretb.Text=="")
            {
                MessageBox.Show("Bo� b�rakmay�n");

            }
            else
            {
                if (kuladtb.Text=="admin"&&sifretb.Text=="123456")
                {
                    MessageBox.Show("giri� ba�ar�l�");
                    anasayfa ana=new anasayfa();
                    ana.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("hatal� giri� yapt�n�z tekrar deneyin");
                    kuladtb.Text = "";
                    sifretb.Text = "";
                }
            }
        }
    }
}
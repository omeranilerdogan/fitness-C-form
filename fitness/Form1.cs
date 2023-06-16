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
                MessageBox.Show("Boþ býrakmayýn");

            }
            else
            {
                if (kuladtb.Text=="admin"&&sifretb.Text=="123456")
                {
                    MessageBox.Show("giriþ baþarýlý");
                    anasayfa ana=new anasayfa();
                    ana.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("hatalý giriþ yaptýnýz tekrar deneyin");
                    kuladtb.Text = "";
                    sifretb.Text = "";
                }
            }
        }
    }
}
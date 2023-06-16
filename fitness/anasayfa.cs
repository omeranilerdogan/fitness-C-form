using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitness
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           uyeekle uyeekle = new uyeekle();
            uyeekle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            guncellesil guncellesil= new guncellesil();
            guncellesil.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ödeme ode = new ödeme();
            ode.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uyeler uye=new uyeler();
            uye.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flowers
{
    public partial class Rastenia : Form
    {
        public Rastenia()
        {
            InitializeComponent();
        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void Ruc_Click(object sender, EventArgs e)
        {

        }
        static int i;
       public void kor_Click(object sender, EventArgs e)
        {
           Korzina korz = new Korzina();
            string pokupki= @"pokp.txt";
            string tht = @"theni.txt";
            File.AppendAllText(pokupki, label666.Text+ Environment.NewLine);
            File.AppendAllText(tht, price.Text + Environment.NewLine);

        }

        private void Korzina_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Korzina korz = new Korzina();
            korz.Show();
            korz.WindowState = FormWindowState.Maximized;
        }

        private void price_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            profil.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void glav_Click(object sender, EventArgs e)
        {
            Glavnaya glavnaya = new Glavnaya();
            glavnaya.Show();
            glavnaya.WindowState= FormWindowState.Maximized;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Show();
            test.WindowState= FormWindowState.Maximized;
            this.Close();
        }
    }
}

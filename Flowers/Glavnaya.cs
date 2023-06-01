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
    public partial class Glavnaya : Form
    {
        public Glavnaya()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Glavnaya glavnaya = new Glavnaya();
            Test test = new Test();

            test.Show();
            test.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void banana_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            profil.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }

        private void Korzina_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Korzina korz = new Korzina();
            korz.Show();
            korz.WindowState = FormWindowState.Maximized;

        }

        private void Glavnaya_Load(object sender, EventArgs e)
        {
            string pokupki = @"C:\Users\Механцевнв\source\repos\I-Can-Buy-Myself-Flowers\Flowers\bin\Debug\pokp.txt";
            string tht = @"C:\Users\Механцевнв\source\repos\I-Can-Buy-Myself-Flowers\Flowers\bin\Debug\theni.txt";
            File.Delete(pokupki);
            File.Delete(tht);
            using (var fileStream = File.Create(pokupki))
            {

            }

            using (var fileStream = File.Create(tht))
            {

            }
        }
    }
}

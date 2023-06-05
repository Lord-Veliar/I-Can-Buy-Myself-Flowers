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
            string pokupki = @"pokp.txt";
            string tht = @"theni.txt";
            File.AppendAllText(pokupki, label666.Text + Environment.NewLine);
            File.AppendAllText(tht, price.Text + Environment.NewLine);
            MessageBox.Show("Товар добавлен в корзину!", "Добавлено", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void Korzina_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Korzina korz = new Korzina();
            korz.Show();
            korz.WindowState = FormWindowState.Maximized;
            this.Close();
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
            glavnaya.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Show();
            test.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void glav_Click_1(object sender, EventArgs e)
        {
            Glavnaya glavnaya = new Glavnaya();
            glavnaya.Show();
            glavnaya.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Show();
            test.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Big big = new Big();
            big.Show();
            big.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            New @new = new New();
            @new.Show();
            @new.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            animals animals = new animals();
            animals.Show();
            animals.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            light light = new light();
            light.Show();
            light.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void kor_Click_1(object sender, EventArgs e)
        {
            Korzina korz = new Korzina();
            string pokupki = @"pokp.txt";
            string tht = @"theni.txt";
            File.AppendAllText(pokupki, label666.Text + Environment.NewLine);
            File.AppendAllText(tht, price.Text + Environment.NewLine);
            MessageBox.Show("Товар добавлен в корзину!", "Добавлено", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Korzina_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Korzina korz = new Korzina();
            korz.Show();
            korz.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            profil.WindowState = FormWindowState.Maximized;
            this.Close();
        }
    }
}

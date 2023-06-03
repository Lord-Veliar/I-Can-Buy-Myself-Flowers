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
    public partial class Korzina : Form
    {
        public Korzina()
        {
            InitializeComponent();
        }

        private void Korzina_Load(object sender, EventArgs e)
        {
            int sh = 0;
            int sm = 0;
            string pokupki = @"pokp.txt";
            string cpc = "";
            cpc=File.ReadAllText(pokupki);
            spic.Text=cpc;
            string tht = @"theni.txt";
            string jnj= File.ReadAllText(tht);
            cost.Text=jnj;
            string[] pnp = jnj.Split();
            foreach (string p in pnp)
            {
                if (p!="")
                {
                    sm = sm+ Convert.ToInt32(p);
                    summa.Text = Convert.ToString(sm);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            profil.WindowState = FormWindowState.Maximized;
            this.Close();
        }
    }
}

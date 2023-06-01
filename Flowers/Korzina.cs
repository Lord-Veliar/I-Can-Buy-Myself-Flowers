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
            string pokupki = @"C:\Users\Механцевнв\source\repos\I-Can-Buy-Myself-Flowers\Flowers\bin\Debug\pokp.txt";
            string cpc = "";
            cpc=File.ReadAllText(pokupki);
            spic.Text=cpc;
            string tht = @"C:\Users\Механцевнв\source\repos\I-Can-Buy-Myself-Flowers\Flowers\bin\Debug\theni.txt";
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

        private void summa_Click(object sender, EventArgs e)
        {

        }
    }
}

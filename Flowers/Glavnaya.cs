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
    }
}

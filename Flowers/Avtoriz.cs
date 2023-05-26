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
    public partial class Avtoriz : Form
    {
        public Avtoriz()
        {
            InitializeComponent();
        }

        private void Avtoriz_Load(object sender, EventArgs e)
        {

        }

        private void APass_TextChanged(object sender, EventArgs e)
        {

        }

        private void AMeil_Enter(object sender, EventArgs e)
        {
            if (AMeil.Text == "Email")
            {
                AMeil.Text = "";

                AMeil.ForeColor = Color.Black;
            }
        }

        private void AMeil_Leave(object sender, EventArgs e)
        {
            if (AMeil.Text == "")
            {
                AMeil.Text = "Email";
                AMeil.ForeColor = Color.Gray;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           I_Can_Buy_Myself_Flowers i_Can_Buy_Myself_Flowers = new I_Can_Buy_Myself_Flowers();
            i_Can_Buy_Myself_Flowers.Show();
           i_Can_Buy_Myself_Flowers.WindowState = FormWindowState.Maximized;
            
        }

        private void Vhod_Click(object sender, EventArgs e)
        {

        }

        private void APass_Enter(object sender, EventArgs e)
        {
            if (APass.Text == "Пароль")
            {
                APass.Text = "";

                APass.ForeColor = Color.Black;
            }
        }

        private void APass_Leave(object sender, EventArgs e)
        {
            if (APass.Text == "")
            {
                APass.Text = "Пароль";
                APass.ForeColor = Color.Gray;
            }
        }
    }
}

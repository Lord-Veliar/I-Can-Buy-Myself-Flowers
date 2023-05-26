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
            this.WindowState = FormWindowState.Maximized;
            AMeil.Enabled = false;
            APass.Enabled = false;
            AMeil.Enabled = true;

            APass.Enabled = true;
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
            Application.Restart();
            
        }

        private async void Vhod_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Механцевнв\source\repos\flowers\Flowers\bin\Debug\Аккаунты.csv";
            List<string> people = new List<string>();
            List<string> bufer = new List<string>();
            int protect = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    bufer.Add(line);
                }
                reader.Close();
            }
            foreach (string st in bufer)
            {
                string[] bluf = st.Split(';');
                if (bluf[2] == AMeil.Text && bluf[3]==APass.Text)
                {

                    protect++;
                }

            }
            if(protect > 0)
            {
                Glavnaya glavnaya = new Glavnaya();
                glavnaya.Show();
                glavnaya.WindowState = FormWindowState.Maximized;
                this.Close();  
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void AMeil_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

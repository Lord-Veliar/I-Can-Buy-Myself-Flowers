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
    public partial class Profil : Form
    {

        public Profil()
        {

            InitializeComponent();


        }

        private async void Profil_Load(object sender, EventArgs e)
        {
            string logss = @"dannie.txt";
            string path = @"Аккаунты.csv";
            List<string> people = new List<string>();
            List<string> bufer = new List<string>();
            string dan;
            dan = File.ReadAllText(logss);

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
                if (bluf[2] == dan)
                {

                    RedEm.Text = bluf[2];
                    RedIm.Text = bluf[0];
                    RedFm.Text = bluf[1];
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void ResSave_Click(object sender, EventArgs e)
        {

            if (RedIm.Text != "" && RedFm.Text != "")
            {
                int cub = 0;
                int vc = 0;
                string logss = @"dannie.txt";
                string path = @"Аккаунты.csv";
                List<string> bufer = new List<string>();
                string dan;
                dan = File.ReadAllText(logss);

                using (StreamReader reader = new StreamReader(path))
                {
                    string? line;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        bufer.Add(line);
                    }
                    reader.Close();
                }
                for (int i = 0; i < bufer.Count; i++)
                {

                    string[] bluf = bufer[i].Split(';');
                    bufer[vc] = bluf[0] + ';' + bluf[1] + ';' + bluf[2] + ';' + bluf[3];
                    if (bluf[2] == dan)
                    {
                        cub = vc;
                        bufer[cub] = RedIm.Text + ';' + RedFm.Text + ';' + bluf[2] + ';' + bluf[3];

                        break;
                    }
                    vc++;


                }

                File.WriteAllText(path, "");
                File.WriteAllLines(path, bufer);
                bufer = File.ReadAllLines(path).ToList();
                MessageBox.Show("Изменения сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
           else
            {
                MessageBox.Show("Введенные данные некорректны", "Ошибка изменения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            void RedIm_TextChanged(object sender, EventArgs e)
            {

            }
        }

        private async void izmp_Click(object sender, EventArgs e)
        {
            if (RedEm.Text != "")
            {
                int cub = 0;
                int vc = 0;
                string logss = @"dannie.txt";
                string path = @"Аккаунты.csv";
                List<string> bufer = new List<string>();
                string dan;
                dan = File.ReadAllText(logss);

                using (StreamReader reader = new StreamReader(path))
                {
                    string? line;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        bufer.Add(line);
                    }
                    reader.Close();
                }
                for (int i = 0; i < bufer.Count; i++)
                {

                    string[] bluf = bufer[i].Split(';');
                    bufer[vc] = bluf[0] + ';' + bluf[1] + ';' + bluf[2] + ';' + bluf[3];
                    if (bluf[2] == dan)
                    {
                        cub = vc;
                        bufer[cub] = bluf[0] + ';' + bluf[1] + ';' + RedEm.Text + ';' + bluf[3];
                        File.WriteAllText(logss,RedEm.Text);
                        break;
                    }
                    vc++;


                }

                File.WriteAllText(path, "");
                File.WriteAllLines(path, bufer);
                bufer = File.ReadAllLines(path).ToList();
                MessageBox.Show("Изменения сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Введенные данные некорректны", "Ошибка изменения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void izmpar_Click(object sender, EventArgs e)
        {
            int cub = 0;
            int vc = 0;
            string suc="";
            string logss = @"dannie.txt";
            string path = @"Аккаунты.csv";
            List<string> bufer = new List<string>();
            string dan;
            dan = File.ReadAllText(logss);

            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    bufer.Add(line);
                }
                reader.Close();
            }
            for (int i = 0; i < bufer.Count; i++)
            {

                string[] bluf = bufer[i].Split(';');
                bufer[vc] = bluf[0] + ';' + bluf[1] + ';' + bluf[2] + ';' + bluf[3];
                if (bluf[2] == dan)
                {
                    cub = vc;
                    suc = bluf[3];
                    bufer[cub] = bluf[0] + ';' + bluf[1] + ';' + bluf[2] + ';' + Rednpass.Text;
                    break;
                }
                vc++;

            }
            if (RedPass.Text == suc && Rednpass.Text != "")
            {
                File.WriteAllText(path, "");
                File.WriteAllLines(path, bufer);
                MessageBox.Show("Изменения сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if(RedPass.Text== ""||Rednpass.Text==""||RedPass.Text!=suc)
            {
                MessageBox.Show("Введенные данные некорректны", "Ошибка изменения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Korzina korz = new Korzina();
            korz.Show();
            korz.WindowState = FormWindowState.Maximized;
            this.Close();
        }
    }
}


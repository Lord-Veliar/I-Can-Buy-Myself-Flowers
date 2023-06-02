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
            string logss = @"C:\Users\Механцевнв\source\repos\I-Can-Buy-Myself-Flowers\Flowers\bin\Debug\dannie.txt";
            string path = @"Аккаунты.csv";
            List<string> people = new List<string>();
            List<string> bufer = new List<string>();
            string dan;
           dan= File.ReadAllText(logss);

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
          //Avtoriz avtoriz = new Avtoriz();
          //  string path = @"C:\Users\Механцевнв\source\repos\I-Can-Buy-Myself-Flowers\Flowers\bin\Debug\Аккаунты.csv";
          //  List<string> people = new List<string>();
          //  List<string> bufer = new List<string>();
          //  int ind = 0;
          //  int dd=0;
          //  int idd = 0;

          //  int protect = 0;
          //  using (StreamReader reader = new StreamReader(path))
          //  {
          //      string? line;
          //      while ((line = await reader.ReadLineAsync()) != null)
          //      {
          //          bufer.Add(line);
          //      }
          //      reader.Close();
          //  }
          //  foreach (string st in bufer)
          //  {
          //      string[] bluf = st.Split(';');
          //      if (bluf[2] == avtoriz.pe)
          //      {
          //          idd = dd;
          //          RedIm.Text = bluf[0];
          //          RedFm.Text = bluf[1];
          //          RedEm.Text = bluf[2];
          //      }
          //      dd++;
          //  }
            //if (RedIm.Text!=null&&RedFm.Text!=null&&RedEm!=null)
            //{
               
            //    using (StreamWriter writer = new StreamWriter(path, true))
            //    {
            //        await writer.WriteLineAsync(people[ind] + ';' + people[ind + 1] + ';' + people[ind + 2] + ';' + people[ind + 3]);
            //        writer.Close();
            //    }
            //    ind++;
            //    Glavnaya glavnaya = new Glavnaya();
            //    I_Can_Buy_Myself_Flowers i_Can_Buy_Myself_Flowers = new I_Can_Buy_Myself_Flowers();
            //    glavnaya.Show();
            //    glavnaya.WindowState = FormWindowState.Maximized;


            }

        public void RedIm_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


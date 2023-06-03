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
            if (RedIm.Text != null && RedFm.Text != null)
            {
                int vc = 0;
                string logss = @"dannie.txt";
                string path = @"Аккаунты.csv";
                List<string> people = new List<string>();
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
                foreach (string st in bufer)
                {

                    string[] bluf = st.Split(';');
                    if (bluf[2] == dan)
                    {
                        people.Add(RedIm.Text);
                       people.Add(RedFm.Text);
                        people.Add(dan);
                        people.Add(dan);
                        break;
                    }
                    vc++;
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        await writer.WriteLineAsync(people[0] + ';' + people[1] + ';' + people[2] + ';' + people[3]);
                        writer.Close();
                    }
                }


 

                
                    //    var ModifData = File
                    //        .ReadLines(path.ToString())
                    //        .Select(line => line.Split(';'))
                    //        .Select(item => {
                    //           item[1] = item[0];
                    //            return string.Join(';', item);
                    //        })
                    //        .ToList();
                    //    File.WriteAllLines(path.ToString(), ModifData);
                    //}
                }

                void RedIm_TextChanged(object sender, EventArgs e)
                {

                }
            }
        }
    }


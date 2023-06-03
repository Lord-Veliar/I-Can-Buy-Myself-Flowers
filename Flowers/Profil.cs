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
            int cub = 0;
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
                    bufer[vc] = bluf[0] + ';' + bluf[1] + ';' + bluf[2] + ';'+bluf[3];
                    if (bluf[2] == dan)
                    {
                        bufer[vc]=RedIm.Text+';'+RedFm.Text+';'+dan+';'+dan;
                        cub = vc;
                        //bufer[vc*2]=RedFm.Text;
                        //bufer[vc * 3] = dan;
                        //bufer[vc * 4] = dan;
                        break;
                    }
                    vc++;
            
                    //using (StreamWriter writer = new StreamWriter(path, true))
                    //{
                    //    await writer.WriteLineAsync(people[0] + ';' + people[1] + ';' + people[2] + ';' + people[3]);
                    //    writer.Close();
                    //}

                }

                //using (StreamWriter writer = new StreamWriter(path, true))
                //{
                //    //for (int i = 0; i < bufer.Count; i++)
                //       writer.WriteLine(path, bufer);
                //    writer.Close();
                //}

                File.WriteAllText(path, bufer[cub]);
                File.AppendAllText(path, "\n");
                for (int i = 1; i < bufer.Count; i++)
                {
                    File.AppendAllText(path, bufer[i]);
                }

                //using (StreamWriter writer = new StreamWriter(path, true))
                //{
                //    for (int i = 0; i < bufer.Count-3; i++)
                //    {
                //        await writer.WriteLineAsync(bufer[i] + ';' + bufer[i + 1] + ';' + bufer[i + 2] + ';' + bufer[i + 3]);
                //    }

                //    writer.Close();
                //}
                //for(int i=0;i<bufer.Count-3;i++)
                //{
                //    File.WriteAllText(path, bufer[i] + ';' + bufer[i+1] + ';' + bufer[i+2] + ';' + bufer[i+3]);
                //}
                //people.Add(RedIm.Text);
                //people.Add(RedFm.Text);
                //people.Add(dan);
                //people.Add(dan);
                //File.WriteAllText(path, people[0] + ';' + people[1] + ';' + people[2] + ';' + people[3]);




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


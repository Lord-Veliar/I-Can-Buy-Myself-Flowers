namespace Flowers
{
    public partial class I_Can_Buy_Myself_Flowers : Form
    {
        public I_Can_Buy_Myself_Flowers()
        {
            InitializeComponent();
        }



        private void I_Can_Buy_Myself_Flowers_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            NameText.Enabled = false;
            NameText.Enabled = true;
            FFF.Enabled = false;
            FFF.Enabled = true;
            Email.Enabled = false;
            Email.Enabled = true;
            Pass.Enabled = false;
            Pass.Enabled = true;
            

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }





        private void NameText_Enter(object sender, EventArgs e)
        {


            if (NameText.Text == "���")
            {
                NameText.Text = "";

                NameText.ForeColor = Color.Black;
            }
        }
        public void NameText_Leave(object sender, EventArgs e)
        {
            string sname = "";
            if (NameText.Text == "")
            {
                NameText.Text = "���";
                sname = NameText.Text;
                NameText.ForeColor = Color.Gray;
            }

        }



        public void FFF_Enter(object sender, EventArgs e)
        {
            if (FFF.Text == "�������")
            {
                FFF.Text = "";

                FFF.ForeColor = Color.Black;
            }
        }

        public void FFF_Leave(object sender, EventArgs e)
        {
            if (FFF.Text == "")
            {
                FFF.Text = "�������";
                FFF.ForeColor = Color.Gray;
            }

        }

        private void Email_Enter(object sender, EventArgs e)
        {
            if (Email.Text == "Email")
            {
                Email.Text = "";

                Email.ForeColor = Color.Black;
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (Email.Text == "")
            {
                Email.Text = "Email";
                Email.ForeColor = Color.Gray;
            }
        }

        private void Pass_Enter(object sender, EventArgs e)
        {
            if (Pass.Text == "������")
            {
                Pass.Text = "";

                Pass.ForeColor = Color.Black;
            }
        }

        private void Pass_Leave(object sender, EventArgs e)
        {
            if (Pass.Text == "")
            {
                Pass.Text = "������";
                Pass.ForeColor = Color.Gray;
            }
        }

        private async void Reg_Click(object sender, EventArgs e)
        {

            string logss = @"dannie.txt";
            string ddan;
            ddan = Email.Text;
            File.WriteAllText(logss, ddan);
            string path = @"��������.csv";
            List<string> people = new List<string>();
            List<string> bufer = new List<string>();
            int ind = 0;
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
                if (bluf[2] == Email.Text)
                {
                    protect++;
                }

            }
            if (protect == 0 && NameText.Text != "���" && FFF.Text != "�������" && Email.Text != "Email" && Pass.Text != "������")
            {
                people.Add(NameText.Text);
                people.Add(FFF.Text);
                people.Add(Email.Text);
                people.Add(Pass.Text);
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    await writer.WriteLineAsync(people[ind] + ';' + people[ind + 1] + ';' + people[ind + 2] + ';' + people[ind + 3]);
                    writer.Close();
                }
                ind++;
                Glavnaya glavnaya = new Glavnaya();
                I_Can_Buy_Myself_Flowers i_Can_Buy_Myself_Flowers = new I_Can_Buy_Myself_Flowers();
                glavnaya.Show();
                glavnaya.WindowState = FormWindowState.Maximized;
          

            }
            if (protect != 0)
            {
                MessageBox.Show("���� E-mail ��� ������������ ��� ������� ��������", "������ �����������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (NameText.Text == "���" || FFF.Text == "�������" || Email.Text == "Email" || Pass.Text == "������")
            {
                MessageBox.Show("��������� ��� ������������ ����", "������ �����������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Email.Text = "Email";
            NameText.Text = "���";
            FFF.Text = "�������";
            Pass.Text = "������";

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Avtoriz avtoriz = new Avtoriz();
            avtoriz.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Avtoriz avtoriz=new Avtoriz();
            avtoriz.Show();
          avtoriz.WindowState = FormWindowState.Maximized;
     
        }

       
    }
}
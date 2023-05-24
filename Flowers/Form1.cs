namespace Flowers
{
    public partial class I_Can_Buy_Myself_Flowers : Form
    {
        public I_Can_Buy_Myself_Flowers()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.logt;
        }

        private void I_Can_Buy_Myself_Flowers_Load(object sender, EventArgs e)
        {

        }

     

        private void label1_Click(object sender, EventArgs e)
        {

        }



        

        private void NameText_Enter(object sender, EventArgs e)
        {

            if (NameText.Text == "Имя")
            {
                NameText.Text = "";

                NameText.ForeColor = Color.Black;
            }
        }
        public void NameText_Leave(object sender, EventArgs e)
        {
            string sname="";
            if (NameText.Text == "")
            {
                NameText.Text = "Имя";
                sname = NameText.Text;
                NameText.ForeColor = Color.Gray;
            }
            
        }



        public void FFF_Enter(object sender, EventArgs e)
        {

            if (FFF.Text == "Фамилия")
            {
                FFF.Text = "";

                FFF.ForeColor = Color.Black;
            }
        }

        public void FFF_Leave(object sender, EventArgs e)
        {
            if (FFF.Text == "")
            {
                FFF.Text = "Фамилия";
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
            if (Pass.Text == "Пароль")
            {
                Pass.Text = "";

                Pass.ForeColor = Color.Black;
            }
        }

        private void Pass_Leave(object sender, EventArgs e)
        {
            if (Pass.Text == "")
            {
                Pass.Text = "Пароль";
                Pass.ForeColor = Color.Gray;
            }
        }

        private async void Reg_Click(object sender, EventArgs e)
        {
            string path = @"X:\UP\flowers\flowers\bin\Debug\Аккаунты.csv";
            List<string> people = new List<string>();
            int ind = 0;
            people.Add(NameText.Text);
            people.Add(FFF.Text);

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                await writer.WriteLineAsync(people[ind] + ';' + people[ind + 1]);

            }
            ind++;
        }
    }
}
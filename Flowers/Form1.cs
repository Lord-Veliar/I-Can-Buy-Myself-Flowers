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
            NameText.Cursor = Cursors.No;
            if (NameText.Text == "Имя")
            {
                NameText.Text = "";

                NameText.ForeColor = Color.Black;
            }
        }
        private void NameText_Leave(object sender, EventArgs e)
        {
            if (NameText.Text == "")
            {
                NameText.Text = "Имя";

                NameText.ForeColor = Color.Gray;
            }
        }



        private void FFF_Enter(object sender, EventArgs e)
        {

            if (FFF.Text == "Фамилия")
            {
                FFF.Text = "";

                FFF.ForeColor = Color.Black;
            }
        }

        private void FFF_Leave(object sender, EventArgs e)
        {
            if (FFF.Text == "")
            {
                FFF.Text = "Фамилия";

                FFF.ForeColor = Color.Gray;
            }
        }

    }
}
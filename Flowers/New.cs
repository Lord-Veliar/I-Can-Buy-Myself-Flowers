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
    public partial class New : Form
    {
        public New()
        {
            InitializeComponent();
        }

        private void Korzina_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Korzina korz = new Korzina();
            korz.Show();
            korz.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            profil.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void glav_Click(object sender, EventArgs e)
        {
            Glavnaya glavnaya = new Glavnaya();
            glavnaya.Show();
            glavnaya.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Show();
            test.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Big big = new Big();
            big.Show();
            big.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            animals animals = new animals();
            animals.Show();
            animals.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            light light = new light();
            light.Show();
            light.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void first_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rastenia rastenia = new Rastenia();
            rastenia.Show();
            rastenia.WindowState = FormWindowState.Maximized;
            this.Close();
            rastenia.label666.Text = "Антуриум";
            rastenia.Pis.Text = "Антуриум оправдывает свое прозвище цветок фламинго\n. Антуриумы, редко лишенные эффектного цветения, известны \nкак самое длинное цветущее комнатное растение \nв мире." +
                "Это не настоящие цветы, \nа видоизмененные восковые листья.";
            rastenia.Ruc.Text = "- Хорошо себя чувствует при ярком непрямом свете, но может переносить \nсредний непрямой свет. \n" +
                "- Поливают раз в 1-2 недели, давая почве просыхать между поливами. \n";
            rastenia.price.Text = "6310";
            rastenia.pic.Image = Properties.Resources.Антуриум1;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rastenia rastenia = new Rastenia();
            rastenia.Show();
            rastenia.WindowState = FormWindowState.Maximized;
            this.Close();
            rastenia.label666.Text = "Денежное Дерево";
            rastenia.Pis.Text = "Говорят, что денежное дерево приносит удачу \nи удачу, является идеальным растением, которое \nможно добавить в любую комнату вашего \nдома, чтобы создать хороший фэн-шуй. ";
            rastenia.Ruc.Text = "- Хорошо себя чувствует при ярком непрямом и среднем освещении.\n" +
                "- Поливают раз в 1-2 недели, давая почве просыхать между поливами.\n" +
                "- Это растение дружелюбное к домашним животным.";
            rastenia.price.Text = "5499";
            rastenia.pic.Image = Properties.Resources.денежное;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rastenia rastenia = new Rastenia();
            rastenia.Show();
            rastenia.WindowState = FormWindowState.Maximized;
            this.Close();
            rastenia.label666.Text = "Мирная лилия 'Домино'";
            rastenia.Pis.Text = "Мирная лилия 'Домино' - это новый \nгибрид спатифиллума, забрызганный белой пестротой на \nкаждом листе. При ярком освещении мирные \nлилии будут цвести высокими белыми цветами \nкруглый год. Эти растения известны \nсвоими чрезмерными способами дать вам понять, \nчто они нуждаются во внимании, в \nчастности, плюхаясь самым драматичным образом, когда им нужна вода.";
            rastenia.Ruc.Text = "- Хорошо себя чувствует при среднем и ярком непрямом свете, но может переносить слабый непрямой свет.\n" +
                "- Поливают раз в 1-2 недели, давая почве просыхать между поливами.";
            rastenia.price.Text = "7699";
            rastenia.pic.Image = Properties.Resources.Мирная_лилия_Домино1;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rastenia rastenia = new Rastenia();
            rastenia.Show();
            rastenia.WindowState = FormWindowState.Maximized;
            this.Close();
            rastenia.label666.Text = "Хойя Харт";
            rastenia.Pis.Text = "Хойю керрии обычно называют сердцем хойи из-за \nее зеленых сердцевидных листьев. Это срезание одного листа - \nвеселый, причудливый способ показать свою любовь к растению. \nОн частично укоренен, но не имеет узла. \nОн останется очаровательным сердцевидным листом на долгие годы.";
            rastenia.Ruc.Text = "- Влажность. Высокая, рекомендуется регулярное опрыскивание.\n" +
                "- Хорошо себя чувствует при ярком прямом свете, но может переносить яркий непрямой свет.\n" +
                "- Поливайте раз в 2-3 недели под прямым светом, давая почве просыхать между поливами.\n" +
                "- Это растение, дружелюбное к домашним животным.";
            rastenia.price.Text = "3899";
            rastenia.pic.Image = Properties.Resources.Хойя;
        }
    }
}

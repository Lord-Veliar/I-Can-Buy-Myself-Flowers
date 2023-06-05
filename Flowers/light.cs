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
    public partial class light : Form
    {
        public light()
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

        private void button14_Click(object sender, EventArgs e)
        {
            New @new = new New();
            @new.Show();
            @new.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            animals animals = new animals();
            animals.Show();
            animals.WindowState = FormWindowState.Maximized;
            animals.Close();
        }

        private void first_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rastenia rastenia = new Rastenia();
            rastenia.Show();
            rastenia.WindowState = FormWindowState.Maximized;
            this.Close();
            rastenia.label666.Text = "Большая драцена с лимоном и лаймом";
            rastenia.Pis.Text = "Этот цветок с виду напоминает пальму, \nхотя не имеет к ней совершенно \nникакого отношения." +
                "Его неветвящиеся стебли сплошь \nпокрыты большими листьями с продольными полосками. \nОднако спустя несколько лет драцена лайм \nвытягивается в высоту, и ствол оголяется.";
            rastenia.Ruc.Text = "- Растение любит тепло и повышенную влажность.\n" +
                "- Любит яркое освещение, но свет при этом должен быть рассеянным.\n" +
                "- Не забудьте про обожаемую драценой процедуру – еженедельный душ.";
            rastenia.price.Text = "10231";
            rastenia.pic.Image = Properties.Resources.драцена;
        }

        private void l(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rastenia rastenia = new Rastenia();
            rastenia.Show();
            rastenia.WindowState = FormWindowState.Maximized;
            this.Close();
            rastenia.label666.Text = "Потос Нью-Джей";
            rastenia.Pis.Text = "Pothos Njoy, научно известный как Epipremnum aureum 'n'joy', \nпредставляет собой висячее комнатное растение с \nпоразительной пестрой листвой. За этим растением \nне требующим особого ухода, легко ухаживать, \nкак и за другими потосами, но \nдля поддержания его кремовой пестроты требуется более яркий свет.";
            rastenia.Ruc.Text = "- Хорошо себя чувствует при среднем и слабом непрямом освещении. Не подходит для интенсивных прямых солнечных лучей.\n" +
                "- Поливают раз в 1-2 недели, давая почве просыхать между поливами.";
            rastenia.price.Text = "4699";
            rastenia.pic.Image = Properties.Resources.Потос;
        }
    }
}

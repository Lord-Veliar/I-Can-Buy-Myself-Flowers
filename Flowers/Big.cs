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
    public partial class Big : Form
    {
        public Big()
        {
            InitializeComponent();
        }

        private void Korzina_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Korzina korzina = new Korzina();
            korzina.Show();
            korzina.WindowState = FormWindowState.Maximized;
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
            test.WindowState= FormWindowState.Maximized;
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
            rastenia.label666.Text = "Банан Комнатный";
            rastenia.pic.Image = Properties.Resources.банан_комнатный1;
            rastenia.Pis.Text = "Травянистое плодовое растение банан домашний " +
                "является \nчастью семейства Банановые. В природе его \nможно повстречать в Австралии, Эквадоре и \nМексике, причем оно предпочитает расти в \nрегионах с тропическим климатом." +
                "Вырастить такое \nнеобычное для комнатной культуры растение можно \nи цветоводу. При правильном уходе в \nтечение года в росте оно может \nприбавить около 100 см.";
            rastenia.Ruc.Text = "- Регулярно взрыхляйте почву.\n" +
                "- Полив проводите обильно, но нечасто.\n" +
                "- Необходимо строго следить за соблюдением температурного режима, чтобы дерево \nне засохло. Оптимальная температура для роста +25+30.";
            rastenia.price.Text = "2566";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rastenia rastenia = new Rastenia();
            rastenia.Show();
            rastenia.WindowState = FormWindowState.Maximized;
            this.Close();
            rastenia.label666.Text = "Большая Райская Птица";
            rastenia.Pis.Text = "Райская птица своими широкими яркими зелеными \nлистьями привносит нотку тропиков в любую \nкомнату. Он назван в честь своих \nуникальных цветов, которые напоминают ярко окрашенных \nптиц в полете. ";
            rastenia.Ruc.Text = "- Хорошо себя чувствует при ярком непрямом и прямом свете.\n" +
                "- Поливают раз в 1-2 недели, давая почве просыхать между поливами.";
            rastenia.price.Text = "18440";
            rastenia.pic.Image = Properties.Resources.Большая_райская_птица1;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rastenia rastenia = new Rastenia();
            rastenia.Show();
            rastenia.WindowState = FormWindowState.Maximized;
            this.Close();
            rastenia.label666.Text = "Фикус";
            rastenia.Pis.Text = "Вечнозеленая культура, имеет форму дерева или \nкустарника. В природе достигает 20 м, \nа в помещениях — не более двух метров.";
            rastenia.Ruc.Text = "- Все виды любят высокую влажность воздуха, хорошее освещение, умеренную температуру воздуха. \n" +
                "- Это теплолюбивое растение. От сквозняков может сбросить листву.\n" +
                "- Любят высокую влажность. ";
            rastenia.price.Text = "2050";
            rastenia.pic.Image = Properties.Resources.фикус;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rastenia rastenia = new Rastenia();
            rastenia.Show();
            rastenia.WindowState = FormWindowState.Maximized;
            this.Close();
            rastenia.label666.Text = "Шеффлера";
            rastenia.Pis.Text = "Такое растение, как шефлера либо шеффлера (Schefflera) относится к семейству, именуемому \nаралиевые. В диких условиях его можно повстречать в тропиках в любой части земли. \nА чаще всего оно встречается на территории \nАвстралии, Китая, на островах Тихого океана и в Японии. \nДикорастущая шеффлера представляет \nсобой не очень большие деревца либо кусты.\nДанное растение очень ценят цветоводы за \nкрасивые, эффектные листья, которые весьма схожи \nс человеческой ладонью, пальцы коей расставлены далеко друг от друга.";
            rastenia.Ruc.Text = "- Влажность. Высокая, рекомендуется регулярное опрыскивание.\n" +
                "- Шеффлера в домашних условиях нуждается в ярком рассеянном освещении, оптимальное место – восточный подоконник.\n" +
                "- Полив. Умеренный, избегать переувлажнения.";
            rastenia.price.Text = "13900";
            rastenia.pic.Image = Properties.Resources.Шеффлера1;
        }
    }
}

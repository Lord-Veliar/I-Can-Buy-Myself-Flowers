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
    public partial class animals : Form
    {
        public animals()
        {
            InitializeComponent();
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
            @new.WindowState= FormWindowState.Maximized;
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            light light = new light();
            light.Show();
            light.WindowState = FormWindowState.Maximized;
            this.Close();
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

        private void first_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rastenia rastenia = new Rastenia();
            rastenia.Show();
            rastenia.WindowState = FormWindowState.Maximized;
            this.Close();
            rastenia.label666.Text = "Калатея Гремучая Змея";
            rastenia.pic.Image = Properties.Resources.Калатея_Гремучая_змея1;
            rastenia.Pis.Text = "Калатея гремучая змея известна своими длинными\nволнистыми " +
                "зелеными листьями с рисунком мазка, \nнапоминающим кожу рептилии. \n" +
                "Он поднимает и опускает эти листья изо дня в день, \nэто явлениеназывется никтинастией, " +
                "и источник его \nпрозвища «молитвенное растение». " +
                "\nЭто растение подходит для домашних животных!";
            rastenia.Ruc.Text = "- Хорошо растет при непрямом освещении от среднего до яркого, \nно может переносить слабое непрямое освещение." +
                "\n- Поливайте каждые 1-2 недели, позволяя почве просохнуть наполовину между \nполивами. Ожидайте поливать чаще при ярком свете и реже при слабом. \nЭтому растению может быть полезна дополнительная влажность. Калатеи могут быть \nчувствительны к жесткой водопроводной воде. Попробуйте использовать фильтрованную воду или \nоставьте воду на ночь перед использованием." +
                "\n- Это растение подходит для домашних животных.";
            rastenia.price.Text = "4699";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rastenia rastenia = new Rastenia();
            rastenia.Show();
            rastenia.WindowState = FormWindowState.Maximized;
            this.Close();
            rastenia.label666.Text = "Оливковое Дерево";
            rastenia.Pis.Text = "Эти средиземноморские растения нуждаются в большом \nколичестве ярких прямых солнечных лучей. Окна, \nвыходящие на юг и запад, идеально \nподходят. Допускается размещение с домашними животными. ";
            rastenia.Ruc.Text = "- Хорошо себя чувствует при ярком освещении и полном солнце. \n" +
                "- Поливайте каждую неделю, позволяя почве просыхать на полпути между поливами.";
            rastenia.price.Text = "6300";
            rastenia.pic.Image = Properties.Resources.оливковое;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rastenia rastenia = new Rastenia();
            rastenia.Show();
            rastenia.WindowState = FormWindowState.Maximized;
            this.Close();
            rastenia.label666.Text = "Приятный кактус";
            rastenia.Pis.Text = "Приятный кактус получил свое название из-за \nотсутствия скоплений колючек, что делает его \nбезопасным вариантом для содержания рядом с \nдомашними животными и детьми. Как и \nбольшинство кактусов, вечнозеленый кактус цереус засухоустойчив \nи любит солнце.";
            rastenia.Ruc.Text = "- Хорошо себя чувствует при ярком освещении и полном солнце. \nНе подходит для помещений с низкой освещенностью.\n" +
                "- Поливайте каждые 2-3 недели, позволяя почве тщательно просыхать между поливами.";
            rastenia.price.Text = "5499";
            rastenia.pic.Image = Properties.Resources.Приятный_кактус1;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rastenia rastenia = new Rastenia();
            rastenia.Show();
            rastenia.WindowState = FormWindowState.Maximized;
            this.Close();
            rastenia.label666.Text = "Эхеверия Пелусида";
            rastenia.Pis.Text = "Эхеверия Пелусида имеет красивую сине-зеленую листву \nс красноватыми краями, которые растут плотной розеткой. \nПри соблюдении оптимальных условий такого легкого ухода, \nзасухоустойчивый суккулент вознаградит вас яркими желтыми цветами весной!";
            rastenia.Ruc.Text = "- Хорошо себя чувствует при ярком прямом свете, но может переносить яркий непрямой свет.\n" +
                "- Поливайте раз в 2-3 недели под прямым светом, давая почве просыхать между поливами.\n" +
                "- Большинство эхеверий дружелюбны к домашним животным!";
            rastenia.price.Text = "4699";
            rastenia.pic.Image = Properties.Resources.Эхеверия;
        }
    }
}

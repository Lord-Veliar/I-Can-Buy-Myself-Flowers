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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        
        }



        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button1.Enabled = false; 
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Rastenia rastenia = new Rastenia();
            if(button1.Enabled==false&&button4.Enabled==false&&button5.Enabled==false&&button7.Enabled==false&&button10.Enabled==false)
            {
                rastenia.Show();
                rastenia.WindowState=FormWindowState.Maximized;
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
            if (button1.Enabled == false && button4.Enabled == false && button6.Enabled == false && button7.Enabled == false && button9.Enabled == false)
            {
                rastenia.Show();
                rastenia.WindowState = FormWindowState.Maximized;
                this.Close();
                rastenia.label666.Text = "Банан Комнатный";
                rastenia.pic.Image = Properties.Resources.банан_комнатный1;
            }
            if (button2.Enabled == false && button3.Enabled == false && button5.Enabled == false && button8.Enabled == false && button10.Enabled == false)
            {
                rastenia.Show();
                rastenia.WindowState = FormWindowState.Maximized;
                this.Close();
                rastenia.label666.Text = "Антуриум";
                rastenia.pic.Image = Properties.Resources.Антуриум1;
            }
            if (button2.Enabled == false && button3.Enabled == false && button6.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                rastenia.Show();
                rastenia.WindowState = FormWindowState.Maximized;
                this.Close();
                rastenia.label666.Text = "Большая Драцена С Лимоном И Лаймом";
                rastenia.pic.Image = Properties.Resources.драцена;
            }
            if (button1.Enabled == false && button3.Enabled == false && button5.Enabled == false && button7.Enabled == false && button10.Enabled == false)
            {
                rastenia.Show();
                rastenia.WindowState = FormWindowState.Maximized;
                this.Close();
                rastenia.label666.Text = "Оливковое Дерево";
                rastenia.pic.Image = Properties.Resources.оливковое;
            }
            if (button1.Enabled == false && button3.Enabled == false && button6.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                rastenia.Show();
                rastenia.WindowState = FormWindowState.Maximized;
                this.Close();
                rastenia.label666.Text = "Большая Райская Птица";
                rastenia.pic.Image = Properties.Resources.Большая_райская_птица1;
            }
            if (button1.Enabled == false && button4.Enabled == false && button6.Enabled == false && button7.Enabled == false && button10.Enabled == false)
            {
                rastenia.Show();
                rastenia.WindowState = FormWindowState.Maximized;
                this.Close();
                rastenia.label666.Text = "Денежное Дерево";
                rastenia.pic.Image = Properties.Resources.денежное;
            }
            if (button2.Enabled == false && button4.Enabled == false && button5.Enabled == false && button7.Enabled == false && button10.Enabled == false)
            {
                rastenia.Show();
                rastenia.WindowState = FormWindowState.Maximized;
                this.Close();
                rastenia.label666.Text = "Калатея Вэйвстар";
                rastenia.pic.Image = Properties.Resources.Калатея_Вейвстар1;
            }
            if (button1.Enabled == false && button3.Enabled == false && button5.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                rastenia.Show();
                rastenia.WindowState = FormWindowState.Maximized;
                this.Close();
                rastenia.label666.Text = "Фикус";
                rastenia.pic.Image = Properties.Resources.фикус;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button6.Enabled = true;
            button5.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button7.Enabled = true;
            button8.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button8.Enabled = true;
            button7.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button1.Enabled=false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button4.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button6.Enabled = false;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            button10.Enabled = true;
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button9.Enabled = true;
            button10.Enabled = false;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Location = new Point(label1.Location.X+2);
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Glavnaya glavnaya = new Glavnaya();
            glavnaya.Show();
            glavnaya.WindowState = FormWindowState.Maximized;
            this.Close();
        }
    }
}

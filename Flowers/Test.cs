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
            }
            if (button1.Enabled == false && button4.Enabled == false && button6.Enabled == false && button7.Enabled == false && button9.Enabled == false)
            {
                rastenia.Show();
                rastenia.WindowState = FormWindowState.Maximized;
                this.Close();
                rastenia.label666.Text = "Банан Комнатный";
            }
            if (button2.Enabled == false && button3.Enabled == false && button5.Enabled == false && button8.Enabled == false && button10.Enabled == false)
            {
                rastenia.Show();
                rastenia.WindowState = FormWindowState.Maximized;
                this.Close();
                rastenia.label666.Text = "Антуриум";
            }
            if (button2.Enabled == false && button3.Enabled == false && button6.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                rastenia.Show();
                rastenia.WindowState = FormWindowState.Maximized;
                this.Close();
                rastenia.label666.Text = "Большая Драцена С Лимоном И Лаймом";
            }
            if (button1.Enabled == false && button3.Enabled == false && button5.Enabled == false && button7.Enabled == false && button10.Enabled == false)
            {
                rastenia.Show();
                rastenia.WindowState = FormWindowState.Maximized;
                this.Close();
                rastenia.label666.Text = "Оливковое Дерево";
            }
            if (button1.Enabled == false && button3.Enabled == false && button6.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                rastenia.Show();
                rastenia.WindowState = FormWindowState.Maximized;
                this.Close();
                rastenia.label666.Text = "Большая Райская Птица";
            }
            if (button1.Enabled == false && button4.Enabled == false && button6.Enabled == false && button7.Enabled == false && button10.Enabled == false)
            {
                rastenia.Show();
                rastenia.WindowState = FormWindowState.Maximized;
                this.Close();
                rastenia.label666.Text = "Денежное Дерево";
            }
            if (button2.Enabled == false && button4.Enabled == false && button5.Enabled == false && button7.Enabled == false && button10.Enabled == false)
            {
                rastenia.Show();
                rastenia.WindowState = FormWindowState.Maximized;
                this.Close();
                rastenia.label666.Text = "Калатея Вэйвстар";
            }
            if (button1.Enabled == false && button3.Enabled == false && button5.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                rastenia.Show();
                rastenia.WindowState = FormWindowState.Maximized;
                this.Close();
                rastenia.label666.Text = "Фикус";
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

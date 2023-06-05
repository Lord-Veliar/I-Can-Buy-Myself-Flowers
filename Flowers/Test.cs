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
            int crak = 0;
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
                crak++;
            }
            if (button1.Enabled == false && button4.Enabled == false && button6.Enabled == false && button7.Enabled == false && button9.Enabled == false)
            {
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
                crak++;
            }
            if (button2.Enabled == false && button3.Enabled == false && button5.Enabled == false && button8.Enabled == false && button10.Enabled == false)
            {
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
                crak++;
            }
            if (button2.Enabled == false && button3.Enabled == false && button6.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
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
                crak++;
            }
            if (button1.Enabled == false && button3.Enabled == false && button5.Enabled == false && button7.Enabled == false && button10.Enabled == false)
            {
                rastenia.Show();
                rastenia.WindowState = FormWindowState.Maximized;
                this.Close();
                rastenia.label666.Text = "Оливковое Дерево";
                rastenia.Pis.Text = "Эти средиземноморские растения нуждаются в большом \nколичестве ярких прямых солнечных лучей. Окна, \nвыходящие на юг и запад, идеально \nподходят. Допускается размещение с домашними животными. ";
                rastenia.Ruc.Text = "- Хорошо себя чувствует при ярком освещении и полном солнце. \n" +
                    "- Поливайте каждую неделю, позволяя почве просыхать на полпути между поливами.";
                rastenia.price.Text = "6300";
                rastenia.pic.Image = Properties.Resources.оливковое;
                crak++;
            }
            if (button1.Enabled == false && button3.Enabled == false && button6.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                rastenia.Show();
                rastenia.WindowState = FormWindowState.Maximized;
                this.Close();
                rastenia.label666.Text = "Большая Райская Птица";
                rastenia.Pis.Text = "Райская птица своими широкими яркими зелеными \nлистьями привносит нотку тропиков в любую \nкомнату. Он назван в честь своих \nуникальных цветов, которые напоминают ярко окрашенных \nптиц в полете. ";
                rastenia.Ruc.Text = "- Хорошо себя чувствует при ярком непрямом и прямом свете.\n" +
                    "- Поливают раз в 1-2 недели, давая почве просыхать между поливами.";
                rastenia.price.Text = "18440";
                rastenia.pic.Image = Properties.Resources.Большая_райская_птица1;
                crak++;
            }
            if (button1.Enabled == false && button4.Enabled == false && button6.Enabled == false && button7.Enabled == false && button10.Enabled == false)
            {
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
                crak++;
            }
            if (button2.Enabled == false && button4.Enabled == false && button5.Enabled == false && button7.Enabled == false && button10.Enabled == false)
            {
                rastenia.Show();
                rastenia.WindowState = FormWindowState.Maximized;
                this.Close();
                rastenia.label666.Text = "Калатея Вэйвстар";
                rastenia.Pis.Text = "Калатея, из чьих листьев индейцы плели \nкорзины, в наших домах не просто \nукрашение, а одно из самых полезных \nрастений. Она способна поглощать вредные вещества \nиз воздуха и нейтрализовать их, перерабатывать \nуглекислый газ в кислород и способствует \nповышению влажности воздуха. ";
                rastenia.Ruc.Text = "- Важным является температура содержания – 22 – 24 °С.\n" +
                    "- Прямые солнечные лучи вызывают ожоги листьев. \n" +
                    "- Высокий уровень влажности воздуха – важнейший критерий для успешного выращивания калатеи.";
                rastenia.price.Text = "3000";
                rastenia.pic.Image = Properties.Resources.Калатея_Вейвстар1;
                crak++;
            }
            if (button1.Enabled == false && button3.Enabled == false && button5.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
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
                crak++;
            }
            if(crak==0)
            {
                MessageBox.Show("К сожалению мы не смогли подобрать для Вас подходящее растение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Glavnaya glavnaya = new Glavnaya();
                glavnaya.Show();
                glavnaya.WindowState = FormWindowState.Maximized;
                this.Close();
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

        private void glav_Click(object sender, EventArgs e)
        {
            Glavnaya glavnaya = new Glavnaya();
            glavnaya.Show();
            glavnaya.WindowState=FormWindowState.Maximized;
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {

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

        private void button12_Click_1(object sender, EventArgs e)
        {
            light light = new light();
            light.Show();
            light.WindowState = FormWindowState.Maximized;
            this.Close();
        }
    }
}

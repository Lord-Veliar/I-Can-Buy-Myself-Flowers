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
    public partial class Glavnaya : Form
    {
        public Glavnaya()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Glavnaya glavnaya = new Glavnaya();
            Test test = new Test();

            test.Show();
            test.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void banana_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            profil.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }

        private void Korzina_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Korzina korz = new Korzina();
            korz.Show();
            korz.WindowState = FormWindowState.Maximized;

        }

        private void Glavnaya_Load(object sender, EventArgs e)
        {

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

        private void banan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void third_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void lime_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void olive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void big_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void money_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void kaktus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void Ficus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void lilia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rastenia rastenia = new Rastenia();
            rastenia.Show();
            rastenia.WindowState= FormWindowState.Maximized;
            this.Close();
            rastenia.label666.Text = "Мирная лилия 'Домино'";
            rastenia.Pis.Text = "Мирная лилия 'Домино' - это новый \nгибрид спатифиллума, забрызганный белой пестротой на \nкаждом листе. При ярком освещении мирные \nлилии будут цвести высокими белыми цветами \nкруглый год. Эти растения известны \nсвоими чрезмерными способами дать вам понять, \nчто они нуждаются во внимании, в \nчастности, плюхаясь самым драматичным образом, когда им нужна вода.";
            rastenia.Ruc.Text = "- Хорошо себя чувствует при среднем и ярком непрямом свете, но может переносить слабый непрямой свет.\n" +
                "- Поливают раз в 1-2 недели, давая почве просыхать между поливами.";
            rastenia.price.Text = "7699";
            rastenia.pic.Image = Properties.Resources.Мирная_лилия_Домино1;
        }

        private void NJ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rastenia rastenia = new Rastenia();
            rastenia.Show();
            rastenia.WindowState= FormWindowState.Maximized;
            this.Close();
            rastenia.label666.Text = "Потос Нью-Джей";
            rastenia.Pis.Text = "Pothos Njoy, научно известный как Epipremnum aureum 'n'joy', \nпредставляет собой висячее комнатное растение с \nпоразительной пестрой листвой. За этим растением \nне требующим особого ухода, легко ухаживать, \nкак и за другими потосами, но \nдля поддержания его кремовой пестроты требуется более яркий свет.";
            rastenia.Ruc.Text = "- Хорошо себя чувствует при среднем и слабом непрямом освещении. Не подходит для интенсивных прямых солнечных лучей.\n" +
                "- Поливают раз в 1-2 недели, давая почве просыхать между поливами.";
            rastenia.price.Text = "4699";
            rastenia.pic.Image = Properties.Resources.Потос;
        }

        private void E_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void Five_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void HH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }
    }
}

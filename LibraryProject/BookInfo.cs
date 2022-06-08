using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class BookInfo : Form
    {
        public BookInfo()
        {
            InitializeComponent();
        }
        private const int CS_DropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            Library f = new Library();
            f.Show();
            this.Hide();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BookInfo_Load(object sender, EventArgs e)
        {
            RemoveMeBtn.Enabled = false;
            GiveInfo();
            int bookNumber = Global.BookInfo;
            for (int i = 0; i < Global.FavouriteBooks.Count(); i++)
            {
                if (Global.FavouriteBooks.Count(n => n == bookNumber) >= 1)
                {
                    FavouriteBtn.Enabled = false;
                    RemoveMeBtn.Enabled = true;
                }
            }
        }

        private void FavouriteBtn_Click(object sender, EventArgs e)
        {
            Global.FavouriteBooks.Add(Global.BookInfo);
            FavouriteBtn.Enabled = false;
            RemoveMeBtn.Enabled = true;
        }

        private void RemoveMeBtn_Click(object sender, EventArgs e)
        {
            Global.FavouriteBooks.Remove(Global.BookInfo);
            RemoveMeBtn.Enabled = false;
            FavouriteBtn.Enabled = true;
        }

        public void GiveInfo()
        {
            switch (Global.BookInfo)
            {
                case 1:
                    label1.Text = "Железния светилник";
                    BookCover1.Image = Properties.Resources.SvetilnikBook;
                    label3.Text = "Димитър Талев";
                    label2.Text = "Родното и чуждото";
                    label4.Text = "Романът е базиран в измисления град Преспа (кръстен на областта Преспа, но всъщност родния град на Талев Прилеп) и проследява съдбата на едно типично възрожденско семейство.";
                    break;
                case 2:
                    label1.Text = "Бай Ганьо журналист";
                    BookCover1.Image = Properties.Resources.BaiGBook;
                    label3.Text = "Алеко Контстантинов";
                    label2.Text = "Родното и чуждото";
                    label4.Text = "Произведението се състои от две части. Отделните фейлетони са представени от името на различни разказвачи от група съмишленици, които споделят Бай Ганьовите приключения помежду си.";
                    break;
                case 3:
                    label1.Text = "Балкански синдром";
                    BookCover1.Image = Properties.Resources.SindromBook;
                    label3.Text = "Станислав Стратиев";
                    label2.Text = "Родното и чуждото";
                    label4.Text = "Нарисувана е една колажна картина на българските нрави, взаимоотношения, конфликти, олицетворени от „малкия човек”, който и преди, и сега е в безизходица и търси абсурден изход за себе си.";
                    break;
                case 4:
                    label1.Text = "Паисий";
                    BookCover1.Image = Properties.Resources.ENZBook;
                    label3.Text = "Иван Вазов";
                    label2.Text = "Миналото и паметта";
                    label4.Text = "Водата „Паисий“ поетът описва значимостта на делото и определя написването на „История славянобългарска“ като събитие, променило българската история.";
                    break;
                case 5:
                    label1.Text = "История";
                    BookCover1.Image = Properties.Resources.VapcarovBook;
                    label3.Text = "Никола Вапцаров";
                    label2.Text = "Миналото и паметта";
                    label4.Text = "Откровен разказ за реалния живот на социално незначителните, който „мирише” и „горчи като отрова”, по вина на който „като мухи сме мрели есен” и в който в сблъсък между поколенията покълват борческите надежди „ за нещо хубаво и светло”";
                    break;
                case 6:
                    label1.Text = "Ноев Ковчег";
                    BookCover1.Image = Properties.Resources.NoevBook;
                    label3.Text = "Йордан Радичков";
                    label2.Text = "Миналото и паметта";
                    label4.Text = "Романът включва 13/тринадесет/ отделни разказа с различен обем, в които съжителстват животни от дивата природа и хора от питомния свят, като животните са очовечени, а хората са оварварени.";
                    break;
                case 7:
                    label1.Text = "Борба";
                    BookCover1.Image = Properties.Resources.BorbaBook;
                    label3.Text = "Христо Ботев";
                    label2.Text = "Обществото и властта";
                    label4.Text = "„Борба” е първото стихотворение от цикъла, което не е изповед към майка, баща, либе, народ или приятел. Заглавието е насочено към борбата в най-широк аспект. Жанрът е стихотворение, но съдържа елементи и от други жанрове";
                    break;
                case 8:
                    label1.Text = "Андрешко";
                    BookCover1.Image = Properties.Resources.AndreshkoBook;
                    label3.Text = "Елин Пелин";
                    label2.Text = "Обществото и властта";
                    label4.Text = "Елин-Пелиновият разказ е построен на основата на диалог и пейзаж, като диалогът характеризира героите, а пейзажът разкрива косвено, метафорично авторовата хуманистична и демократична позиция.";
                    break;
                case 9:
                    label1.Text = "Приказка за стълбата";
                    BookCover1.Image = Properties.Resources.StulbataBook;
                    label3.Text = "Христо Смирненски";
                    label2.Text = "Обществото и властта";
                    label4.Text = "Наддаващ полемичен диалог между човека и дявола, в който дяволското унищожава човешкото;";
                    break;
                case 10:
                    label1.Text = "До моето първо либе";
                    BookCover1.Image = Properties.Resources.LibeBook;
                    label3.Text = "Христо Ботев";
                    label2.Text = "Живота и смъртта";
                    label4.Text = "Следи въображаемия разговор с любимата , в който категорично прозвучават  подканите „ Остави таз песен любовна” ,”Забрави ти онез полуди”, „О, махни тез думи отровни”, „…изгоро, свести се!” и  многократно са изречени призивните глаголи „чуй” и „запей” , изискващи  безусловно приемане на избора на героичното „сърце ранено”.";
                    break;
                case 11:
                    label1.Text = "Новото гробище на сливница";
                    BookCover1.Image = Properties.Resources.ENZBook;
                    label3.Text = "Иван Вазов";
                    label2.Text = "Живота и смъртта";
                    label4.Text = "7 строфи, които последователно разказват за безсмъртните мъртви, които с живота и смъртта си пишат новата епопейна история на забравените и незабравимите.";
                    break;
                case 12:
                    label1.Text = "Крадецът на праскови";
                    BookCover1.Image = Properties.Resources.KradecaBook;
                    label3.Text = "Емилиян Станев";
                    label2.Text = "Живота и смъртта";
                    label4.Text = "Действието се развива в Търново и в околностите на града; Като композиционна времева  рамка на повестта стои Втората световна война, а разказаната трагична любовна история на Иво и Елисавета е събитийно разгърната на фона на Първата световна война.";
                    break;
                case 13:
                    label1.Text = "При рилския манастир";
                    BookCover1.Image = Properties.Resources.VLRBook;
                    label3.Text = "Иван Вазов";
                    label2.Text = "Природата";
                    label4.Text = "В осем строфи е аргументирана позитивно изграждащата връзка  между човека и природата; От божествения природен свят и близостта с него човек получава в пълна мяра:";
                    break;
                case 14:
                    label1.Text = "Градушка";
                    BookCover1.Image = Properties.Resources.QvorBook;
                    label3.Text = "Пейо Яворов";
                    label2.Text = "Природата";
                    label4.Text = "Шест части проследяват като описание, повествование и преживяване досегашните беди и сегашното  приближаване, разразяване и страшни последици от градушката; Изградени са два паралелни, взаимносвързани образа, като този на природата формира този на човека.";
                    break;
                case 15:
                    label1.Text = "Спи езерото";
                    BookCover1.Image = Properties.Resources.SpiBook;
                    label3.Text = "Пенчо Славейков";
                    label2.Text = "Природата";
                    label4.Text = "В две четиристишни строфи са съзерцателно огледани две свързани описания на реалния красив образ и неговата отразена сянка.";
                    break;
                default:
                    break;
            }
        }
    }
}

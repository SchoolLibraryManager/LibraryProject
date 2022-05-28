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
    public partial class Library : Form
    {
        public Library()
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.Show();
            this.Hide();
        }

        private void Library_Load(object sender, EventArgs e)
        {
            CheckPage();
        }

        private void BookCover1_Click(object sender, EventArgs e)
        {
            Global.BookInfo = Global.BookCover1;
            ShowInfo();
        }

        private void BookCover2_Click(object sender, EventArgs e)
        {
            Global.BookInfo = Global.BookCover2;
            ShowInfo();
        }

        private void BookCover3_Click(object sender, EventArgs e)
        {
            Global.BookInfo = Global.BookCover3;
            ShowInfo();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            Global.PageNumber++;
            if (Global.PageNumber > 2)
            {
                Global.PageNumber = 0;
            }
            CheckPage();
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            Global.PageNumber--;
            if (Global.PageNumber < 0)
            {
                Global.PageNumber = 3;
            }
            CheckPage();
        }

        public void CheckPage() 
        {
            switch (Global.PageNumber)
            {
                case 0:
                    BookCover1.Image = Properties.Resources.SvetilnikBook;
                    Global.BookCover1 = 1;
                    BookCover2.Image = Properties.Resources.BaiGBook;
                    Global.BookCover2 = 2;
                    BookCover3.Image = Properties.Resources.SindromBook;
                    Global.BookCover3 = 3;
                    break;
                case 1:
                    BookCover1.Image = Properties.Resources.ENZBook;
                    Global.BookCover1 = 4;
                    BookCover2.Image = Properties.Resources.VapcarovBook;
                    Global.BookCover2 = 5;
                    BookCover3.Image = Properties.Resources.NoevBook;
                    Global.BookCover3 = 6;
                    break;
                case 2:
                    BookCover1.Image = Properties.Resources.BorbaBook;
                    Global.BookCover1 = 7;
                    BookCover2.Image = Properties.Resources.AndreshkoBook;
                    Global.BookCover2 = 8;
                    BookCover3.Image = Properties.Resources.StulbataBook;
                    Global.BookCover3 = 9;
                    break;
                case 3:
                    BookCover1.Image = Properties.Resources.LibeBook;
                    Global.BookCover1 = 10;
                    BookCover2.Image = Properties.Resources.ENZBook;
                    Global.BookCover2 = 11;
                    BookCover3.Image = Properties.Resources.KradecaBook;
                    Global.BookCover3 = 12;
                    break;
                case 4:
                    BookCover1.Image = Properties.Resources.VLRBook;
                    Global.BookCover1 = 13;
                    BookCover2.Image = Properties.Resources.QvorBook;
                    Global.BookCover2 = 14;
                    BookCover3.Image = Properties.Resources.SpiBook;
                    Global.BookCover3 = 15;
                    break;
                default:
                    break;
            }
        }

        public void ShowInfo()
        {
            BookInfo f = new BookInfo();
            f.Show();
            this.Hide();
        }
    }
}

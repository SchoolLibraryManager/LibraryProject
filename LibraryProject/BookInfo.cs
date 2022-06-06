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
                    break;
                case 2:
                    label1.Text = "Бай Ганьо журналист";
                    BookCover1.Image = Properties.Resources.BaiGBook;
                    break;
                case 3:
                    label1.Text = "Балкански синдром";
                    BookCover1.Image = Properties.Resources.SindromBook;
                    break;
                case 4:
                    label1.Text = "Паисий";
                    BookCover1.Image = Properties.Resources.ENZBook;
                    break;
                case 5:
                    label1.Text = "История";
                    
                    break;
                case 6:
                    label1.Text = "Ноев Ковчег";
                    BookCover1.Image = Properties.Resources.NoevBook;
                    break;
                case 7:
                    label1.Text = "Борба";
                    BookCover1.Image = Properties.Resources.BorbaBook;
                    break;
                case 8:
                    label1.Text = "Андрешко";
                    BookCover1.Image = Properties.Resources.AndreshkoBook;
                    break;
                case 9:
                    label1.Text = "Приказка за стълбата";
                    BookCover1.Image = Properties.Resources.StulbataBook;
                    break;
                case 10:
                    label1.Text = "До моето първо либе";
                    BookCover1.Image = Properties.Resources.LibeBook;
                    break;
                case 11:
                    label1.Text = "Новото гробище на сливница";
                    
                    break;
                case 12:
                    label1.Text = "Крадецът на праскови";
                    BookCover1.Image = Properties.Resources.KradecaBook;
                    break;
                case 13:
                    label1.Text = "При рилския манастир";
                    BookCover1.Image = Properties.Resources.VLRBook;
                    break;
                case 14:
                    label1.Text = "Градушка";
                    
                    break;
                case 15:
                    label1.Text = "Спи езерото";
                    BookCover1.Image = Properties.Resources.SpiBook;
                    break;
                default:
                    break;
            }
        }
    }
}

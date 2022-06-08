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
    public partial class WantToRead : Form
    {
        public WantToRead()
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

        private void WantToRead_Load(object sender, EventArgs e)
        {
            GetFavouriteBook();
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
        public void GetFavouriteBook()
        {
            int bookNumber1 = 0;
            int bookNumber2 = 0;
            if (Global.FavouriteBooks.Count == 1)
            {
                bookNumber1 = Global.FavouriteBooks[0];
            }
            else if (Global.FavouriteBooks.Count > 1)
            {
                bookNumber1 = Global.FavouriteBooks[0];
                bookNumber2 = Global.FavouriteBooks[1];
            }
            switch (bookNumber1)
            {
                case 1:
                    BookCover1.Image = Properties.Resources.SvetilnikBook;
                    BookCover2.Image = Properties.Resources.BaiGBook;
                    break;
                case 2:
                    BookCover1.Image = Properties.Resources.BaiGBook;
                    BookCover2.Image = Properties.Resources.SindromBook;
                    break;
                case 3:
                    BookCover1.Image = Properties.Resources.SindromBook;
                    BookCover2.Image = Properties.Resources.SvetilnikBook;
                    break;
                case 4:
                    BookCover1.Image = Properties.Resources.ENZBook;
                    BookCover2.Image = Properties.Resources.VapcarovBook;
                    break;
                case 5:
                    BookCover1.Image = Properties.Resources.VapcarovBook;
                    BookCover2.Image = Properties.Resources.NoevBook;
                    break;
                case 6:
                    BookCover1.Image = Properties.Resources.NoevBook;
                    BookCover2.Image = Properties.Resources.ENZBook;
                    break;
                case 7:
                    BookCover1.Image = Properties.Resources.BorbaBook;
                    BookCover2.Image = Properties.Resources.AndreshkoBook;
                    break;
                case 8:
                    BookCover1.Image = Properties.Resources.AndreshkoBook;
                    BookCover2.Image = Properties.Resources.StulbataBook;
                    break;
                case 9:
                    BookCover1.Image = Properties.Resources.StulbataBook;
                    BookCover2.Image = Properties.Resources.BorbaBook;
                    break;
                case 10:
                    BookCover1.Image = Properties.Resources.LibeBook;
                    BookCover2.Image = Properties.Resources.ENZBook;
                    break;
                case 11:
                    BookCover1.Image = Properties.Resources.ENZBook;
                    BookCover2.Image = Properties.Resources.KradecaBook;
                    break;
                case 12:
                    BookCover1.Image = Properties.Resources.KradecaBook;
                    BookCover2.Image = Properties.Resources.LibeBook;
                    break;
                case 13:
                    BookCover1.Image = Properties.Resources.VLRBook;
                    BookCover2.Image = Properties.Resources.QvorBook;
                    break;
                case 14:
                    BookCover1.Image = Properties.Resources.QvorBook;
                    BookCover2.Image = Properties.Resources.SpiBook;
                    break;
                case 15:
                    BookCover1.Image = Properties.Resources.SpiBook;
                    BookCover2.Image = Properties.Resources.VLRBook;
                    break;
                default:
                    break;
            }
            switch (bookNumber2)
            {
                case 1:
                    BookCover3.Image = Properties.Resources.SvetilnikBook;
                    BookCover4.Image = Properties.Resources.BaiGBook;
                    break;
                case 2:
                    BookCover3.Image = Properties.Resources.BaiGBook;
                    BookCover4.Image = Properties.Resources.SindromBook;
                    break;
                case 3:
                    BookCover3.Image = Properties.Resources.SindromBook;
                    BookCover4.Image = Properties.Resources.SvetilnikBook;
                    break;
                case 4:
                    BookCover3.Image = Properties.Resources.ENZBook;
                    BookCover4.Image = Properties.Resources.VapcarovBook;
                    break;
                case 5:
                    BookCover3.Image = Properties.Resources.VapcarovBook;
                    BookCover4.Image = Properties.Resources.NoevBook;
                    break;
                case 6:
                    BookCover3.Image = Properties.Resources.NoevBook;
                    BookCover4.Image = Properties.Resources.ENZBook;
                    break;
                case 7:
                    BookCover3.Image = Properties.Resources.BorbaBook;
                    BookCover4.Image = Properties.Resources.AndreshkoBook;
                    break;
                case 8:
                    BookCover3.Image = Properties.Resources.AndreshkoBook;
                    BookCover4.Image = Properties.Resources.StulbataBook;
                    break;
                case 9:
                    BookCover3.Image = Properties.Resources.StulbataBook;
                    BookCover4.Image = Properties.Resources.BorbaBook;
                    break;
                case 10:
                    BookCover3.Image = Properties.Resources.LibeBook;
                    BookCover4.Image = Properties.Resources.ENZBook;
                    break;
                case 11:
                    BookCover3.Image = Properties.Resources.ENZBook;
                    BookCover4.Image = Properties.Resources.KradecaBook;
                    break;
                case 12:
                    BookCover3.Image = Properties.Resources.KradecaBook;
                    BookCover4.Image = Properties.Resources.LibeBook;
                    break;
                case 13:
                    BookCover3.Image = Properties.Resources.VLRBook;
                    BookCover4.Image = Properties.Resources.QvorBook;
                    break;
                case 14:
                    BookCover3.Image = Properties.Resources.QvorBook;
                    BookCover4.Image = Properties.Resources.SpiBook;
                    break;
                case 15:
                    BookCover3.Image = Properties.Resources.SpiBook;
                    BookCover4.Image = Properties.Resources.VLRBook;
                    break;
                default:
                    break;
            }
        }
    }
}

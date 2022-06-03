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
            GiveInfo();
            int bookNumber = Global.BookInfo;
            for (int i = 0; i < Global.FavouriteBooks.Count(); i++)
            {
                if (Global.FavouriteBooks.Count(n => n == bookNumber) >= 1)
                {
                    FavouriteBtn.Enabled = false;
                    RemoveMeBtn.BringToFront();
                }
            }
        }

        private void FavouriteBtn_Click(object sender, EventArgs e)
        {
            Global.FavouriteBooks.Add(Global.BookInfo);
            FavouriteBtn.Enabled = false;
            RemoveMeBtn.BringToFront();
        }

        private void RemoveMeBtn_Click(object sender, EventArgs e)
        {
            Global.FavouriteBooks.Remove(Global.BookInfo);
            RemoveMeBtn.Enabled = false;
            FavouriteBtn.BringToFront();
            FavouriteBtn.Enabled = true;
        }

        public void GiveInfo()
        {
            switch (Global.BookInfo)
            {
                case 1:
                    label1.Text = "Железния светилник";
                    break;
                case 2:
                    label1.Text = "Бай Ганьо журналист";
                    break;
                case 3:
                    label1.Text = "Балкански синдром";
                    break;
                case 4:
                    label1.Text = "Паисий";
                    break;
                case 5:
                    label1.Text = "История";
                    break;
                case 6:
                    label1.Text = "Ноев Ковчег";
                    break;
                case 7:
                    label1.Text = "Борба";
                    break;
                case 8:
                    label1.Text = "Андрешко";
                    break;
                case 9:
                    label1.Text = "Приказка за стълбата";
                    break;
                case 10:
                    label1.Text = "До моето първо либе";
                    break;
                case 11:
                    label1.Text = "Новото гробище на сливница";
                    break;
                case 12:
                    label1.Text = "Крадецът на праскови";
                    break;
                case 13:
                    label1.Text = "При рилския манастир";
                    break;
                case 14:
                    label1.Text = "Градушка";
                    break;
                case 15:
                    label1.Text = "Спи езерото";
                    break;
                default:
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

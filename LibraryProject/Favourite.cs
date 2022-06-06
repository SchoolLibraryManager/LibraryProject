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
    public partial class Favourite : Form
    {
        public Favourite()
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
            Main f = new Main();
            f.Show();
            this.Hide();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Favourite_Load(object sender, EventArgs e)
        {
            int bookNumber = 0;
            for (int i = 0; i < Global.FavouriteBooks.Count(); i++)
            {
                bookNumber = Global.FavouriteBooks[i];
                GiveInfo(bookNumber);
            }
            FillPictures();
        }

        public void GiveInfo(int bookNumber)
        {
            switch (bookNumber)
            {
                case 1:
                    listBox1.Items.Add("Железния светилник");
                    break;
                case 2:
                    listBox1.Items.Add("Бай Ганьо журналист");
                    break;
                case 3:
                    listBox1.Items.Add("Балкански синдром");
                    break;
                case 4:
                    listBox1.Items.Add("Паисий");
                    break;
                case 5:
                    listBox1.Items.Add("История");
                    break;
                case 6:
                    listBox1.Items.Add("Ноев Ковчег");
                    break;
                case 7:
                    listBox1.Items.Add("Борба");
                    break;
                case 8:
                    listBox1.Items.Add("Андрешко");
                    break;
                case 9:
                    listBox1.Items.Add("Приказка за стълбата");
                    break;
                case 10:
                    listBox1.Items.Add("До моето първо либе");
                    break;
                case 11:
                    listBox1.Items.Add("Новото гробище на сливница");
                    break;
                case 12:
                    listBox1.Items.Add("Крадецът на праскови");
                    break;
                case 13:
                    listBox1.Items.Add("При рилския манастир");
                    break;
                case 14:
                    listBox1.Items.Add("Градушка");
                    break;
                case 15:
                    listBox1.Items.Add("Спи езерото");
                    break;
                default:
                    break;
            }
        }

        public void FillPictures()
        {
            
        }
    }
}

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
    public partial class Main : Form
    {
        public Main()
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

        private void LibraryBtn_Click(object sender, EventArgs e)
        {
            Library f = new Library();
            f.Show();
            this.Hide();
        }

        private void TSR_Click(object sender, EventArgs e)
        {
            TimeSpentReading f = new TimeSpentReading();
            f.Show();
            this.Hide();
        }

        private void Favourite_Click(object sender, EventArgs e)
        {
            Favourite f = new Favourite();
            f.Show();
            this.Hide();
        }

        private void WTR_Click(object sender, EventArgs e)
        {
            WantToRead f = new WantToRead();
            f.Show();
            this.Hide();
        }

        private void LibraryLabelMain_Click(object sender, EventArgs e)
        {
            Library f = new Library();
            f.Show();
            this.Hide();
        }

        private void WTRLabelMain_Click(object sender, EventArgs e)
        {
            WantToRead f = new WantToRead();
            f.Show();
            this.Hide();
        }

        private void FavouriteLabelMain_Click(object sender, EventArgs e)
        {
            Favourite f = new Favourite();
            f.Show();
            this.Hide();
        }

        private void TSRLabelMain_Click(object sender, EventArgs e)
        {
            TimeSpentReading f = new TimeSpentReading();
            f.Show();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void UserPanel_Click(object sender, EventArgs e)
        {
            UserPanel f = new UserPanel();
            f.Show();
            this.Hide();
        }
    }
}

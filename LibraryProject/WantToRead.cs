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
    }
}

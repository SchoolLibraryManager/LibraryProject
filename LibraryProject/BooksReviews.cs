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
    public partial class BooksReviews : Form
    {
        public BooksReviews()
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

        private void BooksReviews_Load(object sender, EventArgs e)
        {
            BookCover1.Image = Properties.Resources.AndreshkoBook;
            label1.Text = "Андрешко";
            label4.Text = "Чувствам се донякъде виновна, че Андрешко не ми хареса повече. В него е съчетана красив език и социална критика (която ми допадна изключително много), но има само едно по-запомнящо се произведение  \"Борба\" на Христо Ботев.";
            BookCover2.Image = Properties.Resources.ENZBook;
            label3.Text = "Епопея на забравените";
            label2.Text = "Поезията на Вазов е с много силно въздействие върху мен, всеки ред ме кара да настръхвам! Епопеята е писана в подобен на настоящия момент, в който са били забравени бесмъртните ни герои, хора чиито образи трябва да са винаги пред очите ни!";
        }
    }
}

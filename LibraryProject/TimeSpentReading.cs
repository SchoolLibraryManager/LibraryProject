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
    public partial class TimeSpentReading : Form
    {
        public TimeSpentReading()
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

        private void TimeSpentReading_Load(object sender, EventArgs e)
        {
            this.TSRChart.Series["Minutes1"].Points.AddXY("Понеделник", 15);
            this.TSRChart.Series["Minutes1"].Points.AddXY("Вторник", 28);
            this.TSRChart.Series["Minutes1"].Points.AddXY("Сряда", 35);
            this.TSRChart.Series["Minutes1"].Points.AddXY("Четвъртък", 64);
            this.TSRChart.Series["Minutes1"].Points.AddXY("Петък", 20);
            this.TSRChart.Series["Minutes1"].Points.AddXY("Събота", 153);
            this.TSRChart.Series["Minutes1"].Points.AddXY("Неделя", 168);

            this.TSRChart.Series["Minutes2"].Points.AddXY("Понеделник", 35);
            this.TSRChart.Series["Minutes2"].Points.AddXY("Вторник", 25);
            this.TSRChart.Series["Minutes2"].Points.AddXY("Сряда", 40);
            this.TSRChart.Series["Minutes2"].Points.AddXY("Четвъртък", 25);
            this.TSRChart.Series["Minutes2"].Points.AddXY("Петък", 15);
            this.TSRChart.Series["Minutes2"].Points.AddXY("Събота", 180);
            this.TSRChart.Series["Minutes2"].Points.AddXY("Неделя", 163);

            this.TSRChart.Series["Minutes3"].Points.AddXY("Понеделник", 45);
            this.TSRChart.Series["Minutes3"].Points.AddXY("Вторник", 38);
            this.TSRChart.Series["Minutes3"].Points.AddXY("Сряда", 45);
            this.TSRChart.Series["Minutes3"].Points.AddXY("Четвъртък", 35);
            this.TSRChart.Series["Minutes3"].Points.AddXY("Петък", 40);
            this.TSRChart.Series["Minutes3"].Points.AddXY("Събота", 120);
            this.TSRChart.Series["Minutes3"].Points.AddXY("Неделя", 100);
        }
    }
}

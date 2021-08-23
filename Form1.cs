using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thoi_khoa_bieu
{
    public partial class Form1 : Form
    {
        public Form1() // add anything you want them appear on build
        {
            InitializeComponent();
            LoadMatrix();

        }
        void LoadMatrix()
        {
            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Const.margin, 0) };
            for (int i = 0; i < Const.DayofColumn; i++)
            {
                for (int j = 0; i < Const.DayofWeek; j++)
                {
                    Button btn = new Button() { Width = Const.dateButtonWidth, Height = Const.dateButtonHeight };  // create new button
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Const.margin, oldBtn.Location.Y);  // push button location
                    pnlMatrix.Controls.Add(btn);    // add the newly-created button
                    oldBtn = btn;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Const.margin, oldBtn.Location.Y + Const.dateButtonHeight) };
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

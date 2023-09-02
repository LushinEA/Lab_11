using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_11
{
    public partial class main : Form
    {
        int distance;
        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about a = new about();
            a.ShowDialog();
        }

        private void порядокВыполненияРаботыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guide g = new guide();
            this.Hide();
            g.ShowDialog();
        }

        private void теорияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            theory t = new theory();
            this.Hide();
            t.ShowDialog();
        }

        private void trackBar1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trackBar1, "Расстояние до приёмной антенны");
        }

        private void radioButton1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(radioButton1, "Без экрана");
        }

        private void radioButton2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(radioButton2, "Текстолит");
        }

        private void radioButton3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(radioButton3, "Крупная металлическая сетка");
        }

        private void radioButton4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(radioButton4, "Мелкая металлическая сетка");
        }

        private void radioButton5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(radioButton5, "Фольга");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            switch (trackBar1.Value)
            {
                case 0:
                    distance = 15;
                    break;
                case 1:
                    distance = 30;
                    break;
                case 2:
                    distance = 40;
                    break;
                case 3:
                    distance = 50;
                    break;
                case 4:
                    distance = 60;
                    break;
                case 5:
                    distance = 70;
                    break;
                case 6:
                    distance = 80;
                    break;
                case 7:
                    distance = 90;
                    break;
            }
            MessageBox.Show(distance.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        private int score = 0;
        private int time = 0;
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            score = 0;
            lblScore.Text = "Очки: 0";
            gameTimer.Start();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            
            
            time++;
            string level = comboBox1.SelectedItem.ToString();
            label1.Text = "Час: " + time.ToString();
            
            if (level == "Hard")
            {
                if (time == 17)
                {
                    Close();
                }
                moleButton1.Visible = true;
                int x = rand.Next(0, this.ClientSize.Width - moleButton1.Width);
                int y = rand.Next(50, this.ClientSize.Height - moleButton1.Height);
                moleButton1.Location = new Point(x, y);
            }else if (level == "Medium")
            {
                if (time == 25)
                {
                    Close();
                }
                moleButton1.Visible = true;
                int x = rand.Next(0, this.ClientSize.Width - moleButton1.Width);
                int y = rand.Next(50, this.ClientSize.Height - moleButton1.Height);
                moleButton1.Location = new Point(x, y);
                moleButton2.Visible = true;
                int x2 = rand.Next(0, this.ClientSize.Width - moleButton2.Width);
                int y2 = rand.Next(50, this.ClientSize.Height - moleButton2.Height);
                moleButton2.Location = new Point(x2, y2);
            }else if (level == "Easy")
            {  
                if (time == 30)
                {
                    Close();
                }
                moleButton1.Visible = true;
                int x = rand.Next(0, this.ClientSize.Width - moleButton1.Width);
                int y = rand.Next(50, this.ClientSize.Height - moleButton1.Height);
                moleButton1.Location = new Point(x, y);
                moleButton2.Visible = true;
                int x2 = rand.Next(0, this.ClientSize.Width - moleButton2.Width);
                int y2 = rand.Next(50, this.ClientSize.Height - moleButton2.Height);
                moleButton2.Location = new Point(x2, y2);
                moleButton3.Visible = true;
                int x3 = rand.Next(0, this.ClientSize.Width - moleButton3.Width);
                int y3 = rand.Next(50, this.ClientSize.Height - moleButton3.Height);
                moleButton3.Location = new Point(x3, y3);
            }

            
        }

        private void moleButton_Click(object sender, EventArgs e)
        {
            score++;
            lblScore.Text = "Очки: " + score;
            moleButton2.Visible = false;
            moleButton3.Visible = false;
            moleButton1.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

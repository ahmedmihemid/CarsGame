using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsGame
{
    public partial class Form1 : Form
    {

        private int speed=15;
        private int Score=0;
        enum enDirectionOfMovement { Left, Right ,None };
        enum enCarsplace { Left=1, Right , middle };
        enDirectionOfMovement movement= enDirectionOfMovement.None;

        public Form1()
        {
            InitializeComponent();
        }


        private void moveCars()
        {
            BlueCarPIC.Top += speed;
            WhiteCarPIC.Top += speed;

            if(WhiteCarPIC.Top > 600 )
            {
                WhiteCarPIC.Location = new Point(GetRandomPlace(), -77);
                Score ++;
            }

            if (BlueCarPIC.Top > 600)
            {
                BlueCarPIC.Location = new Point(GetRandomPlace(), -77);
                Score++;
            }

            MoveMainCar();
        }

        private void moveStreetLine()
        {
            LinePIC1.Top += speed;
            LinePIC2.Top += speed;
            LinePIC3.Top += speed;
            LinePIC4.Top += speed;
            LinePIC5.Top += speed;
            LinePIC7.Top += speed;
            

            if (LinePIC1.Top > 600)
            {
                LinePIC1.Top =  -77;
              
            }

            if (LinePIC2.Top > 600)
            {
                LinePIC2.Top = -77;

            }

            if (LinePIC3.Top > 600)
            {
                LinePIC3.Top = -77;

            }

            if (LinePIC4.Top > 600)
            {
                LinePIC4.Top = -77;

            }


            if (LinePIC5.Top > 600)
            {
                LinePIC5.Top = -77;

            }

            if (LinePIC7.Top > 600)
            {
                LinePIC7.Top = -77;

            }

        }

        private int GetRandomPlace()
        {
            Random ran = new Random();
            int n=ran.Next(1,4);
            switch(n) 
            {
              case 1:
                    return 24;
              case 2:
                    return 205;
              case 3:
                    return 124;
            }
            return 24;
        }

        private bool isAnothurCar()
        {
            if(MainCarPIC.Bounds.IntersectsWith(WhiteCarPIC.Bounds) ||
                MainCarPIC.Bounds.IntersectsWith(BlueCarPIC.Bounds)) 
            { return true;  }
            return false;
        }

        private void IsdDead()
        {
            if(isAnothurCar())
                this.Close();
        }

        private void UpdateScore()
        {
            LeabScore.Text=Score.ToString();

        }

        private void MoveMainCar()
        {
            if(movement==enDirectionOfMovement.Left && MainCarPIC.Left > 5 )
                MainCarPIC.Left -=speed;

            if (movement == enDirectionOfMovement.Right && MainCarPIC.Left < 10+(GamePanal.Width-MainCarPIC.Width))
                MainCarPIC.Left += speed;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveCars();
            IsdDead();
            UpdateScore();
            moveStreetLine();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
                movement = enDirectionOfMovement.Left;
            else if (e.KeyData == Keys.Right)
                movement = enDirectionOfMovement.Right;
            else
                if (e.KeyData == Keys.None);

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            movement = enDirectionOfMovement.None;
        }

      
    }
}

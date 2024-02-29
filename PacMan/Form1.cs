using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PacMan
{
    public partial class Game : Form
    {
        int heroStep = 3;
        int verticalHero = 0;
        int horizontalHero = 0;
        int enemyStep = 2;
        int verticalEnemy = 0;
        int horizontalEnemy = 0;
        string heroDirection;

        public Game()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            
            this.BackColor = Color.Gray;

            Hero.BackColor = Color.Red;
            Hero.Width = 35;
            Hero.Height = 35;
            Hero.SizeMode = PictureBoxSizeMode.StretchImage;

            Food.BackColor = Color.Transparent;
            Food.Width = 25;
            Food.Height = 25;
            Food.SizeMode = PictureBoxSizeMode.StretchImage;
            Food.Image = Properties.Resources.food_3;

            Enemy.BackColor = Color.Transparent;
            Enemy.Width = 30;
            Enemy.Height = 30;
            Enemy.SizeMode = PictureBoxSizeMode.StretchImage;

            TimerMove.Start();
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                horizontalHero = 0;
                verticalHero = -heroStep;
                heroDirection = "up";
            }
            else if (e.KeyCode == Keys.Down)
            {
                horizontalHero = 0;
                verticalHero = heroStep;
                heroDirection = "down";
            }
            else if (e.KeyCode == Keys.Left)
            {
                verticalHero = 0;
                horizontalHero = -heroStep;
                heroDirection = "left";
            }
            else if (e.KeyCode == Keys.Right)
            {
                verticalHero = 0;
                horizontalHero = heroStep;
                heroDirection = "right";
            }
        }

        private void HeroMove()
        {
            Hero.Top += verticalHero;
            Hero.Left += horizontalHero;
        }

        private void TimerMove_Tick(object sender, EventArgs e)
        {
            HeroMove();
        }
    }
}

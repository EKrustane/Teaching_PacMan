using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            this.BackColor = Color.Gray;

            Hero.BackColor = Color.Transparent;
            Hero.Width = 30;
            Hero.Height = 30;

            Food.BackColor = Color.Transparent;
            Food.Width = 25;
            Food.Height = 25;
            Food.SizeMode = PictureBoxSizeMode.StretchImage;
            Food.Image = Properties.Resources.food_3;
        }
    }
}

namespace PacMan
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelScore = new System.Windows.Forms.Label();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.Hero = new System.Windows.Forms.PictureBox();
            this.Food = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(12, 19);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(35, 13);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "label1";
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.Font = new System.Drawing.Font("Segoe Print", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOver.ForeColor = System.Drawing.Color.LightCoral;
            this.labelGameOver.Location = new System.Drawing.Point(105, 253);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(468, 129);
            this.labelGameOver.TabIndex = 1;
            this.labelGameOver.Text = "Game Over";
            // 
            // Hero
            // 
            this.Hero.Location = new System.Drawing.Point(92, 372);
            this.Hero.Name = "Hero";
            this.Hero.Size = new System.Drawing.Size(100, 50);
            this.Hero.TabIndex = 2;
            this.Hero.TabStop = false;
            // 
            // Food
            // 
            this.Food.Location = new System.Drawing.Point(357, 178);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(100, 50);
            this.Food.TabIndex = 3;
            this.Food.TabStop = false;
            // 
            // Enemy
            // 
            this.Enemy.Location = new System.Drawing.Point(305, 549);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(100, 50);
            this.Enemy.TabIndex = 4;
            this.Enemy.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.Hero);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.labelScore);
            this.Name = "Game";
            this.Text = "PacMan";
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.PictureBox Hero;
        private System.Windows.Forms.PictureBox Food;
        private System.Windows.Forms.PictureBox Enemy;
    }
}


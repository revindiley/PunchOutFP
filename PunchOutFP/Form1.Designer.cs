namespace PunchOutFP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.enemyHealthBar = new System.Windows.Forms.ProgressBar();
            this.playerHealthBar = new System.Windows.Forms.ProgressBar();
            this.player = new System.Windows.Forms.PictureBox();
            this.enemy = new System.Windows.Forms.PictureBox();
            this.EnemyAttackTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemyMoveTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            this.SuspendLayout();
            // 
            // enemyHealthBar
            // 
            this.enemyHealthBar.Location = new System.Drawing.Point(34, 45);
            this.enemyHealthBar.Name = "enemyHealthBar";
            this.enemyHealthBar.Size = new System.Drawing.Size(208, 23);
            this.enemyHealthBar.TabIndex = 0;
            // 
            // playerHealthBar
            // 
            this.playerHealthBar.Location = new System.Drawing.Point(454, 45);
            this.playerHealthBar.Name = "playerHealthBar";
            this.playerHealthBar.Size = new System.Drawing.Size(208, 23);
            this.playerHealthBar.TabIndex = 1;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::PunchOutFP.Properties.Resources.boxer_stand;
            this.player.Location = new System.Drawing.Point(321, 406);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(61, 153);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            // 
            // enemy
            // 
            this.enemy.BackColor = System.Drawing.Color.Transparent;
            this.enemy.Image = global::PunchOutFP.Properties.Resources.enemy_stand;
            this.enemy.Location = new System.Drawing.Point(388, 323);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(77, 185);
            this.enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemy.TabIndex = 4;
            this.enemy.TabStop = false;
            // 
            // EnemyAttackTimer
            // 
            this.EnemyAttackTimer.Enabled = true;
            this.EnemyAttackTimer.Interval = 500;
            this.EnemyAttackTimer.Tick += new System.EventHandler(this.EnemyAttackTimerEvent);
            // 
            // EnemyMoveTimer
            // 
            this.EnemyMoveTimer.Enabled = true;
            this.EnemyMoveTimer.Interval = 20;
            this.EnemyMoveTimer.Tick += new System.EventHandler(this.EnemyMoveTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PunchOutFP.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.player);
            this.Controls.Add(this.playerHealthBar);
            this.Controls.Add(this.enemyHealthBar);
            this.Controls.Add(this.enemy);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Simple Punch Out Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar enemyHealthBar;
        private ProgressBar playerHealthBar;
        private PictureBox player;
        private PictureBox enemy;
        private System.Windows.Forms.Timer EnemyAttackTimer;
        private System.Windows.Forms.Timer EnemyMoveTimer;
    }
}
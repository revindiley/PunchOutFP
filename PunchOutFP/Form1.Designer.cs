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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            this.SuspendLayout();
            // 
            // enemyHealthBar
            // 
            this.enemyHealthBar.Location = new System.Drawing.Point(34, 54);
            this.enemyHealthBar.Name = "enemyHealthBar";
            this.enemyHealthBar.Size = new System.Drawing.Size(208, 23);
            this.enemyHealthBar.TabIndex = 0;
            // 
            // playerHealthBar
            // 
            this.playerHealthBar.Location = new System.Drawing.Point(452, 54);
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
            this.EnemyAttackTimer.Interval = 600;
            this.EnemyAttackTimer.Tick += new System.EventHandler(this.EnemyAttackTimerEvent);
            // 
            // EnemyMoveTimer
            // 
            this.EnemyMoveTimer.Enabled = true;
            this.EnemyMoveTimer.Interval = 20;
            this.EnemyMoveTimer.Tick += new System.EventHandler(this.EnemyMoveTimerEvent);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(458, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 113);
            this.label1.TabIndex = 5;
            this.label1.Text = "CONTROLS:\r\n\r\nRight Arrow Key: Right Hook\r\n\r\nLeft Arrow Key: Left Hook\r\n\r\nDown: Bl" +
    "ock incoming attacks\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(53, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 50);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tough Rob ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(473, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 50);
            this.label3.TabIndex = 7;
            this.label3.Text = "Little Mac (You)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 158);
            this.label4.TabIndex = 8;
            this.label4.Text = "Objective:\r\n\r\nTime your attacks to hit Tough Rob as he moves in front of you\r\n\r\nT" +
    "ough Rob lives up to his name, so remember to time your attacks and blocks just " +
    "right!\r\n\r\nGO GET \'EM, CHAMP!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PunchOutFP.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 738);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
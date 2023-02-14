namespace PunchOutFP
{
    public partial class Form1 : Form
    {

        bool playerBlock = false;
        bool enemyBlock = false;
        Random random= new Random();
        int enemySpeed = 5;
        int index = 0;
        int playerHealth = 100;
        int enemyHealth = 100;
        List<string> enemyAttack = new List<string> { "left", "right", "block" };


        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }

        private void EnemyAttackTimerEvent(object sender, EventArgs e)
        {
            index = random.Next(0, enemyAttack.Count);

            switch (enemyAttack[index].ToString())
            {
                case "left":
                    enemy.Image = Properties.Resources.enemy_punch1;
                    enemyBlock = false;

                    if (enemy.Bounds.IntersectsWith(player.Bounds) && playerBlock == false)
                    {
                        playerHealth -= 5;
                    }
                break;

                case "right":
                    enemy.Image = Properties.Resources.enemy_punch2;
                    enemyBlock = false;

                    if (enemy.Bounds.IntersectsWith(player.Bounds) && playerBlock == false)
                    {
                        playerHealth -= 5;
                    }
                break;

                case "block":
                    enemy.Image = Properties.Resources.enemy_block;
                    enemyBlock = true;

                break;
            }



        }

        private void EnemyMoveTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
                playerHealthBar.Value = playerHealth;
            }
            if (enemyHealth > 1)
            {
                enemyHealthBar.Value = enemyHealth;
            }

            enemy.Left += enemySpeed;
            if(enemy.Left > 430)
            {
                enemySpeed = -5;
            }
            if(enemy.Left < 220)
            {
                enemySpeed = 5;
            }

            if(enemyHealth < 1)
            {
                EnemyAttackTimer.Stop();
                EnemyMoveTimer.Stop();
                MessageBox.Show("Congratulations Champ! Click OK to Fight Again");
                ResetGame();
            }

            if (playerHealth < 1)
            {
                EnemyAttackTimer.Stop();
                EnemyMoveTimer.Stop();
                MessageBox.Show("Tough Rob is the Winner! Click OK to challenge Rob again");
                ResetGame();
            }

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                player.Image = Properties.Resources.boxer_left_punch;
                playerBlock = false;

                if(player.Bounds.IntersectsWith(enemy.Bounds) && enemyBlock == false)
                {
                    enemyHealth -= 5;
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                player.Image = Properties.Resources.boxer_right_punch;
                playerBlock = false;

                if (player.Bounds.IntersectsWith(enemy.Bounds) && enemyBlock == false)
                {
                    enemyHealth -= 5;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                player.Image = Properties.Resources.boxer_block;
                playerBlock = true;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            player.Image = Properties.Resources.boxer_stand;
            playerBlock = false;
        }

        private void ResetGame()
        {
            EnemyAttackTimer.Start();
            EnemyMoveTimer.Start();
            playerHealth = 100;
            enemyHealth = 100;

            enemy.Left = 400;
        }
    }
}
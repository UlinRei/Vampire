using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace 期中作業_Vαmpire吸血鬼遊戲
{
    public partial class Form1 : Form
    {
        bool playable = false;
        bool isOverflow, isAIFirst, startable;
        int maxLife, plLife, aiLife;
        bool yourturn;
        int plbite = 0, plrelief = 0, plfirsthug = 0;
        int aibite = 0, airelief = 0, aifirsthug = 0;
        int turn_num = 1, enemyrandomtake;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            set_button();
            bite.Enabled = false;
            hit.Enabled = false;
            firsthug.Enabled = false;
            relief.Enabled = false;
        }

        void set_button()
        {
            isOverflow = overflow.Checked;
            isAIFirst = AIFirst.Checked;
            startable = int.TryParse(startLife.Text,out maxLife);
            if (startable)
            {
                plLife = maxLife;
                aiLife = maxLife;
            }
            else if(playable == true && startable == false)
            {
                turn.Text = "初始生命必須為99以下整數";
                playable = false;
                set_button();
            }

        }
        void enable_button()
        {
            if(!yourturn)
            {
                bite.Enabled = yourturn;
                hit.Enabled = yourturn;
                firsthug.Enabled = yourturn;
                relief.Enabled = yourturn;
            }
            else
            {
                if(plfirsthug == 0)
                {
                    firsthug.Enabled = yourturn;
                }
                if(isOverflow || turn_num != 1)
                {
                    if (plrelief == 0)
                    {
                        relief.Enabled = yourturn;
                    }
                }
                bite.Enabled = yourturn;
                hit.Enabled = yourturn;
            }
        }
        void set_zero()
        {
            if (aiLife < 0)
            {
                aiLife = 0;
            }
            if (plLife < 0)
            {
                plLife = 0;
            }
        }
        void next_turn()
        {
            set_zero();
            if (aiLife > 0 && plLife > 0)
            {
                if (yourturn)
                {
                    if (plbite >= 2)
                    {
                        plLife -= 1;
                    }
                }
                else
                {
                    if (aibite >= 2)
                    {
                        aiLife -= 1;
                    }
                }
                EnemyLife.Text = "敵人生命：" + (aiLife).ToString();
                PlayerLife.Text = "玩家生命：" + (plLife).ToString();

                yourturn = !yourturn;

                if (yourturn)
                {
                    turn.Text = "玩家回合";
                    if (plrelief > 0)
                    {
                        plrelief -= 1;
                    }
                    enable_button();
                }
                else
                {
                    enable_button();
                    aiTurn();
                }
                turn_num += 1;
            }
            else
            {
                EnemyLife.Text = "敵人生命：" + (aiLife).ToString();
                PlayerLife.Text = "玩家生命：" + (plLife).ToString();
                playable = false;
                bite.Enabled = playable;
                hit.Enabled = playable;
                firsthug.Enabled = playable;
                relief.Enabled = playable;
                if (plLife == 0)
                {
                    turn.Text = "電腦勝利";
                }
                else
                {
                    turn.Text = "玩家勝利";
                }
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            playable = true;
            set_button();
            PlayerLife.ForeColor = Color.Black;
            EnemyLife.ForeColor = Color.Black;
            EnemyLife.Text = "敵人生命：" + (aiLife).ToString();
            PlayerLife.Text = "玩家生命：" + (plLife).ToString();
            if (!isAIFirst)
            {
                yourturn = true;
                turn.Text = "玩家回合";
                enable_button();
            }
            else
            {
                yourturn = false;
                turn.Text = "敵人回合";
                enable_button();
                aiTurn();
            }
        }

        private void bite_Click(object sender, EventArgs e)
        {
            plbite = 0;
            PlayerLife.ForeColor = Color.Black;
            aiLife -= 2;
            if (isOverflow || plLife < maxLife)
            {
                plLife += 1;
            }
            next_turn();
        }

        private void hit_Click(object sender, EventArgs e)
        {
            plbite += 1;
            aiLife -= 3;
            PlayerLife.ForeColor = Color.Red;
            next_turn();
        }

        private void firsthug_Click(object sender, EventArgs e)
        {
            plbite += 1;
            if (plLife/2 == 0)
            {
                aiLife -= plLife / 2;
                plLife -= plLife / 2;
                plfirsthug += 1;
            }
            else
            {
                aiLife -= (plLife - 1) / 2;
                plLife -= (plLife - 1) / 2;
                plfirsthug += 1;
            }
            PlayerLife.ForeColor = Color.Red;
            next_turn();
        }

        private void relief_Click(object sender, EventArgs e)
        {
            plbite += 1;
            plLife += 4;
            plrelief = 3;
            PlayerLife.ForeColor = Color.Red;
            next_turn();
        }

        async void aiTurn()
        {
            turn.Text = "敵人回合";

            EnemyTaking.Text = "行動中";
            if (airelief > 0)
            {
                airelief -= 1;
            }
            await Task.Delay(1500);
            if (turn_num == 2)
            {
                if (plbite == 0)
                {
                    enemyrandomtake = 1;
                }
                else if(plrelief != 0)
                {
                    enemyrandomtake = 2;
                }
                else if (plfirsthug != 0)
                {
                    enemyrandomtake = 3;
                }
                else if (plbite == 1)
                {
                    enemyrandomtake = 4;
                }
            }
            if(aiLife <= maxLife/2 && airelief == 0)
            {
                enemyrandomtake = 4;
            }
            else if(aiLife/2 >= plLife && aifirsthug == 0)
            {
                enemyrandomtake = 3;
            }
            else
            {
                enemyrandomtake = rand.Next(1, 3);
            }
            if (enemyrandomtake == 1)
            {
                EnemyTaking.Text = "吸血";
                EnemyLife.ForeColor = Color.Black;
                aibite = 0;
                plLife -= 2;
                if (isOverflow || aiLife < maxLife)
                {
                    aiLife += 1;
                }
                EnemyLife.Text = "敵人生命：" + (aiLife).ToString();
                PlayerLife.Text = "玩家生命：" + (plLife).ToString();
                next_turn();
            }
            else if (enemyrandomtake == 2)
            {
                EnemyTaking.Text = "打擊";
                aibite += 1;
                plLife -= 3;
                EnemyLife.Text = "敵人生命：" + (aiLife).ToString();
                PlayerLife.Text = "玩家生命：" + (plLife).ToString();
                EnemyLife.ForeColor = Color.Red;
                next_turn();
            }
            else if (enemyrandomtake == 3)
            {
                EnemyTaking.Text = "初擁";
                aibite += 1;
                if (aiLife / 2 == 0)
                {
                    plLife -= aiLife / 2;
                    aiLife -= plLife / 2;
                    aifirsthug += 1;
                }
                else
                {
                    plLife -= (aiLife - 1) / 2;
                    aiLife -= (aiLife - 1) / 2;
                    aifirsthug += 1;
                }
                EnemyLife.Text = "敵人生命：" + (aiLife).ToString();
                PlayerLife.Text = "玩家生命：" + (plLife).ToString();
                EnemyLife.ForeColor = Color.Red;
                next_turn();
            }
            else if (enemyrandomtake == 4)
            {
                EnemyTaking.Text = "休憩";
                aibite += 1;
                aiLife += 4;
                airelief = 3;
                EnemyLife.Text = "敵人生命：" + (aiLife).ToString();
                PlayerLife.Text = "玩家生命：" + (plLife).ToString();
                EnemyLife.ForeColor = Color.Red;
                next_turn();
            }
        }
    }
}

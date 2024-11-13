
namespace 期中作業_Vαmpire吸血鬼遊戲
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.rule = new System.Windows.Forms.Label();
            this.bite = new System.Windows.Forms.Button();
            this.hit = new System.Windows.Forms.Button();
            this.firsthug = new System.Windows.Forms.Button();
            this.relief = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.PlayerLife = new System.Windows.Forms.Label();
            this.startLife = new System.Windows.Forms.TextBox();
            this.初始生命 = new System.Windows.Forms.Label();
            this.overflow = new System.Windows.Forms.CheckBox();
            this.EnemyLife = new System.Windows.Forms.Label();
            this.EnemyTaking = new System.Windows.Forms.Label();
            this.turn = new System.Windows.Forms.Label();
            this.AIFirst = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rule
            // 
            this.rule.AutoSize = true;
            this.rule.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rule.Location = new System.Drawing.Point(12, 9);
            this.rule.Name = "rule";
            this.rule.Size = new System.Drawing.Size(893, 208);
            this.rule.TabIndex = 0;
            this.rule.Text = "規則：\r\n吸血-造成2點傷害，回復1點生命，若連續兩回合(含)以上未使用，則在回合結束時損失1點生命\r\n打擊-造成3點傷害\r\n初擁-犧牲當前血量50%(無條件捨去" +
    ")，造成等量傷害，每局僅能使用一次\r\n休憩-回復4點生命，冷卻2回合\r\n\r\n初始生命可設定為不大於99的正整數\r\n請先初始化再開始遊戲";
            // 
            // bite
            // 
            this.bite.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bite.Location = new System.Drawing.Point(239, 499);
            this.bite.Name = "bite";
            this.bite.Size = new System.Drawing.Size(75, 50);
            this.bite.TabIndex = 1;
            this.bite.Text = "吸血";
            this.bite.UseVisualStyleBackColor = true;
            this.bite.Click += new System.EventHandler(this.bite_Click);
            // 
            // hit
            // 
            this.hit.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hit.Location = new System.Drawing.Point(367, 499);
            this.hit.Name = "hit";
            this.hit.Size = new System.Drawing.Size(75, 50);
            this.hit.TabIndex = 2;
            this.hit.Text = "打擊";
            this.hit.UseVisualStyleBackColor = true;
            this.hit.Click += new System.EventHandler(this.hit_Click);
            // 
            // firsthug
            // 
            this.firsthug.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.firsthug.Location = new System.Drawing.Point(501, 499);
            this.firsthug.Name = "firsthug";
            this.firsthug.Size = new System.Drawing.Size(75, 50);
            this.firsthug.TabIndex = 3;
            this.firsthug.Text = "初擁";
            this.firsthug.UseVisualStyleBackColor = true;
            this.firsthug.Click += new System.EventHandler(this.firsthug_Click);
            // 
            // relief
            // 
            this.relief.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.relief.Location = new System.Drawing.Point(631, 499);
            this.relief.Name = "relief";
            this.relief.Size = new System.Drawing.Size(75, 50);
            this.relief.TabIndex = 4;
            this.relief.Text = "休憩";
            this.relief.UseVisualStyleBackColor = true;
            this.relief.Click += new System.EventHandler(this.relief_Click);
            // 
            // restart
            // 
            this.restart.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.restart.Location = new System.Drawing.Point(920, 456);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(75, 50);
            this.restart.TabIndex = 5;
            this.restart.Text = "初始化";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // PlayerLife
            // 
            this.PlayerLife.AutoSize = true;
            this.PlayerLife.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PlayerLife.Location = new System.Drawing.Point(22, 499);
            this.PlayerLife.Name = "PlayerLife";
            this.PlayerLife.Size = new System.Drawing.Size(182, 35);
            this.PlayerLife.TabIndex = 6;
            this.PlayerLife.Text = "玩家生命：00";
            // 
            // startLife
            // 
            this.startLife.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startLife.Location = new System.Drawing.Point(920, 527);
            this.startLife.MaxLength = 2;
            this.startLife.Name = "startLife";
            this.startLife.Size = new System.Drawing.Size(75, 39);
            this.startLife.TabIndex = 7;
            this.startLife.Text = "6";
            this.startLife.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 初始生命
            // 
            this.初始生命.AutoSize = true;
            this.初始生命.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.初始生命.Location = new System.Drawing.Point(804, 530);
            this.初始生命.Name = "初始生命";
            this.初始生命.Size = new System.Drawing.Size(110, 31);
            this.初始生命.TabIndex = 8;
            this.初始生命.Text = "初始生命";
            // 
            // overflow
            // 
            this.overflow.AutoSize = true;
            this.overflow.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.overflow.Location = new System.Drawing.Point(772, 170);
            this.overflow.Name = "overflow";
            this.overflow.Size = new System.Drawing.Size(250, 39);
            this.overflow.TabIndex = 9;
            this.overflow.Text = "允許大於初始生命";
            this.overflow.UseVisualStyleBackColor = true;
            // 
            // EnemyLife
            // 
            this.EnemyLife.AutoSize = true;
            this.EnemyLife.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EnemyLife.Location = new System.Drawing.Point(22, 252);
            this.EnemyLife.Name = "EnemyLife";
            this.EnemyLife.Size = new System.Drawing.Size(182, 35);
            this.EnemyLife.TabIndex = 10;
            this.EnemyLife.Text = "敵人生命：00";
            // 
            // EnemyTaking
            // 
            this.EnemyTaking.AutoSize = true;
            this.EnemyTaking.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EnemyTaking.Location = new System.Drawing.Point(233, 252);
            this.EnemyTaking.Name = "EnemyTaking";
            this.EnemyTaking.Size = new System.Drawing.Size(123, 34);
            this.EnemyTaking.TabIndex = 6;
            this.EnemyTaking.Text = "敵人動作";
            // 
            // turn
            // 
            this.turn.AutoSize = true;
            this.turn.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.turn.Location = new System.Drawing.Point(81, 375);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(123, 34);
            this.turn.TabIndex = 6;
            this.turn.Text = "？的回合";
            // 
            // AIFirst
            // 
            this.AIFirst.AutoSize = true;
            this.AIFirst.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AIFirst.Location = new System.Drawing.Point(772, 247);
            this.AIFirst.Name = "AIFirst";
            this.AIFirst.Size = new System.Drawing.Size(142, 39);
            this.AIFirst.TabIndex = 9;
            this.AIFirst.Text = "電腦先手";
            this.AIFirst.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 609);
            this.Controls.Add(this.EnemyLife);
            this.Controls.Add(this.AIFirst);
            this.Controls.Add(this.overflow);
            this.Controls.Add(this.初始生命);
            this.Controls.Add(this.startLife);
            this.Controls.Add(this.turn);
            this.Controls.Add(this.EnemyTaking);
            this.Controls.Add(this.PlayerLife);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.relief);
            this.Controls.Add(this.firsthug);
            this.Controls.Add(this.hit);
            this.Controls.Add(this.bite);
            this.Controls.Add(this.rule);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rule;
        private System.Windows.Forms.Button bite;
        private System.Windows.Forms.Button hit;
        private System.Windows.Forms.Button firsthug;
        private System.Windows.Forms.Button relief;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Label PlayerLife;
        private System.Windows.Forms.TextBox startLife;
        private System.Windows.Forms.Label 初始生命;
        private System.Windows.Forms.CheckBox overflow;
        private System.Windows.Forms.Label EnemyLife;
        private System.Windows.Forms.Label EnemyTaking;
        private System.Windows.Forms.Label turn;
        private System.Windows.Forms.CheckBox AIFirst;
    }
}


namespace Project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            btn9 = new Button();
            btn8 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn7 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            label1 = new Label();
            labPlayerOneF2 = new Label();
            labPlayerTwoF2 = new Label();
            ScorePlayerOne = new TextBox();
            ScorePlayerTwo = new TextBox();
            btnReset = new Button();
            btnNewGame = new Button();
            btnSaveScore = new Button();
            btnExit = new Button();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(btn9);
            panel1.Controls.Add(btn8);
            panel1.Controls.Add(btn6);
            panel1.Controls.Add(btn5);
            panel1.Controls.Add(btn7);
            panel1.Controls.Add(btn3);
            panel1.Controls.Add(btn4);
            panel1.Controls.Add(btn2);
            panel1.Controls.Add(btn1);
            panel1.Location = new Point(12, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 331);
            panel1.TabIndex = 0;
            // 
            // btn9
            // 
            btn9.BackColor = Color.WhiteSmoke;
            btn9.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            btn9.ForeColor = Color.Black;
            btn9.Location = new Point(302, 227);
            btn9.Name = "btn9";
            btn9.Size = new Size(142, 100);
            btn9.TabIndex = 2;
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.WhiteSmoke;
            btn8.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            btn8.ForeColor = Color.Black;
            btn8.Location = new Point(154, 227);
            btn8.Name = "btn8";
            btn8.Size = new Size(142, 100);
            btn8.TabIndex = 1;
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.WhiteSmoke;
            btn6.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            btn6.ForeColor = Color.Black;
            btn6.Location = new Point(302, 121);
            btn6.Name = "btn6";
            btn6.Size = new Size(142, 100);
            btn6.TabIndex = 2;
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.WhiteSmoke;
            btn5.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            btn5.ForeColor = Color.Black;
            btn5.Location = new Point(154, 121);
            btn5.Name = "btn5";
            btn5.Size = new Size(142, 100);
            btn5.TabIndex = 1;
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.WhiteSmoke;
            btn7.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            btn7.ForeColor = Color.Black;
            btn7.Location = new Point(6, 227);
            btn7.Name = "btn7";
            btn7.Size = new Size(142, 100);
            btn7.TabIndex = 0;
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.WhiteSmoke;
            btn3.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            btn3.ForeColor = Color.Black;
            btn3.Location = new Point(302, 15);
            btn3.Name = "btn3";
            btn3.Size = new Size(142, 100);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.WhiteSmoke;
            btn4.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            btn4.ForeColor = Color.Black;
            btn4.Location = new Point(6, 121);
            btn4.Name = "btn4";
            btn4.Size = new Size(142, 100);
            btn4.TabIndex = 0;
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.WhiteSmoke;
            btn2.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            btn2.ForeColor = Color.Black;
            btn2.Location = new Point(154, 15);
            btn2.Name = "btn2";
            btn2.Size = new Size(142, 100);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.WhiteSmoke;
            btn1.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            btn1.ForeColor = Color.Black;
            btn1.Location = new Point(6, 15);
            btn1.Name = "btn1";
            btn1.Size = new Size(142, 100);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Showcard Gothic", 46F);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(253, 0);
            label1.Name = "label1";
            label1.Size = new Size(309, 78);
            label1.TabIndex = 1;
            label1.Text = "X O Game";
            // 
            // labPlayerOneF2
            // 
            labPlayerOneF2.AutoSize = true;
            labPlayerOneF2.Font = new Font("Algerian", 20.25F, FontStyle.Bold);
            labPlayerOneF2.Location = new Point(510, 81);
            labPlayerOneF2.Name = "labPlayerOneF2";
            labPlayerOneF2.Size = new Size(146, 30);
            labPlayerOneF2.TabIndex = 2;
            labPlayerOneF2.Text = "player 1";
            // 
            // labPlayerTwoF2
            // 
            labPlayerTwoF2.AutoSize = true;
            labPlayerTwoF2.Font = new Font("Algerian", 20.25F, FontStyle.Bold);
            labPlayerTwoF2.Location = new Point(510, 131);
            labPlayerTwoF2.Name = "labPlayerTwoF2";
            labPlayerTwoF2.Size = new Size(146, 30);
            labPlayerTwoF2.TabIndex = 3;
            labPlayerTwoF2.Text = "player 2";
            // 
            // ScorePlayerOne
            // 
            ScorePlayerOne.Enabled = false;
            ScorePlayerOne.Font = new Font("Algerian", 16F, FontStyle.Bold);
            ScorePlayerOne.Location = new Point(662, 78);
            ScorePlayerOne.Name = "ScorePlayerOne";
            ScorePlayerOne.Size = new Size(100, 36);
            ScorePlayerOne.TabIndex = 4;
            ScorePlayerOne.Text = "0";
            ScorePlayerOne.TextAlign = HorizontalAlignment.Center;
            // 
            // ScorePlayerTwo
            // 
            ScorePlayerTwo.Enabled = false;
            ScorePlayerTwo.Font = new Font("Algerian", 16F, FontStyle.Bold);
            ScorePlayerTwo.Location = new Point(662, 125);
            ScorePlayerTwo.Name = "ScorePlayerTwo";
            ScorePlayerTwo.Size = new Size(100, 36);
            ScorePlayerTwo.TabIndex = 5;
            ScorePlayerTwo.Text = "0";
            ScorePlayerTwo.TextAlign = HorizontalAlignment.Center;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(255, 192, 128);
            btnReset.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold);
            btnReset.Location = new Point(498, 237);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(290, 59);
            btnReset.TabIndex = 0;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnNewGame
            // 
            btnNewGame.BackColor = Color.Lime;
            btnNewGame.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold);
            btnNewGame.Location = new Point(498, 173);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(290, 59);
            btnNewGame.TabIndex = 1;
            btnNewGame.Text = "Play Again";
            btnNewGame.UseVisualStyleBackColor = false;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // btnSaveScore
            // 
            btnSaveScore.BackColor = Color.Yellow;
            btnSaveScore.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold);
            btnSaveScore.Location = new Point(498, 300);
            btnSaveScore.Name = "btnSaveScore";
            btnSaveScore.Size = new Size(290, 68);
            btnSaveScore.TabIndex = 2;
            btnSaveScore.Text = "Save Score";
            btnSaveScore.UseVisualStyleBackColor = false;
            btnSaveScore.Click += btnSaveScore_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Showcard Gothic", 32F, FontStyle.Bold);
            btnExit.Location = new Point(498, 374);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(290, 64);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkViolet;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(18, 410);
            button1.Name = "button1";
            button1.Size = new Size(142, 36);
            button1.TabIndex = 6;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnReset);
            Controls.Add(btnNewGame);
            Controls.Add(btnSaveScore);
            Controls.Add(btnExit);
            Controls.Add(ScorePlayerTwo);
            Controls.Add(ScorePlayerOne);
            Controls.Add(labPlayerTwoF2);
            Controls.Add(labPlayerOneF2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label labPlayerOneF2;
        private Label labPlayerTwoF2;
        private TextBox ScorePlayerOne;
        private TextBox ScorePlayerTwo;
        private Button btnReset;
        private Button btnNewGame;
        private Button btnSaveScore;
        private Button btnExit;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn9;
        private Button btn8;
        private Button btn6;
        private Button btn5;
        private Button btn7;
        private Button btn4;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
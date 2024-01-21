namespace Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBox1 = new TextBox();
            PlayerTwo = new GroupBox();
            txt_name_player2 = new TextBox();
            lab_name_player2 = new Label();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            PlayerOne = new GroupBox();
            txt_name_player1 = new TextBox();
            lab_name_player1 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            startGame = new Button();
            btnScores = new Button();
            PlayerTwo.SuspendLayout();
            PlayerOne.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Cooper Black", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(93, 14);
            label1.Name = "label1";
            label1.Size = new Size(598, 74);
            label1.TabIndex = 21;
            label1.Text = "Tic Tac Toe Game";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(209, 252);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(382, 120);
            textBox1.TabIndex = 20;
            textBox1.Text = "You can be represent as X or O letters\r\nYou have to take turns to play\r\nThe one who can get 3 letters in  the row frist is the winner";
            // 
            // PlayerTwo
            // 
            PlayerTwo.BackColor = Color.Black;
            PlayerTwo.BackgroundImage = (Image)resources.GetObject("PlayerTwo.BackgroundImage");
            PlayerTwo.Controls.Add(txt_name_player2);
            PlayerTwo.Controls.Add(lab_name_player2);
            PlayerTwo.Controls.Add(radioButton4);
            PlayerTwo.Controls.Add(radioButton3);
            PlayerTwo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PlayerTwo.ForeColor = SystemColors.ControlLightLight;
            PlayerTwo.Location = new Point(455, 109);
            PlayerTwo.Name = "PlayerTwo";
            PlayerTwo.Size = new Size(322, 137);
            PlayerTwo.TabIndex = 19;
            PlayerTwo.TabStop = false;
            PlayerTwo.Text = "Player 2";
            // 
            // txt_name_player2
            // 
            txt_name_player2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_name_player2.Location = new Point(6, 63);
            txt_name_player2.Name = "txt_name_player2";
            txt_name_player2.Size = new Size(310, 29);
            txt_name_player2.TabIndex = 4;
            // 
            // lab_name_player2
            // 
            lab_name_player2.AutoSize = true;
            lab_name_player2.Location = new Point(6, 35);
            lab_name_player2.Name = "lab_name_player2";
            lab_name_player2.Size = new Size(64, 25);
            lab_name_player2.TabIndex = 3;
            lab_name_player2.Text = "Name";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(190, 103);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(44, 29);
            radioButton4.TabIndex = 1;
            radioButton4.TabStop = true;
            radioButton4.Text = "O";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(54, 103);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(42, 29);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "X";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // PlayerOne
            // 
            PlayerOne.BackColor = Color.Black;
            PlayerOne.BackgroundImage = (Image)resources.GetObject("PlayerOne.BackgroundImage");
            PlayerOne.Controls.Add(txt_name_player1);
            PlayerOne.Controls.Add(lab_name_player1);
            PlayerOne.Controls.Add(radioButton2);
            PlayerOne.Controls.Add(radioButton1);
            PlayerOne.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PlayerOne.ForeColor = SystemColors.ControlLightLight;
            PlayerOne.Location = new Point(27, 109);
            PlayerOne.Name = "PlayerOne";
            PlayerOne.Size = new Size(330, 136);
            PlayerOne.TabIndex = 18;
            PlayerOne.TabStop = false;
            PlayerOne.Text = "Player 1";
            // 
            // txt_name_player1
            // 
            txt_name_player1.Location = new Point(6, 56);
            txt_name_player1.Name = "txt_name_player1";
            txt_name_player1.Size = new Size(318, 33);
            txt_name_player1.TabIndex = 3;
            // 
            // lab_name_player1
            // 
            lab_name_player1.AutoSize = true;
            lab_name_player1.Location = new Point(6, 28);
            lab_name_player1.Name = "lab_name_player1";
            lab_name_player1.Size = new Size(64, 25);
            lab_name_player1.TabIndex = 2;
            lab_name_player1.Text = "Name";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(182, 102);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(44, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "O";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(52, 102);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(42, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "X";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // startGame
            // 
            startGame.BackColor = Color.Gold;
            startGame.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            startGame.Location = new Point(244, 378);
            startGame.Name = "startGame";
            startGame.Size = new Size(318, 64);
            startGame.TabIndex = 17;
            startGame.Text = "Start Game";
            startGame.UseVisualStyleBackColor = false;
            startGame.Click += startGame_Click;
            // 
            // btnScores
            // 
            btnScores.BackColor = Color.FromArgb(192, 192, 255);
            btnScores.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScores.Location = new Point(677, 395);
            btnScores.Name = "btnScores";
            btnScores.Size = new Size(100, 41);
            btnScores.TabIndex = 22;
            btnScores.Text = "Scores";
            btnScores.UseVisualStyleBackColor = false;
            btnScores.Click += btnScores_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnScores);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(PlayerTwo);
            Controls.Add(PlayerOne);
            Controls.Add(startGame);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "s";
            PlayerTwo.ResumeLayout(false);
            PlayerTwo.PerformLayout();
            PlayerOne.ResumeLayout(false);
            PlayerOne.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1;
        private Label label1;
        private TextBox textBox1;
        private GroupBox PlayerTwo;
        private TextBox txt_name_player2;
        private Label lab_name_player2;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private GroupBox PlayerOne;
        private TextBox txt_name_player1;
        private Label lab_name_player1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button startGame;
        private Button btnScores;
    }
}

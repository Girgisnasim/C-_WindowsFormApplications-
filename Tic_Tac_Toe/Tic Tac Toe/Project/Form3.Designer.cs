namespace Project
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            dvg_Scores = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtPlayerOneNameF3 = new TextBox();
            txtPlayerTwoNameF3 = new TextBox();
            numPlayerTwoScoreF3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numPlayerOneScoreF3 = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dvg_Scores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPlayerTwoScoreF3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPlayerOneScoreF3).BeginInit();
            SuspendLayout();
            // 
            // dvg_Scores
            // 
            dvg_Scores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_Scores.Location = new Point(293, 91);
            dvg_Scores.Name = "dvg_Scores";
            dvg_Scores.Size = new Size(445, 285);
            dvg_Scores.TabIndex = 0;
            dvg_Scores.RowHeaderMouseDoubleClick += dvg_Scores_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(150, 9);
            label1.Name = "label1";
            label1.Size = new Size(446, 79);
            label1.TabIndex = 1;
            label1.Text = "Game Scores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 128);
            label2.Font = new Font("Stencil", 15.75F, FontStyle.Bold);
            label2.Location = new Point(16, 91);
            label2.Name = "label2";
            label2.Size = new Size(208, 25);
            label2.TabIndex = 2;
            label2.Text = "Player One Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 255, 128);
            label3.Font = new Font("Stencil", 15.75F, FontStyle.Bold);
            label3.Location = new Point(12, 185);
            label3.Name = "label3";
            label3.Size = new Size(218, 25);
            label3.TabIndex = 3;
            label3.Text = "Player One Score";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 255, 128);
            label4.Font = new Font("Stencil", 15.75F, FontStyle.Bold);
            label4.Location = new Point(16, 267);
            label4.Name = "label4";
            label4.Size = new Size(211, 25);
            label4.TabIndex = 4;
            label4.Text = "Player Two Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 255, 128);
            label5.Font = new Font("Stencil", 15.75F, FontStyle.Bold);
            label5.Location = new Point(13, 351);
            label5.Name = "label5";
            label5.Size = new Size(221, 25);
            label5.TabIndex = 5;
            label5.Text = "Player Two Score";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.Font = new Font("Showcard Gothic", 18F);
            btnAdd.Location = new Point(259, 399);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(157, 39);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Font = new Font("Showcard Gothic", 18F);
            btnUpdate.Location = new Point(439, 399);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(157, 39);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.Font = new Font("Showcard Gothic", 18F);
            btnDelete.Location = new Point(619, 399);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(157, 39);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtPlayerOneNameF3
            // 
            txtPlayerOneNameF3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtPlayerOneNameF3.Location = new Point(29, 134);
            txtPlayerOneNameF3.Name = "txtPlayerOneNameF3";
            txtPlayerOneNameF3.Size = new Size(195, 33);
            txtPlayerOneNameF3.TabIndex = 9;
            // 
            // txtPlayerTwoNameF3
            // 
            txtPlayerTwoNameF3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtPlayerTwoNameF3.Location = new Point(29, 304);
            txtPlayerTwoNameF3.Name = "txtPlayerTwoNameF3";
            txtPlayerTwoNameF3.Size = new Size(195, 33);
            txtPlayerTwoNameF3.TabIndex = 11;
            // 
            // numPlayerTwoScoreF3
            // 
            numPlayerTwoScoreF3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            numPlayerTwoScoreF3.Location = new Point(69, 389);
            numPlayerTwoScoreF3.Name = "numPlayerTwoScoreF3";
            numPlayerTwoScoreF3.Size = new Size(103, 33);
            numPlayerTwoScoreF3.TabIndex = 13;
            numPlayerTwoScoreF3.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(89, 758);
            numericUpDown2.Margin = new Padding(6);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(191, 23);
            numericUpDown2.TabIndex = 14;
            numericUpDown2.TextAlign = HorizontalAlignment.Center;
            // 
            // numPlayerOneScoreF3
            // 
            numPlayerOneScoreF3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            numPlayerOneScoreF3.Location = new Point(69, 222);
            numPlayerOneScoreF3.Name = "numPlayerOneScoreF3";
            numPlayerOneScoreF3.Size = new Size(103, 33);
            numPlayerOneScoreF3.TabIndex = 13;
            numPlayerOneScoreF3.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.DarkViolet;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(51, 459);
            button1.Name = "button1";
            button1.Size = new Size(142, 46);
            button1.TabIndex = 15;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(798, 517);
            Controls.Add(button1);
            Controls.Add(numericUpDown2);
            Controls.Add(numPlayerOneScoreF3);
            Controls.Add(numPlayerTwoScoreF3);
            Controls.Add(txtPlayerTwoNameF3);
            Controls.Add(txtPlayerOneNameF3);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dvg_Scores);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dvg_Scores).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPlayerTwoScoreF3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPlayerOneScoreF3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvg_Scores;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtPlayerOneNameF3;
        private TextBox txtPlayerTwoNameF3;
        private NumericUpDown numPlayerTwoScoreF3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numPlayerOneScoreF3;
        private Button button1;
    }
}
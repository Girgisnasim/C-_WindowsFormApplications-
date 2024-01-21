using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form2 : Form
    {
        Boolean checker;
        int plusOne;
        public void Enable_false()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }
        public void Enable_true()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }
        public void clear()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            btn1.BackColor = Color.WhiteSmoke;
            btn2.BackColor = Color.WhiteSmoke;
            btn3.BackColor = Color.WhiteSmoke;
            btn4.BackColor = Color.WhiteSmoke;
            btn5.BackColor = Color.WhiteSmoke;
            btn6.BackColor = Color.WhiteSmoke;
            btn7.BackColor = Color.WhiteSmoke;
            btn8.BackColor = Color.WhiteSmoke;
            btn9.BackColor = Color.WhiteSmoke;
        }
        public void Score()
        {
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                btn3.BackColor = Color.Green;

                MessageBox.Show("The winner is player X");
                plusOne = int.Parse(ScorePlayerOne.Text);
                ScorePlayerOne.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }
            if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                btn1.BackColor = Color.Green;
                btn4.BackColor = Color.Green;
                btn7.BackColor = Color.Green;

                MessageBox.Show("The winner is player X");
                plusOne = int.Parse(ScorePlayerOne.Text);
                ScorePlayerOne.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }
            if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                btn1.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn9.BackColor = Color.Green;

                MessageBox.Show("The winner is player X");
                plusOne = int.Parse(ScorePlayerOne.Text);
                ScorePlayerOne.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }
            if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                btn2.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn8.BackColor = Color.Green;

                MessageBox.Show("The winner is player X");
                plusOne = int.Parse(ScorePlayerOne.Text);
                ScorePlayerOne.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }
            if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                btn3.BackColor = Color.Green;
                btn6.BackColor = Color.Green;
                btn9.BackColor = Color.Green;

                MessageBox.Show("The winner is player X");
                plusOne = int.Parse(ScorePlayerOne.Text);
                ScorePlayerOne.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }
            if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                btn3.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn7.BackColor = Color.Green;

                MessageBox.Show("The winner is player X");
                plusOne = int.Parse(ScorePlayerOne.Text);
                ScorePlayerOne.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }
            if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                btn4.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn6.BackColor = Color.Green;

                MessageBox.Show("The winner is player X");
                plusOne = int.Parse(ScorePlayerOne.Text);
                ScorePlayerOne.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }
            if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                btn7.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                btn9.BackColor = Color.Green;

                MessageBox.Show("The winner is player X");
                plusOne = int.Parse(ScorePlayerOne.Text);
                ScorePlayerOne.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }
            //====================================================================
            //Check_O

            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                btn3.BackColor = Color.Green;

                MessageBox.Show("The winner is player O");
                plusOne = int.Parse(ScorePlayerTwo.Text);
                ScorePlayerTwo.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }
            if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
            {
                btn1.BackColor = Color.Green;
                btn4.BackColor = Color.Green;
                btn7.BackColor = Color.Green;

                MessageBox.Show("The winner is player O");
                plusOne = int.Parse(ScorePlayerTwo.Text);
                ScorePlayerTwo.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }
            if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                btn1.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn9.BackColor = Color.Green;

                MessageBox.Show("The winner is player O");
                plusOne = int.Parse(ScorePlayerTwo.Text);
                ScorePlayerTwo.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }
            if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                btn2.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn8.BackColor = Color.Green;

                MessageBox.Show("The winner is player O");
                plusOne = int.Parse(ScorePlayerTwo.Text);
                ScorePlayerTwo.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }
            if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                btn3.BackColor = Color.Green;
                btn6.BackColor = Color.Green;
                btn9.BackColor = Color.Green;

                MessageBox.Show("The winner is player O");
                plusOne = int.Parse(ScorePlayerTwo.Text);
                ScorePlayerTwo.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }
            if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                btn3.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn7.BackColor = Color.Green;

                MessageBox.Show("The winner is player O");
                plusOne = int.Parse(ScorePlayerTwo.Text);
                ScorePlayerTwo.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }
            if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
            {
                btn4.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn6.BackColor = Color.Green;

                MessageBox.Show("The winner is player O");
                plusOne = int.Parse(ScorePlayerTwo.Text);
                ScorePlayerTwo.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }
            if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                btn7.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                btn9.BackColor = Color.Green;

                MessageBox.Show("The winner is player O");
                plusOne = int.Parse(ScorePlayerTwo.Text);
                ScorePlayerTwo.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }
        }
        public Form2(string playerOneName, string playerTwoName)
        {
            InitializeComponent();
            labPlayerOneF2.Text = playerOneName;
            labPlayerTwoF2.Text = playerTwoName;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn1.Text = "X";
                checker = true;
            }
            else
            {
                btn1.Text = "O";
                checker = false;
            }
            Score();
            btn1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                btn2.Text = "X";
                checker = true;
            }
            else
            {
                btn2.Text = "O";
                checker = false;
            }
            Score();
            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                btn3.Text = "X";
                checker = true;
            }
            else
            {
                btn3.Text = "O";
                checker = false;
            }
            Score();
            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                btn4.Text = "X";
                checker = true;
            }
            else
            {
                btn4.Text = "O";
                checker = false;
            }
            Score();
            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                btn5.Text = "X";
                checker = true;
            }
            else
            {
                btn5.Text = "O";
                checker = false;
            }
            Score();
            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                btn6.Text = "X";
                checker = true;
            }
            else
            {
                btn6.Text = "O";
                checker = false;
            }
            Score();
            btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                btn7.Text = "X";
                checker = true;
            }
            else
            {
                btn7.Text = "O";
                checker = false;
            }
            Score();
            btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                btn8.Text = "X";
                checker = true;
            }
            else
            {
                btn8.Text = "O";
                checker = false;
            }
            Score();
            btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                btn9.Text = "X";
                checker = true;
            }
            else
            {
                btn9.Text = "O";
                checker = false;
            }
            Score();
            btn9.Enabled = false;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Enable_true();
            clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Enable_true();
            clear();
            ScorePlayerOne.Text = "0";
            ScorePlayerTwo.Text = "0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm if you want to exit", "TicTacToe", MessageBoxButtons.YesNo);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK);
            }
        }

        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-QFJECRL;Database=Tic_Tac_Toe;Trusted_Connection=True;TrustServerCertificate=True");
            int count = 0;
            count++;
            SqlCommand cmd = new SqlCommand($"insert into usersScores ( [PlayerOneName], [ScorePlayerOne], [PlayerTwoName],[ScorePlayerTwo]) values('{labPlayerOneF2.Text}','{ScorePlayerOne.Text}','{labPlayerTwoF2.Text}',{ScorePlayerTwo.Text})", con);
            int rowsEffected = 0;
            try
            {
                // open connection
                con.Open();
                // exceute
                rowsEffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // close connection
                con.Close();
            }

            if (rowsEffected > 0)
            {
                MessageBox.Show("Data was insereted");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();

        }
    }
}

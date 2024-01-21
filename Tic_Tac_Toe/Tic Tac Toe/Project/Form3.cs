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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void ShowEditButtons(bool show)
        {
            btnDelete.Visible = show;
            btnUpdate.Visible = show;
            btnAdd.Visible = !show;
        }

        public void ClearInputs()
        {
            txtPlayerOneNameF3.Text = txtPlayerTwoNameF3.Text = string.Empty;
            numPlayerOneScoreF3.Value = numPlayerTwoScoreF3.Value = 0;
        }
        public void getScore()
        {
            string conString = "Server=DESKTOP-QFJECRL;Database=Tic_Tac_Toe;Trusted_Connection=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(conString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select [ID],[PlayerOneName],[ScorePlayerOne],[PlayerTwoName],[ScorePlayerTwo] from usersScores;";

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            // close connection
            conn.Close();
            dvg_Scores.DataSource = dt;
            dvg_Scores.Columns["ID"].Visible = false;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            getScore();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-QFJECRL;Database=Tic_Tac_Toe;Trusted_Connection=True;TrustServerCertificate=True");

            SqlCommand cmd = new SqlCommand($"insert into usersScores([PlayerOneName],[ScorePlayerOne],[PlayerTwoName],[ScorePlayerTwo]) values('{txtPlayerOneNameF3.Text}',{numPlayerOneScoreF3.Value},'{txtPlayerTwoNameF3.Text}',{numPlayerTwoScoreF3.Value})", con);
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
                getScore();
            }
        }
        int currentId = 0;
        private void dvg_Scores_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = this.dvg_Scores.SelectedRows[0];
            currentId = (int)row.Cells["ID"].Value;

            txtPlayerOneNameF3.Text = row.Cells["PlayerOneName"].Value.ToString();
            numPlayerOneScoreF3.Value = Convert.ToDecimal(row.Cells["ScorePlayerOne"].Value);
            txtPlayerTwoNameF3.Text = row.Cells["PlayerTwoName"].Value.ToString();
            numPlayerTwoScoreF3.Value = Convert.ToDecimal(row.Cells["ScorePlayerTwo"].Value);
            ShowEditButtons(true);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-QFJECRL;Database=Tic_Tac_Toe;Trusted_Connection=True;TrustServerCertificate=True");

            SqlCommand cmd = new SqlCommand($"update usersScores set [PlayerOneName]=@namePlayer1,[ScorePlayerOne]=@scorePlayer1,[PlayerTwoName]=@namePlayer2,[ScorePlayerTwo]=@scorePlayer2 where [ID] = @id", con);
            cmd.Parameters.AddWithValue("id", currentId);
            cmd.Parameters.AddWithValue("namePlayer1", txtPlayerOneNameF3.Text);
            cmd.Parameters.AddWithValue("scorePlayer1", numPlayerOneScoreF3.Value);
            cmd.Parameters.AddWithValue("namePlayer2", txtPlayerTwoNameF3.Text);
            cmd.Parameters.AddWithValue("scorePlayer2", numPlayerTwoScoreF3.Value);



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
                MessageBox.Show("Data was updated");
                getScore();
            }
            ShowEditButtons(false);
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-QFJECRL;Database=Tic_Tac_Toe;Trusted_Connection=True;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand($"delete from usersScores where [ID] = @id", con);

            cmd.Parameters.AddWithValue("id", currentId);
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
                MessageBox.Show("Data was deleted");
                getScore();
            }
            ShowEditButtons(false);
            ClearInputs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();

        }
    }
}

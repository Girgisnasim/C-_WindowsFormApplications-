namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void checkBoxVaildtion()
        {
            if (radioButton1.Checked)
            {
                radioButton4.Checked = true;

            }
            else if (radioButton2.Checked)
            {
                radioButton3.Checked = true;

            }
        }
        public void checkBoxVaildtion2()
        {
            if (radioButton3.Checked)
            {
                radioButton2.Checked = true;
            }
            else if (radioButton4.Checked)
            {
                radioButton1.Checked = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxVaildtion();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxVaildtion();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxVaildtion2();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxVaildtion2();
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_name_player1.Text) && !string.IsNullOrWhiteSpace(txt_name_player2.Text))
            {
                Form2 form2 = new Form2(txt_name_player1.Text, txt_name_player2.Text);

                if (radioButton1.Checked)
                {
                    MessageBox.Show($"{txt_name_player1.Text} will play with {radioButton1.Text} and {txt_name_player2.Text} will play with {radioButton4.Text}");
                }
                else if (radioButton2.Checked)
                {
                    MessageBox.Show($"{txt_name_player1.Text} will play with {radioButton2.Text} and {txt_name_player2.Text} will play with {radioButton3.Text}");
                }
                this.Hide();
                form2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Enter Data");
            }

        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            Form3 form3=new Form3();
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }
    }
}

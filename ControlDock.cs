using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveySquabbleApp
{
    public partial class ControlDock : Form
    {

        public ControlDock()
        {
            InitializeComponent();
        }

        public static void RevealHandler(int revealNum, string answer, string score)
        {
            switch (revealNum)
            {
                case 1:
                    Program.ungaBunga.ans1 = answer;
                    Program.ungaBunga.pts1 = score;
                    break;
                          
                case 2:
                    Program.ungaBunga.ans2 = answer;
                    Program.ungaBunga.pts2 = score;
                    break;
                          
                case 3:
                    Program.ungaBunga.ans3 = answer;
                    Program.ungaBunga.pts3 = score;
                    break;
                          
                case 4:
                    Program.ungaBunga.ans4 = answer;
                    Program.ungaBunga.pts4 = score;
                    break;
                          
                case 5:
                    Program.ungaBunga.ans5 = answer;
                    Program.ungaBunga.pts5 = score;
                    break;
                          
                case 6:
                    Program.ungaBunga.ans6 = answer;
                    Program.ungaBunga.pts6 = score;
                    break;
                          
                case 7:
                    Program.ungaBunga.ans7 = answer;
                    Program.ungaBunga.pts7 = score;
                    break;
                          
                case 8:
                    Program.ungaBunga.ans8 = answer;
                    Program.ungaBunga.pts8 = score;
                    break;
                          
                default:
                    break;
            }

            Program.ungaBunga.answerUpdated = false;
            Program.ungaBunga.ptsUpdated = false;
        }

        private void ChkVisible1_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVisible1.Checked)
            {
                RevealHandler(1, txtAnswer1.Text, txtScore1.Text);
            }
        }

        private void ChkVisible2_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVisible2.Checked)
            {
                RevealHandler(2, txtAnswer2.Text, txtScore2.Text);
            }
        }

        private void ChkVisible3_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVisible3.Checked)
            {
                RevealHandler(3, txtAnswer3.Text, txtScore3.Text);
            }
        }

        private void ChkVisible4_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVisible4.Checked)
            {
                RevealHandler(4, txtAnswer4.Text, txtScore4.Text);
            }
        }

        private void ChkVisible5_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVisible5.Checked)
            {
                RevealHandler(5, txtAnswer5.Text, txtScore5.Text);
            }
        }

        private void ChkVisible6_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVisible6.Checked)
            {
                RevealHandler(6, txtAnswer6.Text, txtScore6.Text);
            }
        }

        private void ChkVisible7_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVisible7.Checked)
            {
                RevealHandler(7, txtAnswer7.Text, txtScore7.Text);
            }
        }

        private void ChkVisible8_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVisible8.Checked)
            {
                RevealHandler(8, txtAnswer8.Text, txtScore8.Text);
            }
        }

        private void ChkStrike1_CheckedChanged(object sender, EventArgs e)
        {
            Program.ungaBunga.strike1 = ChkStrike1.Checked;
        }

        private void ChkStrike2_CheckedChanged(object sender, EventArgs e)
        {
            Program.ungaBunga.strike2 = ChkStrike2.Checked;
        }

        private void ChkStrike3_CheckedChanged(object sender, EventArgs e)
        {
            Program.ungaBunga.strike3 = ChkStrike3.Checked;
        }


        //The "New Question" function. Empties every field in the form.
        //

        private void BtnNew_Click(object sender, EventArgs e)
        {

            txtQuestion.Text = "";

            txtAnswer1.Text = "";
            txtScore1.Text = "";
            ChkVisible1.Checked = false;
            Program.ungaBunga.ans1 = "";
            Program.ungaBunga.pts1 = "";

            txtAnswer2.Text = "";
            txtScore2.Text = "";
            ChkVisible2.Checked = false;
            Program.ungaBunga.ans2 = "";
            Program.ungaBunga.pts2 = "";

            txtAnswer3.Text = "";
            txtScore3.Text = "";
            ChkVisible3.Checked = false;
            Program.ungaBunga.ans3 = "";
            Program.ungaBunga.pts3 = "";

            txtAnswer4.Text = "";
            txtScore4.Text = "";
            ChkVisible4.Checked = false;
            Program.ungaBunga.ans4 = "";
            Program.ungaBunga.pts4 = "";

            txtAnswer5.Text = "";
            txtScore5.Text = "";
            ChkVisible5.Checked = false;
            Program.ungaBunga.ans5 = "";
            Program.ungaBunga.pts5 = "";

            txtAnswer6.Text = "";
            txtScore6.Text = "";
            ChkVisible6.Checked = false;
            Program.ungaBunga.ans6 = "";
            Program.ungaBunga.pts6 = "";

            txtAnswer7.Text = "";
            txtScore7.Text = "";
            ChkVisible7.Checked = false;
            Program.ungaBunga.ans7 = "";
            Program.ungaBunga.pts7 = "";

            txtAnswer8.Text = "";
            txtScore8.Text = "";
            ChkVisible8.Checked = false;
            Program.ungaBunga.ans8 = "";
            Program.ungaBunga.pts8 = "";

            ChkStrike1.Checked = false;
            ChkStrike2.Checked = false;
            ChkStrike3.Checked = false;

            Program.ungaBunga.questionCopy = txtQuestion.Text;
            Program.ungaBunga.questionUpdated = false;
            Program.ungaBunga.ptsUpdated = false;
            Program.ungaBunga.answerUpdated = false;

        }

        private void BtnShowNum_Click(object sender, EventArgs e)
        {
            string[] arrayAns = new string[8];
            string[] arrayScore = new string[8];

            arrayAns[0] = txtAnswer1.Text.Trim();
            arrayAns[1] = txtAnswer2.Text.Trim();
            arrayAns[2] = txtAnswer3.Text.Trim();
            arrayAns[3] = txtAnswer4.Text.Trim();
            arrayAns[4] = txtAnswer5.Text.Trim();
            arrayAns[5] = txtAnswer6.Text.Trim();
            arrayAns[6] = txtAnswer7.Text.Trim();
            arrayAns[7] = txtAnswer8.Text.Trim();

            arrayScore[0] = txtScore1.Text.Trim();
            arrayScore[1] = txtScore2.Text.Trim();
            arrayScore[2] = txtScore3.Text.Trim();
            arrayScore[3] = txtScore4.Text.Trim();
            arrayScore[4] = txtScore5.Text.Trim();
            arrayScore[5] = txtScore6.Text.Trim();
            arrayScore[6] = txtScore7.Text.Trim();
            arrayScore[7] = txtScore8.Text.Trim();

            int numAnswers = 0;

            for (int i = 0; i < 8; i++)
            {
                if(arrayAns[i] != "" && arrayScore[i] != "")
                {
                    numAnswers++;
                }
            }

            Program.ungaBunga.numAnswers = numAnswers;
            Program.ungaBunga.answerNumUpdated = false;

        }

        private void BtnShowQuestion_Click(object sender, EventArgs e)
        {
            Program.ungaBunga.questionCopy = txtQuestion.Text;
            Program.ungaBunga.questionUpdated = false;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            
            Program.ungaBunga.team1Name = txtTeamName1.Text;
            Program.ungaBunga.team2Name = txtTeamName2.Text;
            Program.ungaBunga.team1Score = txtTeamScore1.Text;
            Program.ungaBunga.team2Score = txtTeamScore2.Text;
            Program.ungaBunga.teamScoreUpdated = false;
            
        }
    }
}

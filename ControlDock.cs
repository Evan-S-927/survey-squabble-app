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

        //Takes in answer number, answer text and score value as parameters.
        //Logic is controlled via a switch statement, passes answer/score text to Game instance
        //and sets flags for them to be updated.
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


        //Called upon check of "Is it Visible?" checkbox for each answer.
        //Calls ControlDock.RevealHandler with which answer it is, and the answer/score text.
        //Deactivation logic not written. Maybe to be done by 1.1? Not sure if I'll update this.

        //BUG: answer display gets rid of every other answer

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


        //Strikes are handled in real time without flags because they change so frequently
        //and are relatively resource light. 
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


        //Called on "New Question" button push. 
        //Empties every field in both forms that isn't meant to be permanent.
        //Important cosmetic and QoL function.
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

        //Called on "Show Number of Answers" button push.
        //Trims every input and displays a number for each answer, whether it's complete or not.
        //Initially checked for if the user had entered both before displaying a number,
        //but was changed so that human error did not appear to be the app's fault.
        //Also sets a flag to update these things on the "Game" form.
        //Important so the players remember how many possible answers there are at a glance.
        private void BtnShowNum_Click(object sender, EventArgs e)
        {

            if (txtAnswer1.Text.Trim() != "" || txtScore1.Text.Trim() != "")
            {
                Program.ungaBunga.ans1 = "( 1 )";
            }
                        
            if (txtAnswer2.Text.Trim() != "" || txtScore2.Text.Trim() != "")
            {
                Program.ungaBunga.ans2 = "( 2 )";
            }
                        
            if (txtAnswer3.Text.Trim() != "" || txtScore3.Text.Trim() != "")
            {
                Program.ungaBunga.ans3 = "( 3 )";
            }
                        
            if (txtAnswer4.Text.Trim() != "" || txtScore4.Text.Trim() != "")
            {
                Program.ungaBunga.ans4 = "( 4 )";
            }
                        
            if (txtAnswer5.Text.Trim() != "" || txtScore5.Text.Trim() != "")
            {
                Program.ungaBunga.ans5 = "( 5 )";
            }
                        
            if (txtAnswer6.Text.Trim() != "" || txtScore6.Text.Trim() != "")
            {
                Program.ungaBunga.ans6 = "( 6 )";
            }
                        
            if (txtAnswer7.Text.Trim() != "" || txtScore7.Text.Trim() != "")
            {
                Program.ungaBunga.ans7 = "( 7 )";
            }
                        
            if (txtAnswer8.Text.Trim() != "" || txtScore8.Text.Trim() != "")
            {
                Program.ungaBunga.ans8 = "( 8 )";
            }

            Program.ungaBunga.answerUpdated = false;

        }

        //Called on "Show Question" button push.
        //Passes through the Question and sets the flag to update it.
        private void BtnShowQuestion_Click(object sender, EventArgs e)
        {
            Program.ungaBunga.questionCopy = txtQuestion.Text;
            Program.ungaBunga.questionUpdated = false;
        }

        //Called on "Update Scores and Team Names" button push.
        //Passes through the name and score for each team and sets the flag to update them.
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

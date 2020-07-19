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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        
        //Potential security issues associated with public variables noted, but this
        //is a program that does not need to worry about security for the most part.
        //This was also my solution to deal with the issue of using forms on separate threads
        //that need to work together but can't communicate. Not elegant/best practice but works.

        //Strikes 
        public bool strike1;
        public bool strike2;
        public bool strike3;

        //Question Text and Update Flag
        public bool questionUpdated = true;
        public string questionCopy;

        //Number of Answers and Update Flag (for "Show Number of Answers" button)
        public bool answerNumUpdated = true;
        public int numAnswers = 0;

        //Team Scores and Names, and Update Flag
        public bool teamScoreUpdated = true;
        public string team1Name;
        public string team2Name;
        public string team1Score;
        public string team2Score;

        //Individual Answer Scores and Update Flag
        public bool ptsUpdated = true;
        public string pts1;
        public string pts2;
        public string pts3;
        public string pts4;
        public string pts5;
        public string pts6;
        public string pts7;
        public string pts8;

        //Individual Answer Text and Update Flag
        public bool answerUpdated = true;
        public string ans1;
        public string ans2;
        public string ans3;
        public string ans4;
        public string ans5;
        public string ans6;
        public string ans7;
        public string ans8;

        //I do not know how to use Message Queues, and this timer supplants this for now.
        //Update flags used so that most of the logic is skipped every tick (each tick happens
        //every 500ms so we want to cut down on unnecessary processor work).
        private void tmr_MessageQueue_Tick(object sender, EventArgs e)
        {
            ChkStrike1.Checked = strike1;
            ChkStrike2.Checked = strike2;
            ChkStrike3.Checked = strike3;

            if (!answerNumUpdated)
            {
                if (numAnswers == 8) lbl_Answer8.Text = "( 8 )";
                if (numAnswers >= 7) lbl_Answer7.Text = "( 7 )";
                if (numAnswers >= 6) lbl_Answer6.Text = "( 6 )";
                if (numAnswers >= 5) lbl_Answer5.Text = "( 5 )";
                if (numAnswers >= 4) lbl_Answer4.Text = "( 4 )";
                if (numAnswers >= 3) lbl_Answer3.Text = "( 3 )";
                if (numAnswers >= 2) lbl_Answer2.Text = "( 2 )";
                if (numAnswers >= 1) lbl_Answer1.Text = "( 1 )";
                answerNumUpdated = true;
            }

            if (!teamScoreUpdated)
            {
                lbl_TeamName1.Text = team1Name;
                lbl_TeamName2.Text = team2Name;
                lbl_Score1.Text = team1Score;
                lbl_Score2.Text = team2Score;
                teamScoreUpdated = true;
            }

            if (!questionUpdated)
            {
                lbl_Question.Text = questionCopy;
                questionUpdated = true;
            }
            
            if (!ptsUpdated)
            {
                lbl_Pts1.Text = pts1;
                lbl_Pts2.Text = pts2;
                lbl_Pts3.Text = pts3;
                lbl_Pts4.Text = pts4;
                lbl_Pts5.Text = pts5;
                lbl_Pts6.Text = pts6;
                lbl_Pts7.Text = pts7;
                lbl_Pts8.Text = pts8;
                ptsUpdated = true;
            }
            
            if (!answerUpdated)
            {
                lbl_Answer1.Text = ans1;
                lbl_Answer2.Text = ans2;
                lbl_Answer3.Text = ans3;
                lbl_Answer4.Text = ans4;
                lbl_Answer5.Text = ans5;
                lbl_Answer6.Text = ans6;
                lbl_Answer7.Text = ans7;
                lbl_Answer8.Text = ans8;
                answerUpdated = true;
            }
        }

    }
}

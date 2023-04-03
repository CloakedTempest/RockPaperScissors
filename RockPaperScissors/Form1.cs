using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        bool singleplayer = true;
        Random rand = new Random();
        string[] gameKey = { "rock", "paper", "scissors" };
        int[] choices = { -1, -1 };
        int gameNum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cover.Controls.Add(SingleplayerButton);
            Cover.Controls.Add(MultiplayerButton);
            Cover.Controls.Remove(ResultBox);
        }

        private void findWinner(int choice)
        {
            if (singleplayer)
            { choices[0] = choice; choices[1] = rand.Next(3); }
            else
            {
                if (choices[0] == -1) { choices[0] = choice; return; }
                else { choices[1] = choice; }
            }
            string result = "drew";
            switch (choices[0])
            {
                  case 0 when choices[1] == 1:
                    result = "lost";
                    break;
                  case 0 when choices[1] == 2:
                    result = "won";
                    break;
                  case 1 when choices[1] == 0:
                    result = "won";
                    break;
                  case 1 when choices[1] == 2:
                    result = "lost";
                    break;
                  case 2 when choices[1] == 0:
                    result = "lost";
                    break;
                  case 2 when choices[1] == 1:
                    result = "won";
                    break;
                  default:
                    result = "drew";
                    break;
            }
            ResultBox.Text = "Player 1 " + result + ". Player 2 chose " + gameKey[choices[1]];
            if (result == "won")
                Score1.Text = Convert.ToString(Convert.ToInt32(Score1.Text) + 1);
            else if(result == "lost")
                Score2.Text = Convert.ToString(Convert.ToInt32(Score2.Text) + 1);

            choices[0] = -1;
            choices[1] = -1;
            gameNum++;
            if (gameNum >= 5)
            {
                using (StreamWriter writer = new StreamWriter("C:/Users/thoma/Desktop/CollegeWork/RockPaperScissors/RockPaperScissors/Resources/Names.txt"))
                {
                    writer.WriteLine(Player1Name.Text + ": " + Score1.Text);
                    if (!singleplayer)
                        writer.WriteLine(Player2Name.Text + ": " + Score2);
                }
                gameNum = 0;
                Player1Name.Text = "";
                Player2Name.Text = "";
                Score1.Text = "0";
                Score2.Text = "0";
            }
        }

        private void SingleplayerButton_Click(object sender, EventArgs e)
        {
            Cover.Hide();
            Player2Name.Hide();
            label2.Hide();
            Score2.Hide();
        }

        private void MultiplayerButton_Click(object sender, EventArgs e)
        {
            Cover.Hide();
            singleplayer = false;
        }

        private void RockButton_Click(object sender, EventArgs e)
        {
            ResultBox.Text = " ";
            findWinner(0);
        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            ResultBox.Text = " ";
            findWinner(1);
        }

        private void ScissorsButton_Click(object sender, EventArgs e)
        {
            ResultBox.Text = " ";
            findWinner(2);
        }

        private void ResultBox_Click(object sender, EventArgs e)
        {
            ResultBox.Text = " ";
            choices[0] = -1;
            choices[1] = -1;
        }

        private void Singleplayer_Enter(object sender, EventArgs e)
        {
            SingleplayerButton.BackColor = Color.DarkOliveGreen;
        }

        private void Singleplayer_Leave(object sender, EventArgs e)
        {
            SingleplayerButton.BackColor = Color.OliveDrab;
        }

        private void Multiplayer_Enter(object sender, EventArgs e)
        {
            MultiplayerButton.BackColor = Color.DarkOliveGreen;
        }

        private void Multiplayer_Leave(object sender, EventArgs e)
        {
            MultiplayerButton.BackColor = Color.OliveDrab;
        }

        private void RockClick(object sender, EventArgs e)
        {
            ResultBox.Text = " ";
            findWinner(0);
        }

        private void PaperClick(object sender, EventArgs e)
        {
            ResultBox.Text = " ";
            findWinner(1);
        }

        private void ScissorsClick(object sender, EventArgs e)
        {
            ResultBox.Text = " ";
            findWinner(2);
        }

        private void RockEnter(object sender, EventArgs e)
        {
            RockIcon.ForeColor = Color.Red;
        }

        private void RockLeave(object sender, EventArgs e)
        {
            RockIcon.ForeColor = Color.DarkSlateGray;
        }

        private void PaperEnter(object sender, EventArgs e)
        {
            PaperIcon.ForeColor = Color.Red;
        }

        private void PaperLeave(object sender, EventArgs e)
        {
            PaperIcon.ForeColor = Color.DarkSlateGray;
        }

        private void ScissorsEnter(object sender, EventArgs e)
        {
            ScissorsIcon.ForeColor = Color.Red;
        }

        private void ScissorsLeave(object sender, EventArgs e)
        {
            ScissorsIcon.ForeColor = Color.DarkSlateGray;
        }
    }
}

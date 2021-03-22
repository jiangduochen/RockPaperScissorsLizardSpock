using System;
using System.Windows.Forms;

namespace RockPaperScissorsLizardSpock_JC_Ginger
{
    public partial class Form1 : Form
    {
        int rounds = 3;
        int timerPerRound = 6;
        bool gameOver = false;

        string[] CPUchoiceList = {"rock", "paper", "scissors", "lizard", "spock", "scissors", "lizard", "rock", "paper", "spock" };

        int randomNumber = 0;

        Random rnd = new Random();

        string CPUChoice;

        string playerChoice;

        int playerScore;
        int CPUScore;

        public Form1()
        {
            InitializeComponent();

            countDownTimer.Enabled = true;

            playerChoice = "none";

            txtCountDown.Text = "5";
        }
        private void btnPaper_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.paper;
            playerChoice = "paper";
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.rock;
            playerChoice = "rock";
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.scissors;
            playerChoice = "scissors";
        }

        private void btnLizard_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.lizard;
            playerChoice = "lizard";
        }

        private void btnSpock_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.spock;
            playerChoice = "spock";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            playerScore = 0;
            CPUScore = 0;
            rounds = 3;
            txtScore.Text = "Player: " + playerScore + " - " + "CPU: " + CPUScore;

            playerChoice = "none";

            countDownTimer.Enabled = true;

            picPlayer.Image = Properties.Resources.qq;
            picCPU.Image = Properties.Resources.qq;

            gameOver = false;

        }

        private void countDownTimerEvent(object sender, EventArgs e)
        {
            timerPerRound -= 1;
            
            txtCountDown.Text = timerPerRound.ToString();

            txtRounds.Text = "Rounds:" + rounds;

            if(timerPerRound <1)
            {
                countDownTimer.Enabled = false;

                timerPerRound = 6;

                randomNumber = rnd.Next(0, CPUchoiceList.Length);

                CPUChoice = CPUchoiceList[randomNumber];

                switch(CPUChoice)
                {
                    case "rock":
                        picCPU.Image = Properties.Resources.rock;
                        break;
                    case "paper":
                        picCPU.Image = Properties.Resources.paper;
                        break;
                    case "scissors":
                        picCPU.Image = Properties.Resources.scissors;
                        break;
                    case "lizard":
                        picCPU.Image = Properties.Resources.lizard;
                        break;
                    case "spock":
                        picCPU.Image = Properties.Resources.spock;
                        break;
                }

                if (rounds > 0)
                {
                    checkGame();
                }
                else
                {
                    if (playerScore > CPUScore)
                    {
                        MessageBox.Show("Player won the game.");
                    }
                    else
                    {
                        MessageBox.Show("CPU won the game.");
                    }
                    gameOver = true;
                }
            }
        }

        private void checkGame()
        {
            if(playerChoice == "rock" && CPUChoice == "paper")
            {
                CPUScore += 1;

                rounds -= 1;

                MessageBox.Show("CPU Wins: Paper covers Rock");
            }
            else if (playerChoice == "scissors" && CPUChoice == "rock")
            {
                CPUScore += 1;

                rounds -= 1;

                MessageBox.Show("CPU Wins: Rock breaks Scissors");
            }
            else if (playerChoice == "paper" && CPUChoice == "scissors")
            {
                CPUScore += 1;

                rounds -= 1;

                MessageBox.Show("CPU Wins: Scissor cuts Paper");
            }
            else if (playerChoice == "rock" && CPUChoice == "scissors")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins: Rock breaks Scissors");
            }
            else if (playerChoice == "paper" && CPUChoice == "rock")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins: Paper covers Rock");
            }
            else if (playerChoice == "scissors" && CPUChoice == "paper")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins: Scissor cuts Paper");
            }
            else if (playerChoice == "rock" && CPUChoice == "lizard")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins: Rock crushes Lizard");
            }
            else if (playerChoice == "lizard" && CPUChoice == "rock")
            {
                CPUScore += 1;

                rounds -= 1;

                MessageBox.Show("CPU Wins: Rock crushes Lizard");
            }
            else if (playerChoice == "lizard" && CPUChoice == "spock")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins: Lizard poisons Spock");
            }
            else if (playerChoice == "spock" && CPUChoice == "lizard")
            {
                CPUScore += 1;

                rounds -= 1;

                MessageBox.Show("CPU Wins: Lizard poisons Spock");
            }
            else if (playerChoice == "scissors" && CPUChoice == "spock")
            {
                CPUScore += 1;

                rounds -= 1;

                MessageBox.Show("CPU Wins: Spock smashes Scissors");
            }
            else if (playerChoice == "spock" && CPUChoice == "scissors")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins: Spock smashes Scissors");
            }
            else if (playerChoice == "paper" && CPUChoice == "lizard")
            {
                CPUScore += 1;

                rounds -= 1;

                MessageBox.Show("CPU Wins: Lizard eats Paper");
            }
            else if (playerChoice == "lizard" && CPUChoice == "paper")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins: Lizard eats Paper");
            }
            else if (playerChoice == "paper" && CPUChoice == "spock")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins: Paper disproves Spock");
            }
            else if (playerChoice == "spock" && CPUChoice == "paper")
            {
                CPUScore += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins: Paper disproves Spock");
            }
            else if (playerChoice == "rock" && CPUChoice == "spock")
            {
                CPUScore += 1;

                rounds -= 1;

                MessageBox.Show("CPU Wins: Spock vaporates Rock");
            }
            else if (playerChoice == "spock" && CPUChoice == "rock")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins: Spock vaporates Rock");
            }
            else if (playerChoice == "lizard" && CPUChoice == "scissors")
            {
                CPUScore += 1;

                rounds -= 1;

                MessageBox.Show("CPU Wins: Scissors decapitates Lizard");
            }
            else if (playerChoice == "scissors" && CPUChoice == "lizard")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins: Scissors decapitates Lizard");
            }

            else if (playerChoice == "none")
            {
                MessageBox.Show("Make a choice");
            }
            else
            {
                MessageBox.Show("Draw!!!");
            }

            startNextRound();
        }

        private void startNextRound()
        {
            if (gameOver == true)
            {
                return;
            }
            txtScore.Text = "Player: " + playerScore + " - " + "CPU: " + CPUScore;

            playerChoice = "none";

            countDownTimer.Enabled = true;

            picPlayer.Image = Properties.Resources.qq;
            picCPU.Image = Properties.Resources.qq;

        }
    }
}

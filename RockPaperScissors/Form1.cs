using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {


        //variables
        int timerPerRound = 6;
        bool gameOver = false;
        int tur = 3;

        string[] CPUchoiceList = {"tas","kagit","makas", "tas","kagit","makas"};

        int randomNumber = 0;

        Random rnd = new Random();

        string CPUChoice;
        string playerChoice;

        int playerScore;
        int CPUScore;

     

        public Form1()
        {
            InitializeComponent();

            playerChoice = "none";

            txtCountDown.Text = "5";

        }
 

        private void btnRock_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.tas;
            playerChoice = "tas";
            countDownTimer.Start();
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.kagit;
            playerChoice = "kagit";
            countDownTimer.Start();
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.makas;
            playerChoice = "makas";
            countDownTimer.Start();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            // a button for when rounds are done, restarts the game.
            playerScore = 0;
            CPUScore = 0;
            tur = 3;


            txtScore.Text = "Player: " + playerScore + " - " + "CPU: " + CPUScore;

            playerChoice = "none";

            countDownTimer.Start();

            picPlayer.Image = Properties.Resources.qm;
            picCPUs.Image = Properties.Resources.qm;

            gameOver = false;


        }

        private void countDownTimer_Tick(object sender, EventArgs e)
        {
            timerPerRound -= 1;

            txtCountDown.Text = timerPerRound.ToString();
            
            txtRounds.Text = "Rounds: " + tur;

            if (timerPerRound < 1)
            {
                countDownTimer.Enabled = false;

                timerPerRound = 6;

                randomNumber = rnd.Next(0, CPUchoiceList.Length);

                CPUChoice = CPUchoiceList[randomNumber];

                switch (CPUChoice)
                {

                    case "tas":
                        picCPUs.Image = Properties.Resources.tas;
                        break;
                    case "kagit":
                        picCPUs.Image = Properties.Resources.kagit;
                        break;
                    case "makas":
                        picCPUs.Image = Properties.Resources.makas;
                        break;

                }


                if (tur > 0)
                {
                    checkGame();
                }
                else
                {
                    if (playerScore > CPUScore)
                    {
                        MessageBox.Show("Tebrikler, kazandınız.","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("CPU oyunu kazandı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    gameOver = true;
                }

            }

        }


        private void checkGame()
        {
            //CPU win conditions
            if (playerChoice == "tas" && CPUChoice == "kagit")
            {
                CPUScore += 1;
                tur -= 1;

                MessageBox.Show("CPU kazandı, kağıt taşı sarar.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (playerChoice == "makas" && CPUChoice == "tas")
            {
                CPUScore += 1;
                tur -= 1;

                MessageBox.Show("CPU kazandı, taş makası kırar.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (playerChoice == "kagit" && CPUChoice == "makas")
            {
                CPUScore += 1;
                tur -= 1;

                MessageBox.Show("CPU kazandı, makas kağıdı keser.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Player win conditions

            else if (playerChoice == "rock" && CPUChoice == "scissor")
            {
                playerScore += 1;
                tur -= 1;

                MessageBox.Show("Oyuncu kazandı, taş makası kırar.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (playerChoice == "kagit" && CPUChoice == "tas")
            {
                playerScore += 1;
                tur -= 1;

                MessageBox.Show("Oyuncu kazandı, kağıt taşı sarar.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (playerChoice == "makas" && CPUChoice == "kagit")
            {
                playerScore += 1;
                tur -= 1;

                MessageBox.Show("Oyuncu kazandı, makas kağıdı keser.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(playerChoice == "none")
            {
                MessageBox.Show("Bir seçim yapınız..","UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Berabere!","Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
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

            picPlayer.Image = Properties.Resources.qm;
            picCPUs.Image = Properties.Resources.qm;

            }

        private void lnkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/boraSOLENAY");
        }
    }
}

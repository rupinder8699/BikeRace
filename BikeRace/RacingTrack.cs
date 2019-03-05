using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeRace
{
    public partial class RacingTrack : Form
    {
        // global object of random class 
        Random rd = new Random();
        Winning win = new Winning();

        // global variable to do diifernt type of task
        int setPLyr = 0,WinningBike=0;
         
        int playr1 = 0, playr2 = 0, playr3 = 0;

        int Player1Bet = 0, Player2Bet = 0, Player3Bet = 0;

        int Player1Bike = 0, Player2Bike = 0, Player3Bike = 0;

        String player1 = "", player2 = "", player3 = "";

        private void txtSetPlayer_TextChanged(object sender, EventArgs e)
        {

        }

        int budget1 = 0, budget2 = 0, budget3 = 0;

        // uer define method to display the winner and update the budget

        public void lblReset() {

            //calling the findwinner method from the winning class with passing arguments 
            int newBudgt = win.findWinner(playr1,budget1,Player1Bet,WinningBike,Player1Bike);
            budget1=newBudgt;
            PlayerLbl1.Text = player1 + " has " + budget1 +" Dollar";

            newBudgt = win.findWinner(playr2, budget2, Player2Bet, WinningBike, Player2Bike);
            budget2 = newBudgt;
            PlayerLbl2.Text = player2 + " has " + budget2 + " Dollar";

            newBudgt = win.findWinner(playr3, budget3, Player3Bet, WinningBike, Player3Bike);
            budget3 = newBudgt;
            PlayerLbl3.Text = player3 + " has " + budget3 + " $Dollar";

            //reset the position of the imges
            RaceBike1.Left = 0;
            RaceBike2.Left = 0;
            RaceBike3.Left = 0;
            BikeCB.Text = "";
            PlayerCB.Text = "";
            nmBet.Value = 0;

            Race.Visible = false;
        }

        //timer to race the bike 
        private void BikeTmr_Tick(object sender, EventArgs e)
        {
            if (RaceBike1.Left < 870)
            {
                int y = rd.Next(1, 34);
                RaceBike1.Left += y;
            }
            else {
                WinningBike = 1;
                BikeTmr.Enabled = false;
                MessageBox.Show("Congrs" + WinningBike + " is winner");
                lblReset();
            }

            if (RaceBike2.Left < 870)
            {
                int y = rd.Next(1, 32);
                RaceBike2.Left += y;
            }
            else {
                WinningBike = 2;
                BikeTmr.Enabled = false;
                MessageBox.Show("Congrs" + WinningBike + " is winner");
                lblReset();
            }

            if (RaceBike3.Left < 870)
            {
                int y = rd.Next(1, 32);
                RaceBike3.Left += y;
            }
            else {
                WinningBike = 3;
                BikeTmr.Enabled = false;
                MessageBox.Show("Congrs" + WinningBike + " is winner");
                lblReset();
            }
            //display the winning the message
            
        }

        //start the race 
        private void Race_Click(object sender, EventArgs e)
        {
            BikeTmr.Enabled =true;
        }


        //set the bet with the  amount 
        private void Bet_Click(object sender, EventArgs e)
        {
            //check the player and budget amount and bet amount and pass the value to global variable
            if (PlayerCB.SelectedIndex == 0 && nmBet.Value > 10 && budget1>=nmBet.Value)
            {
                PlayerLbl1.Text = player1 + " set Bet on " + BikeCB.SelectedItem + " Amount " + nmBet.Value + " Dollar";

                playr1 = 1;

                Player1Bet = Convert.ToInt32(nmBet.Value);

                Player1Bike = Convert.ToInt32(BikeCB.SelectedItem);

                Race.Visible = true;
            }

            else if (PlayerCB.SelectedIndex == 1 && nmBet.Value > 10 && budget2 >= nmBet.Value)
            {
                PlayerLbl2.Text = player2 + " set Bet on " + BikeCB.SelectedItem + " Amount " + nmBet.Value + " Dollar";

                playr2 = 1;

                Player2Bet = Convert.ToInt32(nmBet.Value);

                Player2Bike = Convert.ToInt32(BikeCB.SelectedItem);
                Race.Visible = true;
            }

            else if (PlayerCB.SelectedIndex == 2 && nmBet.Value > 10 && budget3 >= nmBet.Value)
            {
                PlayerLbl3.Text = player3 + " set Bet on " + BikeCB.SelectedItem + " Amount " + nmBet.Value + " Dollar";

                playr3 = 1;

                Player3Bet = Convert.ToInt32(nmBet.Value);

                Player3Bike = Convert.ToInt32(BikeCB.SelectedItem);
                Race.Visible = true;
            } 
            else {
                MessageBox.Show("Set Bet Amount more then 10 Dollar");
            }
        }
 
        public RacingTrack()
        {
            InitializeComponent();
            MessageBox.Show("Add 3 Player ");
        }
 
        // add the player in the race game and budget amount also
        private void btnSetPlayer_Click(object sender, EventArgs e)
        {
            //count the no of player
            if (!txtSetPlayer.Text.Equals("") && nmSetBudget.Value > 10 && !txtSetPlayer.Text.ToString().Substring(0,1).Equals(" "))
            {
                setPLyr++;
                if (setPLyr == 1 && !txtSetPlayer.Text.ToString().Equals("") && nmSetBudget.Value > 0)
                {
                    player1 = txtSetPlayer.Text.ToString();
                    budget1 = Convert.ToInt32(nmSetBudget.Value);
                    PlayerLbl1.Text = player1 + " has " + budget1 + " Dollar";
                    PlayerCB.Items.Add(player1);
                    MessageBox.Show("Player is Added");

                }
                else if (setPLyr == 2 && !txtSetPlayer.Text.ToString().Equals("") && nmSetBudget.Value > 0 && !txtSetPlayer.Text.ToString().Substring(0, 1).Equals(" "))
                {
                    player2 = txtSetPlayer.Text.ToString();
                    budget2 = Convert.ToInt32(nmSetBudget.Value);
                    PlayerLbl2.Text = player2 + " has " + budget2 + " Dollar";
                    PlayerCB.Items.Add(player2);
                    MessageBox.Show("Player is Added");
                }
                else if (setPLyr == 3 && !txtSetPlayer.Text.ToString().Equals("") && nmSetBudget.Value > 0 && !txtSetPlayer.Text.ToString().Substring(0, 1).Equals(" "))
                {
                    player3 = txtSetPlayer.Text.ToString();
                    budget3 = Convert.ToInt32(nmSetBudget.Value);
                    PlayerLbl3.Text = player3 + " has " + budget3 + " Dollar";
                    PlayerCB.Items.Add(player3);
                    MessageBox.Show("Player is Added");
                }
                else
                {
                    MessageBox.Show("Fill the Proper Record and amount more then 10 dollar ");
                }
                if (setPLyr == 3)
                {
                    allPlyr.Visible = true;
                    betArea.Visible = true;
                    RaceTrack.Visible = true;
                    gpSetPlayer.Visible = false;
                }
                txtSetPlayer.Text = "";
                nmSetBudget.Value = 0;
            }
            else {
                MessageBox.Show("Fill all the Record");
            }            
        }
    }
}

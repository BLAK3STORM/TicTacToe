using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using System.Windows.Input;

namespace TicTacToe
{
    public partial class Form1 : Form
    {

        // Globals
        bool turn = true; // True = X mark, False = O mark
        int turn_count = 0;
        static String player1 = "X"; // Default name
        static String player2 = "O"; // Default name
        bool against_bot = true; // By Default, PvE mode

        public Form1()
        {
            InitializeComponent();

            // For BOT mode
            if (against_bot)
            {
                player1 = "You";
                player2 = "BOT";

                player1Label.Text = "Your Win Count";
                player2Label.Text = "BOT Win Count";
            }

        }

        // For taking custom player name input 
        public static void nameChange(String n1, String n2)
        {
            player1 = n1;
            player2 = n2;
        }

        private void menuStripExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exits the app upon file menu 'exit' click
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender; // Casting the 'sender' object as a button object

            // Player 1
            if(turn)
            {
                b.Text = "X";
                b.ForeColor = Color.OrangeRed;
            }
            // Player 2
            else
            {
                b.Text = "O";
                b.ForeColor = Color.Yellow;
            }

            turn = !turn; // Switching the value of 'turn' for switching the player
            b.Enabled = false; // Disables the clicked button
            turn_count++;

            checkWinner();

            // For BOT mode & BOT is always "O" mark
            if ((!turn) && (against_bot))
            {
                bot_makes_move();
            }

        }

        private void checkWinner()
        {
            bool winner = false;

            // Horizontal checks
            if((btn11.Text == btn12.Text) && (btn12.Text == btn13.Text) && (!btn11.Enabled))
            {
                winner = true;

                // Marking the matched sets
                btn11.BackColor = Color.Red;
                btn12.BackColor = Color.Red;
                btn13.BackColor = Color.Red;
            }
            else if ((btn21.Text == btn22.Text) && (btn22.Text == btn23.Text) && (!btn21.Enabled))
            {
                winner = true;

                // Marking the matched sets
                btn21.BackColor = Color.Red;
                btn22.BackColor = Color.Red;
                btn23.BackColor = Color.Red;
            }
            else if ((btn31.Text == btn32.Text) && (btn32.Text == btn33.Text) && (!btn31.Enabled))
            {
                winner = true;

                // Marking the matched sets
                btn31.BackColor = Color.Red;
                btn32.BackColor = Color.Red;
                btn33.BackColor = Color.Red;
            }

            // Vertical checks
            else if ((btn11.Text == btn21.Text) && (btn21.Text == btn31.Text) && (!btn11.Enabled))
            {
                winner = true;

                // Marking the matched sets
                btn11.BackColor = Color.Red;
                btn21.BackColor = Color.Red;
                btn31.BackColor = Color.Red;
            }
            else if ((btn12.Text == btn22.Text) && (btn22.Text == btn32.Text) && (!btn12.Enabled))
            {   
                winner = true;

                // Marking the matched sets
                btn12.BackColor = Color.Red;
                btn22.BackColor = Color.Red;
                btn32.BackColor = Color.Red;
            }
            else if ((btn13.Text == btn23.Text) && (btn23.Text == btn33.Text) && (!btn13.Enabled))
            {
                winner = true;

                // Marking the matched sets
                btn13.BackColor = Color.Red;
                btn23.BackColor = Color.Red;
                btn33.BackColor = Color.Red;
            }

            // Diagonal checks
            else if ((btn11.Text == btn22.Text) && (btn22.Text == btn33.Text) && (!btn11.Enabled))
            {
                winner = true;

                // Marking the matched sets
                btn11.BackColor = Color.Red;
                btn22.BackColor = Color.Red;
                btn33.BackColor = Color.Red;
            }
            else if ((btn13.Text == btn22.Text) && (btn22.Text == btn31.Text) && (!btn31.Enabled))
            {
                winner = true;

                // Marking the matched sets
                btn13.BackColor = Color.Red;
                btn22.BackColor = Color.Red;
                btn31.BackColor = Color.Red;
            }

            // Finds the winner
            if (winner)
            {
                disableButtons();
                String champion;
                
                // If it is the turn of X after winner = true, means O is the winner
                if(turn)
                {
                    champion = player2;
                    oWin.Text = (Int32.Parse(oWin.Text) + 1).ToString(); // Increases win count
                }
                else
                {
                    champion = player1;
                    xWin.Text = (Int32.Parse(xWin.Text) + 1).ToString(); // Increases win count
                }

                // Only happens if playing against bot
                if(turn && against_bot)
                {
                    champion = player2;
                    loseAudio(); // Plays a losing sound
                    MessageBox.Show(champion + " WON!", "Result");
                }

                else
                {
                    winAudio(); // Plays a winning sound
                    MessageBox.Show(champion + " WON!", "Result");
                }
            }
            // If winner = false & all the buttons are disabled, means a draw
            else
            {
                if(turn_count == 9)
                {
                    drwCount.Text = (Int32.Parse(drwCount.Text) + 1).ToString(); // Increases draw count
                    drawAudio(); // Plays a sound when it is draw
                    MessageBox.Show("DRAW!", "Bummer");
                }
            }
        }

        // Disables all the buttons after the game is over
        private void disableButtons()
        {
            try
            {
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn13.Enabled = false;
                btn21.Enabled = false;
                btn22.Enabled = false;
                btn23.Enabled = false;
                btn31.Enabled = false;
                btn32.Enabled = false;
                btn33.Enabled = false;
            }
            catch (Exception)
            {
             
            }
        }

        // Resets buttons for a new game
        private void newGame_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.ForeColor = Color.DeepSkyBlue;
                    b.BackColor = Color.RoyalBlue;
                }
                catch (Exception)
                {
                    
                }
            }

            

        }

        // Shows whose turn when mouse is entered the buttons
        private void btn_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Enabled)
            {
                if (turn)
                {
                    b.Text = "X";
                    b.ForeColor = Color.OrangeRed;
                }
                else
                {
                    b.Text = "O";
                    b.ForeColor = Color.Yellow;
                }
            }
        }

        // Changes the buttons to the initial state after mouse is left
        private void btn_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Enabled)
            {
                b.Text = "";
                b.ForeColor = Color.DeepSkyBlue;
            }
        }

        // Resets counters
        private void resetCounters_Click(object sender, EventArgs e)
        {
            xWin.Text = "0";
            drwCount.Text = "0";
            oWin.Text = "0";
        }

        private void pveMode_click(object sender, EventArgs e)
        {
            against_bot = true;

            if(against_bot)
            {
                player1 = "You";
                player2 = "BOT";

                player1Label.Text = "Your Win Count";
                player2Label.Text = "BOT Win Count";
            }

            // Resetting
            turn = true;
            turn_count = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.ForeColor = Color.DeepSkyBlue;
                    b.BackColor = Color.RoyalBlue;
                }
                catch (Exception)
                {

                }
            }

            xWin.Text = "0";
            oWin.Text = "0";
            drwCount.Text = "0";
        }

        private void pvpMode_Click(object sender, EventArgs e)
        {
            against_bot = false;
            Form f2 = new f2(); // Instantiating a new form
            f2.ShowDialog(); // By default, will come up first

            // Namings
            if (player1 == "" && player2 == "")
            {
                player1Label.Text = "X Win Count";
                player2Label.Text = "O Win Count";
            }
            else if (player1 == "")
            {
                player1Label.Text = "X Win Count";
                player2Label.Text = player2;
            }
            else if (player2 == "")
            {
                player2Label.Text = "O Win Count";
                player1Label.Text = player1;
            }
            else
            {
                player1Label.Text = player1;
                player2Label.Text = player2;
            }

            // Resetting
            drwCount.Text = "0";
            xWin.Text = "0";
            oWin.Text = "0";

            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn23.Text = "";
            btn31.Text = "";
            btn32.Text = "";
            btn33.Text = "";

            btn11.ForeColor = Color.DeepSkyBlue;
            btn12.ForeColor = Color.DeepSkyBlue;
            btn13.ForeColor = Color.DeepSkyBlue;
            btn21.ForeColor = Color.DeepSkyBlue;
            btn22.ForeColor = Color.DeepSkyBlue;
            btn23.ForeColor = Color.DeepSkyBlue;
            btn31.ForeColor = Color.DeepSkyBlue;
            btn32.ForeColor = Color.DeepSkyBlue;
            btn33.ForeColor = Color.DeepSkyBlue;

            // Starting a new game
            turn = true;
            turn_count = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.ForeColor = Color.DeepSkyBlue;
                    b.BackColor = Color.RoyalBlue;
                }
                catch (Exception)
                {

                }
            }
        }

        // Activates BOT
        private void bot_makes_move()
        {
            /*
             * Algorithm:
             *           1. Will try to win
             *           2. Will try to block the win of the player
             *           3. Will go for the corners first
             *           4. If corners are filled, will go for any empty space
             */

            Button move = null;

            move = look_for_win_or_block("O"); // Looks for win
            if(move == null)
            {
                move = look_for_win_or_block("X"); // Looks for block the win
                if(move == null)
                {
                    move = look_for_corner(); // Targets the corners first
                    if(move == null)
                    {
                        move = look_for_open_space(); // Looks for free spaces if no move is available
                    }
                }
            }

            try
            {
                if (move != null)
                {
                    move.PerformClick();
                }
                else
                {
                    return;
                }
                //move.PerformClick();
            }
            catch (Exception)
            {

            }
        }

        // BOT Algorithm #1 & #2
        private Button look_for_win_or_block(string x)
        {
            // Horizontal Checks
            if((btn11.Text == x) && (btn12.Text == x) && (btn13.Text == ""))
            {
                return btn13;
            }
            if ((btn13.Text == x) && (btn12.Text == x) && (btn11.Text == ""))
            {
                return btn11;
            }
            if ((btn11.Text == x) && (btn13.Text == x) && (btn12.Text == ""))
            {
                return btn12;
            }

            if ((btn21.Text == x) && (btn22.Text == x) && (btn23.Text == ""))
            {
                return btn23;
            }
            if ((btn23.Text == x) && (btn22.Text == x) && (btn21.Text == ""))
            {
                return btn21;
            }
            if ((btn21.Text == x) && (btn23.Text == x) && (btn22.Text == ""))
            {
                return btn22;
            }

            if ((btn31.Text == x) && (btn32.Text == x) && (btn33.Text == ""))
            {
                return btn33;
            }
            if ((btn33.Text == x) && (btn32.Text == x) && (btn31.Text == ""))
            {
                return btn31;
            }
            if ((btn31.Text == x) && (btn33.Text == x) && (btn32.Text == ""))
            {
                return btn32;
            }

            // Vertical Checks
            if ((btn11.Text == x) && (btn21.Text == x) && (btn31.Text == ""))
            {
                return btn31;
            }
            if ((btn11.Text == x) && (btn31.Text == x) && (btn21.Text == ""))
            {
                return btn21;
            }
            if ((btn31.Text == x) && (btn21.Text == x) && (btn11.Text == ""))
            {
                return btn11;
            }

            if ((btn12.Text == x) && (btn22.Text == x) && (btn32.Text == ""))
            {
                return btn32;
            }
            if ((btn12.Text == x) && (btn32.Text == x) && (btn22.Text == ""))
            {
                return btn22;
            }
            if ((btn32.Text == x) && (btn22.Text == x) && (btn12.Text == ""))
            {
                return btn12;
            }

            if ((btn13.Text == x) && (btn23.Text == x) && (btn33.Text == ""))
            {
                return btn33;
            }
            if ((btn33.Text == x) && (btn23.Text == x) && (btn13.Text == ""))
            {
                return btn13;
            }
            if ((btn33.Text == x) && (btn13.Text == x) && (btn23.Text == ""))
            {
                return btn23;
            }

            // Diagonal checks
            if ((btn11.Text == x) && (btn22.Text == x) && (btn33.Text == ""))
            {
                return btn33;
            }
            if ((btn11.Text == x) && (btn33.Text == x) && (btn22.Text == ""))
            {
                return btn22;
            }
            if ((btn33.Text == x) && (btn22.Text == x) && (btn11.Text == ""))
            {
                return btn11;
            }

            if ((btn13.Text == x) && (btn22.Text == x) && (btn31.Text == ""))
            {
                return btn31;
            }
            if ((btn31.Text == x) && (btn22.Text == x) && (btn13.Text == ""))
            {
                return btn13;
            }
            if ((btn13.Text == x) && (btn31.Text == x) && (btn22.Text == ""))
            {
                return btn22;
            }

            return null;
        }

        // BOT Algorithm #3
        private Button look_for_corner()
        {
            if(btn11.Text == "O")
            {
                if (btn13.Text == "")
                    return btn13;
                if (btn33.Text == "")
                    return btn33;
                if (btn31.Text == "")
                    return btn31;
            }
            if (btn13.Text == "O")
            {
                if (btn11.Text == "")
                    return btn11;
                if (btn33.Text == "")
                    return btn33;
                if (btn31.Text == "")
                    return btn31;
            }
            if (btn31.Text == "O")
            {
                if (btn13.Text == "")
                    return btn13;
                if (btn33.Text == "")
                    return btn33;
                if (btn11.Text == "")
                    return btn11;
            }
            if (btn33.Text == "O")
            {
                if (btn13.Text == "")
                    return btn13;
                if (btn11.Text == "")
                    return btn11;
                if (btn31.Text == "")
                    return btn31;
            }

            if (btn11.Text == "")
                return btn11;
            if (btn13.Text == "")
                return btn13;
            if (btn33.Text == "")
                return btn33;
            if (btn31.Text == "")
                return btn31;

            return null;
        }

        // BOT Algorithm #4
        private Button look_for_open_space()
        {
            Button b = null;

            foreach(Control c in Controls)
            {
                b = c as Button;
                if(b != null)
                {
                    if(b.Text == "")
                    {
                        return b;
                    }
                }
            }
            
            return null;
        }

        // Using the About button to open a link
        private void about_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/BLAK3STORM");
        }

        // Sound Function
        private void winAudio()
        {
            SoundPlayer win = new SoundPlayer(TicTacToe.Properties.Resources.win);
            win.Play();
        }

        // Sound Function
        private void drawAudio()
        {
            SoundPlayer draw = new SoundPlayer(TicTacToe.Properties.Resources.draw);
            draw.Play();
        }

        // Sound Function
        private void loseAudio()
        {
            SoundPlayer lose = new SoundPlayer(TicTacToe.Properties.Resources.lose);
            lose.Play();
        }

        // Opens the manual
        private void manual_click(object sender, EventArgs e)
        {
            Form man = new Manual();
            man.ShowDialog();
        }
    }
}

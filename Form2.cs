using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class f2 : Form
    {
        public f2()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Form1.nameChange(player1.Text, player2.Text); // Gets the names from the text boxes
            this.Close();
        }

        // If is 'Enter' key is pressed in the player2 textbox, it will perform the playButton
        // click event
        private void keyPressInput_player2Txtbox(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == "\r")
            {
                playButton.PerformClick();
                e.Handled = true;
            }
        }
    }
}

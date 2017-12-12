using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        int player;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            player = 1;
            label2.Text = "1";
            playerLbl.Text = "";
            playerNumLbl.Text = "";
            wonLbl.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (player == 1) {
                button1.Text = "X";
                player = 2;
                label2.Text = "2";
            }
            else if(player == 2)
            {
                button1.Text = "O";
                player = 1;
                label2.Text = "1";
            }
            count++;
            winnerChecker();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                button2.Text = "X";
                player = 2;
                label2.Text = "2";
            }
            else if (player == 2)
            {
                button2.Text = "O";
                player = 1;
                label2.Text = "1";
            }
            count++;
            winnerChecker();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                button3.Text = "X";
                player = 2;
                label2.Text = "2";
            }
            else if (player == 2)
            {
                button3.Text = "O";
                player = 1;
                label2.Text = "1";
            }
            count++;
            winnerChecker();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                button4.Text = "X";
                player = 2;
                label2.Text = "2";
            }
            else if (player == 2)
            {
                button4.Text = "O";
                player = 1;
                label2.Text = "1";
            }
            count++;
            winnerChecker();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                button5.Text = "X";
                player = 2;
                label2.Text = "2";
            }
            else if (player == 2)
            {
                button5.Text = "O";
                player = 1;
                label2.Text = "1";
            }
            count++;
            winnerChecker();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                button6.Text = "X";
                player = 2;
                label2.Text = "2";
            }
            else if (player == 2)
            {
                button6.Text = "O";
                player = 1;
                label2.Text = "1";
            }
            count++;
            winnerChecker();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                button7.Text = "X";
                player = 2;
                label2.Text = "2";
            }
            else if (player == 2)
            {
                button7.Text = "O";
                player = 1;
                label2.Text = "1";
            }
            count++;
            winnerChecker();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                button8.Text = "X";
                player = 2;
                label2.Text = "2";
            }
            else if (player == 2)
            {
                button8.Text = "O";
                player = 1;
                label2.Text = "1";
            }
            count++;
            winnerChecker();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                button9.Text = "X";
                player = 2;
                label2.Text = "2";
            }
            else if (player == 2)
            {
                button9.Text = "O";
                player = 1;
                label2.Text = "1";
            }
            count++;
            winnerChecker();
        }
        public void winnerChecker()
        {
            //X checker
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X") { playerLbl.Text = "Player"; playerNumLbl.Text = "1"; wonLbl.Text = "Won"; }
            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") { playerLbl.Text = "Player"; playerNumLbl.Text = "1"; wonLbl.Text = "Won"; }
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") { playerLbl.Text = "Player"; playerNumLbl.Text = "1"; wonLbl.Text = "Won"; }
            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") { playerLbl.Text = "Player"; playerNumLbl.Text = "1"; wonLbl.Text = "Won"; }
            else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X") { playerLbl.Text = "Player"; playerNumLbl.Text = "1"; wonLbl.Text = "Won"; }
            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") { playerLbl.Text = "Player"; playerNumLbl.Text = "1"; wonLbl.Text = "Won"; }
            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") { playerLbl.Text = "Player"; playerNumLbl.Text = "1"; wonLbl.Text = "Won"; }
            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X") { playerLbl.Text = "Player"; playerNumLbl.Text = "1"; wonLbl.Text = "Won"; }

            //O checker
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O") { playerLbl.Text = "Player"; playerNumLbl.Text = "2"; wonLbl.Text = "Won"; }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") { playerLbl.Text = "Player"; playerNumLbl.Text = "2"; wonLbl.Text = "Won"; }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") { playerLbl.Text = "Player"; playerNumLbl.Text = "2"; wonLbl.Text = "Won"; }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") { playerLbl.Text = "Player"; playerNumLbl.Text = "2"; wonLbl.Text = "Won"; }
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O") { playerLbl.Text = "Player"; playerNumLbl.Text = "2"; wonLbl.Text = "Won"; }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") { playerLbl.Text = "Player"; playerNumLbl.Text = "2"; wonLbl.Text = "Won"; }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") { playerLbl.Text = "Player"; playerNumLbl.Text = "2"; wonLbl.Text = "Won"; }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O") { playerLbl.Text = "Player"; playerNumLbl.Text = "2"; wonLbl.Text = "Won"; }
            else if (count >= 9) { draw(); }
        }
        public void draw()
        {
                playerLbl.Text = "Match";
                wonLbl.Text = "Draw";
        }
    }
}

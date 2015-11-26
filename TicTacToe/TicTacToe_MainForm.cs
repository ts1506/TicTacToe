using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe {
    public partial class TicTacToe_MainForm : Form {
        // True = 1st person False = 2nd person
        bool check_turn = true;
        int count_turn = 0;

        public TicTacToe_MainForm() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void toggle_pos(object sender, EventArgs e) {
            Button a = (Button)sender;
            if (check_turn == true)
                a.Text = "X";
            else
                a.Text = "O";

            // Switch bool, disable button and count turns
            check_turn = !check_turn;
            a.Enabled = false;
            count_turn++;

            // Check if out of turns
            if (count_turn == 9)
                MessageBox.Show("Its a draw");
            else
                // Check if we have a winner
                win_check();

        }

        private void win_check()  {
            bool winner = false;

            if ((R1C1.Text == R1C2.Text) && (R1C2.Text == R1C3.Text) && !R1C1.Enabled)
                winner = true;
            if ((R2C1.Text == R2C2.Text) && (R2C2.Text == R2C3.Text) && !R2C1.Enabled)
                winner = true;
            if ((R3C1.Text == R3C2.Text) && (R3C2.Text == R3C3.Text) && !R3C1.Enabled)
                winner = true;
            if ((R1C1.Text == R2C1.Text) && (R2C1.Text == R3C1.Text) && !R1C1.Enabled)
                winner = true;
            if ((R1C2.Text == R2C2.Text) && (R2C2.Text == R3C2.Text) && !R1C2.Enabled)
                winner = true;
            if ((R1C3.Text == R2C3.Text) && (R2C3.Text == R3C3.Text) && !R1C3.Enabled)
                winner = true;
            if ((R1C1.Text == R2C2.Text) && (R2C2.Text == R3C3.Text) && !R1C1.Enabled)
                winner = true;
            if ((R1C3.Text == R2C2.Text) && (R2C2.Text == R1C3.Text) && !R1C3.Enabled)
                winner = true;

            if(winner)
            {
                if (check_turn)
                    MessageBox.Show("2nd Player won!!");
                else
                    MessageBox.Show("1st Player won!!");
            }
        }
    }
}

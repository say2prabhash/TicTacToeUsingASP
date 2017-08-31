using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicTacToe
{
    public partial class TicTacToe : System.Web.UI.Page
    {
        static int player = 1;
        Button button;
        static bool win = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            button = (Button)sender;
            if (player == 1 && button.Text.Equals("-"))
            {
                button.Text = "X";
                WinningCondition(button.Text);
                player = 2;
            }
            else if (button.Text.Equals("-"))
            {
                button.Text = "O";
                WinningCondition(button.Text);
                player = 1;
            }
            
        }

      
        protected void WinningCondition(string mark)
        {
            if ((Button1.Text.Equals(mark) && Button2.Text.Equals(mark) && Button3.Text.Equals(mark)) ||
                    (Button4.Text.Equals(mark) && Button5.Text.Equals(mark) && Button6.Text.Equals(mark)) ||
                    (Button7.Text.Equals(mark) && Button8.Text.Equals(mark) && Button9.Text.Equals(mark)) ||
                    (Button1.Text.Equals(mark) && Button4.Text.Equals(mark) && Button7.Text.Equals(mark)) ||
                    (Button2.Text.Equals(mark) && Button5.Text.Equals(mark) && Button8.Text.Equals(mark)) ||
                    (Button3.Text.Equals(mark) && Button6.Text.Equals(mark) && Button9.Text.Equals(mark)) ||
                    (Button1.Text.Equals(mark) && Button5.Text.Equals(mark) && Button9.Text.Equals(mark))||
                    (Button3.Text.Equals(mark) && Button5.Text.Equals(mark) && Button7.Text.Equals(mark)))
            {
                if(player==1)
                {
                    lbl_winning.Text += "Player1 won";
                    win = true;
                }
                else
                {
                    lbl_winning.Text += "Player2 won";
                    win = true;
                }
            }
        }
        //protected void Reintialize()
        //{
        //    Button1.Text = "-";
        //    Button2.Text = "-";
        //    Button3.Text = "-";
        //    Button4.Text = "-";
        //    Button5.Text = "-";
        //    Button6.Text = "-";
        //    Button7.Text = "-";
        //    Button8.Text = "-";
        //    Button9.Text = "-";
        //    lbl_winning.Text = "Winning Player";
        //}
    }
}
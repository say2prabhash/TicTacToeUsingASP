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
        Button button;
        string playerNum = "1";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            
            button = (Button)sender;
            if(ViewState["playerState"]!=null)
            {
                playerNum = ViewState["playerState"].ToString();
            }
            if (playerNum.Equals("1") && button.Text.Equals("-"))
            {
                button.Text = "X";
                WinningCondition(button.Text);
                player.Text = "Player2";
                ViewState["playerState"] = "2";
            }
            else if (button.Text.Equals("-"))
            {
                button.Text = "O";
                WinningCondition(button.Text);
                player.Text = "Player1";
                ViewState["playerState"] = "1";
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
                if (playerNum.Equals("1"))
                {
                    lbl_winning.Text += "Player1 won";

                }
                else
                {
                    lbl_winning.Text += "Player2 won";
                }
            }
            }

        protected void btn_reset_Click(object sender, EventArgs e)
        {
            Button1.Text = "-";
            Button2.Text = "-";
            Button3.Text = "-";
            Button4.Text = "-";
            Button5.Text = "-";
            Button6.Text = "-";
            Button7.Text = "-";
            Button8.Text = "-";
            Button9.Text = "-";
            ViewState["playerState"] = "1";
            player.Text = "Player 1";
            lbl_winning.Text = "Winning Player:";
        }
    }
       
    }

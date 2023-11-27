using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A7
{
    public partial class blackJack : System.Web.UI.UserControl
    {
        //Keeps track of the state of the game
        static string state = "Continue";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //creates an object of BlackJack
            BlackJack.Service1Client game = new BlackJack.Service1Client();

            //performs the service stores the output into a string called value
            string value = game.DealCards();

            string dealer = "";
            string player = "";

            //reset state value to reset game and labels for outcome
            state = "Continue";
            Label14.Text = "";

            //seperate dealer and player cards from string
            int i = 0;

            //skip unnecessary chars
            while (value[i] != ':')
                i++;

            //read dealer cards
            while (value[i] != ',')
            {
                dealer += value[i].ToString();
                i++;

            }

            //skip unnecessary chars
            while (value[i] != ':')
                i++;

            //skip unnecessary chars
            i++;

            //read player cards
            while (i < value.Length)
            {
                player += value[i].ToString();
                i++;

            }

            //Displays cards
            Label10.Text = dealer + ", hidden card";
            Label12.Text = player;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            BlackJack.Service1Client game = new BlackJack.Service1Client();

            //performs the service on the user given string and stores it into a string called value
            state = game.Play("Hit", state);
            string output = game.Cards();
            string dealer = "";
            string player = "";
            string dealerAll = "";
            int i = 0;

            //Parse player and dealer cards
            while (output[i] != ',')
            {
                dealer += output[i].ToString();
                dealerAll += output[i].ToString();
                i++;

            }

            //skip unnecessary chars
            while (output[i] != ';')
            {
                dealerAll += output[i].ToString();
                i++;
            }
            //skip unnecessary char
            i++;

            //read player cards
            while (i < output.Length)
            {
                player += output[i].ToString();
                i++;

            }

            //show dealer cards if player lost or only one if player won
            if (state == "Lost" || state == "Win")
            {
                Label10.Text = dealerAll;
            }
            else
            {
                Label10.Text = dealer + ", hidden card";
            }

            //display cards and state to user
            Label12.Text = player;
            Label14.Text = state;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            BlackJack.Service1Client game = new BlackJack.Service1Client();

            //performs the service on the user given string and stores it into a string called value
            state = game.Play("Stand", state);
            string output = game.Cards();
            string dealer = "";
            string player = "";


            int i = 0;


            //Parse dealer cards
            while (output[i] != ';')
            {
                dealer += output[i].ToString();
                i++;
            }
            //skip unnecessary char
            i++;

            //read player cards
            while (i < output.Length)
            {
                player += output[i].ToString();
                i++;

            }

            //Display cards and state to user
            Label10.Text = dealer;
            Label12.Text = player;
            Label14.Text = state;
        }
    }
}
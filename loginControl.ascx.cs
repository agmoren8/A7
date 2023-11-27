using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.XPath;

namespace A7
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            //bool value keeps track of if the user exists.
            bool exists = false;

            //gets path to the xml file containing accounts
            string directoryPath = HttpContext.Current.Server.MapPath("~/App_Data/Member.xml");

            //Creates needed objects to read xml
            XPathDocument dx = new XPathDocument(directoryPath);
            XPathNavigator nav = dx.CreateNavigator();

            //reads the account details
            XPathNodeIterator iterator = nav.Select("/Accounts/Account");

            //goes through each account and checks if it matches the username and password given by the user
            while (iterator.MoveNext())
            {
                //Gets the username and stores it into a string
                XPathNodeIterator it = iterator.Current.Select("Username");
                it.MoveNext();
                string username = it.Current.Value;

                //Gets the password and stores it into a string
                it = iterator.Current.Select("Password");
                it.MoveNext();
                string Password = it.Current.Value;

                //check if the account exists if it hasnt been found yet
                if (!exists)
                {
                    //if account information is correct, set exist to true and tell the user login was successful
                    if (username == MyUserName.Text && Password == MyPassword.Text)
                    {
                        Label1.Text = "login was successful";
                        exists = true;

                        Response.Redirect("MemberPage.aspx");
                    }
                    else
                    {
                        //tells the user it was an incorrect login if it doesnt exist
                        Label1.Text = "Incorrect login";
                    }
                }
            }
        }
    }
}
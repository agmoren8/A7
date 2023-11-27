using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.XPath;

namespace A7
{
    public partial class addStaff : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //bool value keeps track of whether or not the account already exists
            bool exists = false;

            //Reads Account details
            String directoryPath = HttpContext.Current.Server.MapPath("~/App_Data/Staff.xml");

            //Creates needed objects to read xml
            XPathDocument dx = new XPathDocument(directoryPath);
            XPathNavigator nav = dx.CreateNavigator();

            //Reads Account details
            XPathNodeIterator iterator = nav.Select("/Accounts/Account");

            //Goes through each existing account to check if the users input already exists.
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

                //tells the user if it exists by editing a label
                if (!exists)
                {
                    if (username == TextBox1.Text && Password == TextBox2.Text)
                    {
                        Label4.Text = "account already exists";
                        exists = true;
                    }
                    else
                    {
                        Label4.Text = "account added to xml file";
                    }
                }
            }

            //If the account doesnt exist, this will add the account to the xml file
            if (!exists)
            {
                //will store each line of the xml file
                List<string> read = new List<string>();


                //reads the file with StreamReader
                StreamReader reader = new StreamReader(directoryPath);


                //reads a few lines to get past the first <Accounts> line
                string info = "";
                info = reader.ReadLine();
                read.Add(info);
                info = reader.ReadLine();
                read.Add(info);
                info = reader.ReadLine();
                read.Add(info);
                info = reader.ReadLine();
                read.Add(info);
                info = reader.ReadLine();
                read.Add(info);

                //Reads every line ands stores it until the end of Accounts
                while (info != "</Accounts>")
                {
                    info = reader.ReadLine();
                    if (info != "</Accounts>")
                    {
                        read.Add(info);
                    }

                }
                reader.Close();



                //adds the new user made account to the xml file in the proper format
                read.Add("\t<Account>");
                read.Add("\t\t<Username>" + TextBox1.Text + "</Username>");
                read.Add("\t\t<Password>" + TextBox2.Text + "</Password>");
                read.Add("\t</Account>");
                read.Add("</Accounts>");



                //empty file before adding xml info
                System.IO.File.WriteAllText(directoryPath, string.Empty);
                StreamWriter writer = File.AppendText(directoryPath);

                //re-enter each line from reading the xml file the first time
                foreach (var line in read)
                {
                    writer.WriteLine(line);
                }

                writer.Close();

                //correctly set value of needed objects to read the xml file
                dx = new XPathDocument(directoryPath);
                nav = dx.CreateNavigator();

                //reads the Account information
                iterator = nav.Select("/Accounts/Account");


            }
            else
            {

            }
        }
    }
}
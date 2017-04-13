using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //Create 5,2 array of dates
    string[,] dates = new string[7, 2];
    protected void Page_Load(object sender, EventArgs e)
    {
        //Add items to array
        dates[0, 0] = "4/10/2017";
        dates[0, 1] = "Nat'l Siblings day";
        dates[1, 0] = "4/11/2017";
        dates[1, 1] = "Passover(Start)";
        dates[2, 0] = "4/12/2017";
        dates[2, 1] = "Passover (Cont.)";
        dates[3, 0] = "4/13/2017";
        dates[3, 1] = "Holy Thursday";
        dates[4, 0] = "4/13/2017";
        dates[4, 1] = "Passover (Cont.)";
        dates[5, 0] = "4/14/2017";
        dates[5, 1] = "Good Friday";
        dates[6, 0] = "4/14/2017";
        dates[6, 1] = "Passover (Cont.)";
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Label1.Text = "";
        //Label1.Text = Calendar1.SelectedDate.ToShortDateString();
        string myDate = Calendar1.SelectedDate.ToShortDateString();

        //Loop through array of events       
        for (int i = 0; i < 7; i++)
        {
            //Check if selected date is equal to a date in array
            if (myDate.Equals(dates[i,0]))
            {
                //Display events in Label1
                Label1.Text += dates[i, 1] + "<br/>";
            }
        }
        //Check if no events are displayed in Label1 
        if (Label1.Text.Equals(""))
        {
            //Display Date
            Label1.Text = Calendar1.SelectedDate.ToShortDateString();
        }

    }
}
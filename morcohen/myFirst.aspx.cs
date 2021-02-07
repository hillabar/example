using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myFirst : System.Web.UI.Page
{
    public string Counter;
    public string currDate;

    protected void Page_Load(object sender, EventArgs e)
    {
        DateTime dt = DateTime.Now;
        if (dt.Minute < 10)
        {
            currDate = dt.Day + "/" + dt.Month + "/" + dt.Year + " (" + dt.Hour + ":0" + dt.Minute + ")";
        }
        else
        {
            currDate = dt.Day + "/" + dt.Month + "/" + dt.Year + " (" + dt.Hour + ":" + dt.Minute + ")";
        }
      

        if (Application["mycount"] == null)
        {
            Application["mycount"] = 0;

        }
        if (Session["firstLogin"] == null && Session["Login"] != null)
        {

            Application["mycount"] = (int)Application["mycount"] + 1;
            Application.Lock();
            Session["firstLogin"] = Session["Login"];
        }
        Counter = Application["mycount"].ToString();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class logout : System.Web.UI.Page
{
    public string outlink = "";
    protected void Page_Load(object sender, EventArgs e)
    {
       

        Session["Login"]=null;
        Session["Admin"] = null;
      
            outlink = ("  ");
       

        Session["firstLogin"] = "First";
       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class DeleteAccount : System.Web.UI.Page
{
    public string Username;
    public String Answer;
    string Database = "Database.mdf";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Login"] != null)
        {
            Username = Session["Login"] + "";
        }
        else
        {
            Response.Redirect("myFirst.aspx");
        }
    }

    protected void Delete_Button(object sender, EventArgs e)
    {
            string DeleteQuery = "DELETE FROM Login WHERE Username='" + Username + "'";
            MyAdoHelper.DoQuery(Database, DeleteQuery);
            Session["Login"] = null;
            Response.Redirect("myFirst.aspx");
    }
}
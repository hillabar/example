using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    public string Answer;
    string Database = "Database.mdf";

    protected void Login_Button(object sender, EventArgs e)
    {
        string user = txtUser.Text;
        string pass = txtPass.Text;
        string LoginQuery = "SELECT *FROM Login WHERE ";
        LoginQuery += "Username ='" + user + "' AND Password ='" + pass + "'";

        if ((txtUser.Text != null) && (txtUser.Text != "") && (txtPass.Text != "") && (txtPass.Text != null))
        {
            if (MyAdoHelper.IsExist(Database, LoginQuery))
            {
                string isAdminQuery = "SELECT *FROM Login WHERE ";
                isAdminQuery += "Username ='" + user + "' AND Admin ='t'";
                Session["Login"] = user;
                Session["firstLogin"] = null;
                if (MyAdoHelper.IsExist(Database, isAdminQuery))
                {
                    Session["Admin"] = "true";
                    Response.Redirect("Admin.aspx");
                    Response.End();
                }
                Response.Redirect("myfirst.aspx");
                Response.End();
            }
            else
            {
                Answer = ("שם משתמש או סיסמא לא נכונים");
            }
        }
        else
        {
            Answer = ("מלא בבקשה את השדות");
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
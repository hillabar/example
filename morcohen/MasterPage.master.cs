using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage

{
    public string ProtectedLink = "";
    public string Admin = "";

    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (Session["Login"] == null)
        {
            ProtectedLink += "<a style='color:black' href='simpleregister.aspx'>הרשמה</a> |";
            ProtectedLink += "<a style='color:black' href='myFirst.aspx'>דף הבית</a> |";
            ProtectedLink += "<a style='color:black' href='Login.aspx'>כניסה</a> ";
        }
        else
        {
            if (Session["Admin"] == "true")
            {

                ProtectedLink += "<a style='color:black' href='Second.aspx'>חיפוש מתכונים</a> |";
                ProtectedLink += "<a style='color:black' href='AddAsks.aspx'>צור קשר</a> |";
                ProtectedLink += "<a style='color:black' href='changepass.aspx'>שינוי סיסמא</a> |";
                ProtectedLink += "<a style='color:black' href='DeleteAccount.aspx'>מחיקת משתמש</a> |";
                ProtectedLink += "<a style='color:black' href='Logout.aspx'>התנתקות</a> |";
                ProtectedLink += "<a style='color:black' href='myFirst.aspx'>דף הבית</a> |";
                ProtectedLink += "<a style='color:black' href='links.aspx'>חשיבות מזון בריא</a> |";
                Admin += "<a style='color:black' href='Admin.aspx'>עמוד המנהל</a> ";

                Admin += ("<br /> שלום  " + Session["Login"] + "<br />");
            }
            else
            {
                ProtectedLink += " |<a style='color:black' href='myFirst.aspx'>דף הבית</a> |";
                ProtectedLink += "<a style='color:black' href='Second.aspx'>חיפוש מתכונים</a> |";
                ProtectedLink += "<a style='color:black' href='AddAsks.aspx'>צור קשר</a> |";
                ProtectedLink += "<a style='color:black' href='changepass.aspx'>שינוי סיסמא</a> |";
                ProtectedLink += "<a style='color:black' href='DeleteAccount.aspx'>מחיקת משתמש</a> |";
                ProtectedLink += "<a style='color:black' href='Logout.aspx'>התנתקות</a> |";
                ProtectedLink += "<a style='color:black' href='links.aspx'>חשיבות מזון בריא</a> |";

                ProtectedLink += ("<br /> שלום " + Session["Login"] + "<br />");

            }
        }

        

       
            


    }

   
}

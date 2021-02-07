using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class changepass : System.Web.UI.Page
{
    public string changemsg;

    protected void repass(object sender, EventArgs e)
    {
        string Database = "Database.mdf";
        string existidnum = textchackIDnum.Text;
        string existpass = textpass.Text;
        string newpass = textnewpass.Text;
        string tablename = "Login";
       

            if (existidnum == null || existidnum == "" || existpass == null || existpass == "" || newpass == null || newpass == "")
            {
                changemsg += ("הכנס נתונים בבקשה");
            }
            else
            {
                               
                    string idexist = "SELECT *FROM Login WHERE " + "idNum = '" + existidnum + "'";
                    if (MyAdoHelper.IsExist(Database, idexist))
                    {

                        string therightuser = "SELECT * FROM Login WHERE " + "idNum = '" + existidnum + "' AND [Username] = '" + Session["Login"] + "'";
                        if (MyAdoHelper.IsExist(Database, therightuser))
                        {


                            string passexist = "SELECT *FROM Login WHERE " + "Password = '" + existpass + "'";
                            if (MyAdoHelper.IsExist(Database, passexist))
                            {

                                string newpassinsert = "UPDATE " + tablename + " SET [Password]='" + newpass + "' WHERE idNum='" + existidnum + "' AND [Password]= '" + existpass + "'";
                                MyAdoHelper.DoQuery(Database, newpassinsert);
                                changemsg += ("סיסמא עודכנה");
                            }
                            else
                            {
                                changemsg += ("סיסמא קיימת לא נכונה");
                            }

                        }
                        else { changemsg += ("תעודת הזהות שהכנסת אינה מתאימה לשם המשתמש שלך");
                               changemsg += ("<br />");

                        }
                        }
                    else    
                    {    
                        changemsg += ("תעודת זהות לא קיימת");
                    }
             
                    
               

                    

            }
        }
}
    



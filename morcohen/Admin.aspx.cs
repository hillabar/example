using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin : System.Web.UI.Page
{
    public string Alert;
    public string userList;

    protected void Page_Load(object sender, EventArgs e)
    {
        string selectQuery = "SELECT * FROM Login";
        DataTable dt = MyAdoHelper.ExecuteDataTable("Database.mdf", selectQuery);

        userList = "<table border=\"1\" cellpadding=\"10\">";
        //add header row
        userList += "<tr>";
        for (int i = 0; i < dt.Columns.Count; i++)
            userList += "<td>" + dt.Columns[i].ColumnName + "</td>";
        userList += "</tr>";
        //add rows
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            userList += "<tr>";
            for (int j = 0; j < dt.Columns.Count; j++)
                userList += "<td>" + dt.Rows[i][j].ToString() + "</td>";
            userList += "</tr>";
        }
        userList += "</table>";

    }
    protected void SuperAdmin(object sender, EventArgs e)
    {

        string Database = "Database.mdf";
        string deleteuser = admindelete.Text;
        if ((deleteuser == "") || (deleteuser == null))
        {
            Alert += ("הכנס מספר תעודת זהות למחיקה");
        }
        else
        {
            string IDnumexist = "SELECT * FROM Login WHERE " + "idNum = '" + deleteuser + "'";
            if (MyAdoHelper.IsExist(Database, IDnumexist))
            {
                string sql = "Delete from Login WHERE idNum = '" + deleteuser + "'";
                MyAdoHelper.DoQuery(Database, sql);

                Response.Redirect("Admin.aspx");
            }
            else
            {
                Alert += ("משתמש זה לא קיים");
            }

        }

    }
}
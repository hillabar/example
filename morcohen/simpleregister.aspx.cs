using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;

public partial class simpleregister : System.Web.UI.Page
{
    public bool IsEmail(string s)
    {
        var regex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        return regex.IsMatch(s) && !s.EndsWith(".");
    }

    public string Answer;
    string Database = "Database.mdf";
    string Table = "Login";

    protected void Submit_Button(object sender, EventArgs e)
    {
        //מכניס למשתנים את כל התכנים של הטקסט בוקס והרדיו בטון-זכר נקבה
        string Admin;
        string pName = txtName.Text;
        string fName = txtFamily.Text;
        string user = txtUser.Text;
        string pass = txtPass.Text;
        int Gender = GenderChoose.SelectedIndex;
        string GenderType = null;
        double Num;
        string idNum = txtId.Text;
        string Email = txtEmail.Text;
        string Phone = txtPhone.Text;
        string Age = txtAge.Text;
       
        // הבדיקה if בודקת שאין שדות ריקים או טופס לא חוקיבטופס שהמשתמש הכניס
        if ((pName != null) && (pName != "") && (fName != null) && (fName != "") && (user != null) && (user != "") && (pass != "") && (pass != null) && (Gender != -1) && (idNum != null) && (idNum != "") && (Email != null) && (Email != "") && (Phone != null) && (Phone != "") && (Age != null))
        {
            //בדיקת נכונות השדות והוספת הערת שגיאה לכל שדה שהתגלה בפורמט לא נכון
            if (!Regex.IsMatch(pName, "^[a-zA-Z0]*$")) //אם השם הפרטי לא מכיל רק אותיות באנגלית קטנות או גדולות(בכמות או בסדר כלשהם ) אז זה יכתוב שצריך לכתוב שם פרטי רק באנגלית
            {
                Answer += ("<br />");
                Answer += ("שם פרטי רק באנגלית"); 
            }
            if (!Regex.IsMatch(fName, "^[a-zA-Z0]*$"))
            {
                Answer += ("<br />");
                Answer += ("שם משפחה רק באנגלית");
            }
            if (!Regex.IsMatch(user, "^[a-zA-Z0-9]*$"))
            {
                Answer += ("<br />");
                Answer += ("שם משתמש אותיות באנגלית או ספרות");
            }
            if (!Regex.IsMatch(pass, "^[a-zA-Z0-9]*$"))
            {
                Answer += ("<br />");
                Answer += ("סיסמא אותיות באנגלית או ספרות");
            }
            if (!double.TryParse(idNum, out Num))
            {
                Answer += ("<br />");
                Answer += ("תעודת זהות רק ספרות");
            }
            if (!IsEmail(Email))
            {
                Answer += ("<br />");
                Answer += ("מייל שגוי");
            }
            if (!double.TryParse(Phone, out Num))
            {
                Answer += ("<br />");
                Answer += ("מספר טלפון רק ספרות");
            }
            if (!double.TryParse(Age, out Num))
            {
                Answer += ("<br />");
                Answer += ("גיל במספר שלם");
            }
            else if (int.Parse(Age) < 0 || int.Parse(Age) > 100)
            {
                Answer += ("<br />");
                Answer += ("גיל לא חוקי");
            }

            string UserExist = "SELECT *FROM " + Table + " WHERE " + "Username ='" + user + "'";
            if (MyAdoHelper.IsExist(Database, UserExist))
            {
                Answer += ("<br />");
                Answer += ("שם משתמש קיים");
            }
            string idNumExist = "SELECT *FROM " + Table + " WHERE " + "idNum ='" + idNum + "'";
            if (MyAdoHelper.IsExist(Database, idNumExist))
            {
                Answer += ("<br />");
                Answer += ("תעודת זהות קיימת");
            }
            string EmailExist = "SELECT *FROM " + Table + " WHERE " + "Email ='" + Email + "'";
            if (MyAdoHelper.IsExist(Database, EmailExist))
            {
                Answer += ("<br />");
                Answer += ("מייל קיים");
            }
            string PhoneExist = "SELECT *FROM " + Table + " WHERE " + "Phone ='" + Phone + "'";
            if (MyAdoHelper.IsExist(Database, PhoneExist))
            {
                Answer += ("<br />");
                Answer += ("מספר טלפון קיים");
            }
            if (Answer == "" || Answer == null)
            {
                if (Gender == 0)
                {
                    GenderType = ("Male");
                }
                if (Gender == 1)
                {
                    GenderType = ("Female");
                }
                if (user.Equals("morcohen"))
                {
                    Admin = "t";
                }
                else
                {
                    Admin = "f";
                }


                string SignUp = "INSERT INTO " + Table + " (pName, fName, Username, Password, Gender, idNum, Email, Phone, Age, Admin)";
                SignUp += " VALUES('" + pName + "','" + fName + "','" + user + "','" + pass + "','" + GenderType + "','" + idNum + "','" + Email + "','" + Phone + "','" + Age + "','" + Admin + "')";
                MyAdoHelper.DoQuery(Database, SignUp);

                Answer = ("<h3>תודה שנרשמת</h3>");

            }
        }
        else
        {
            Answer = ("מלא את החסר");
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Answer = null;
    }
}
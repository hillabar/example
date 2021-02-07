using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;
using System.Data;

public partial class second : System.Web.UI.Page
{
    public string userList1;
    

    public string Answer;
    string Database = "menuDB.mdf";
    string Table = "Recepies";

    protected void Submit_Button(object sender, EventArgs e)
    {
        //מכניס למשתנים את כל התכנים של הטקסט בוקס והרדיו בטון-סוג אוכל
      
        int FoodType = FoodChoose.SelectedIndex;
        string NameFoodType = null; 
        //double Num;
        string RecName = RecepieName.Text;
     
        // הבדיקה if בודקת שאין שדות ריקים או טופס לא חוקיבטופס שהמשתמש הכניס
        if ((FoodType != -1) && (RecName != null) && (RecName != ""))
        {
            //בדיקת נכונות השדות והוספת הערת שגיאה לכל שדה שהתגלה בפורמט לא נכון
          if (!Regex.IsMatch(RecName, "^[א-ת]*$")) //אם השם הפרטי לא מכיל רק אותיות באנגלית קטנות או גדולות(בכמות או בסדר כלשהם ) אז זה יכתוב שצריך לכתוב שם  רק בעברית
            {
                Answer += ("<br />");
                Answer += ("  שם מתכון רק בעברית ");
            }

            if (FoodType == 0)
            {
                NameFoodType = ("קינוחים");
            }
            if (FoodType == 1)
            {
                NameFoodType = ("בריאות");
            }
            if (FoodType == 2)
            {
                NameFoodType = ("תבשילים");
            }
            string RecNameExist = "SELECT * FROM " + Table + " WHERE RecName LIKE N'%" + RecName + "%' AND  FoodType LIKE N'%" +  NameFoodType + "%'";
           if (MyAdoHelper.IsExist(Database, RecNameExist))
            {
              
               userList1 += (" מצאתי " + RecName);
            } else {
                Answer += ("<br />");
                Answer += ("מתכון " + RecName+" " +"לא קיים בקטגוריה זאת ");
            }
            
            
            if (Answer == "" || Answer == null)
            {
                


                string SelectedRecepie = "SELECT RecText FROM " + Table + " WHERE RecName LIKE N'%" + RecName +"%'";
                //DataTable dt = MyAdoHelper.ExecuteDataTable(Database, SelectedRecepie);


                

                Answer = MyAdoHelper.printDataTable(Database, SelectedRecepie);
              
              
            }
        }
        else
        {
            Answer = ("נתונים חסרים");
        }

    }

   


    protected void Page_Load(object sender, EventArgs e)
    {
        string selectQuery = "SELECT * FROM Recepies";
        DataTable dt = MyAdoHelper.ExecuteDataTable("menuDB.mdf", selectQuery);

        

    }
}
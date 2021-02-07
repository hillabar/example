using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;

public partial class AddAsks : System.Web.UI.Page
{
    public string instertValid = "";
    void InstertAsk(string Username, string Date, string context)
    {
        XmlElement AskEle, UsernameEle, DateEle, contextEle;
        XmlDocument doc = new XmlDocument();
        string XMLflile = Server.MapPath("XMLFile.xml");
        doc.Load(XMLflile);
        UsernameEle = doc.CreateElement("Username");
        DateEle = doc.CreateElement("Date");
        AskEle = doc.CreateElement("Ask");
         contextEle = doc.CreateElement("context");
         UsernameEle.InnerText = Username;
         DateEle.InnerText = Date;
         contextEle.InnerText = context;
         AskEle.AppendChild(UsernameEle);
         AskEle.AppendChild(DateEle);
         AskEle.AppendChild(contextEle);
         doc.DocumentElement.InsertBefore(AskEle, doc.DocumentElement.FirstChild);
         FileStream fsxml = new FileStream(XMLflile, FileMode.Truncate, FileAccess.Write, FileShare.ReadWrite);
         doc.Save(fsxml);
         fsxml.Close();
         instertValid = "ההודעה פורסמה";

    }
    protected void AddAsk(object sender, EventArgs e)
    {
       if (Session["Login"] != null)
       {
           string insterasks = textask.Text;
             if (insterasks == "" || insterasks == null)
                 {
                instertValid += ("הכנס תוכן להודעה");
            }
           
        else
            {
                string username = Session["Login"] + "";
                DateTime dt =DateTime.Now;
            string currDate =dt.Day +"/"+dt.Month+"/"+dt.Year;
                InstertAsk(username, currDate, insterasks);
                Response.Redirect("SeeAsks.aspx");
                Response.End();

            }
        }
            
        else
        {
            Response.Redirect("myFirst.aspx");
                Response.End();
        }
        }

    }

          
                
            
           
        
   
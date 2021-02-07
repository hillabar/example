using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;

public partial class SeeAsks : System.Web.UI.Page
{
    public string asksk;


    protected void Page_Load(object sender, EventArgs e)
    {

        string XMLfile = Server.MapPath("XMLFile.xml");
        XmlDocument doc = new XmlDocument();
        doc.Load(XMLfile);
        XmlNodeList username = doc.GetElementsByTagName("Username");
        XmlNodeList date = doc.GetElementsByTagName("Date");
        XmlNodeList context = doc.GetElementsByTagName("context");
        int asks = context.Count;
        asksk += asks;
        for (int i = 0; i < asks; i++)
        {
            asksk += "<table  border='1' style='font-size:20px; font-family:Arial;' >";
            asksk += "<tr><td  style='background-color:#19A3A3';>כותב ההודעה: " + username[i].InnerText + "</td></tr>" + "<br />";
            asksk += "<tr><td  >תאריך: " + date[i].InnerText + "<br />";
            asksk += "תוכן ההודעה: " + context[i].InnerText + "</tr>" + "<br />";
            asksk += "</table>";

        }


    }
}
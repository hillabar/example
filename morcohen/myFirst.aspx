<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="myFirst.aspx.cs" Inherits="myFirst" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style13
        {
            color: #FF0000;
        }
        .style14
        {
            font-size: smaller;
        }

        .style15
        {
            color: #000000;
            font-size: x-large;
        }
        .style17
        {
            font-size: larger;
            color: #FF0000;
            }
        
        .style18
        {
            color: #000000;
            font-size: x-large;
            text-align: center;
        }
        
    .style19
    {
        font-size: x-large;
    }
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3 style="text-align:center" ></h3>
    <h1 style="text-align:center" class="style17" >  ברוכים הבאים לאתר שלי</h1> <img src="אוכל מאוד יפה.jpg" />

        <h3 class="style15">באתר זה תוכלו למצוא מתכונים חדשים ומגוונים.</h3>
    <h3 class="style15">תוכלו לבחור את סוג המתכונים בהם אתם מעוניינים .</h3>
    <span class="style13">       
  
<h3 class="style18">
            מה שנותר לכם, זה להירשם ולחפש מתכונים כרצונכם!</h3>
          <br />
    <img src="שף.jpg"
        style="margin-right: 0px; " 
      /><br />
        <br />
    <span class="style12"><span class="style14"> התחברת לאתר ב <%=currDate %>
    </span><br /><br />
        <span class="style12"><span class="style14">מספר  כניסות לאתר:</span></span><span class="style14">
         <%=Counter %>  
    </span>  
</asp:Content>


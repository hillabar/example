<%@ Page Title="Sign Up" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="simpleregister.aspx.cs" Inherits="simpleregister"  %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <style type="text/css">
        .style13
        {
            color: #FF0000;
        }
    </style>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  

   <div style="text-align:center" class="body2">
<h2 class="style13">טופס   הרשמה לאתר </h2>

<form id="Form1" runat="server" action="" style="font-size:26px; text-align:center; border: 1px solid black">
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="NameLabel" runat="server" EnableViewState="false" AssociatedControlID="txtName"> שם פרטי </asp:Label>
<asp:TextBox ID="txtName" runat="server" Height="20"></asp:TextBox><br />
<asp:Label ID="Label1" runat="server" EnableViewState="false" AssociatedControlID="txtFamily"> שם משפחה </asp:Label>
<asp:TextBox ID="txtFamily" runat="server" Height="20"></asp:TextBox><br />
<asp:Label ID="UserLabel" runat="server" EnableViewState="false" AssociatedControlID="txtUser">שם משתמש </asp:Label>
&nbsp;<asp:TextBox ID="txtUser" runat="server" Height="20"></asp:TextBox><br />
<asp:Label ID="PassLabel" runat="server" EnableViewState="false" AssociatedControlID="txtPass">סיסמה </asp:Label>
<asp:TextBox ID="txtPass" TextMode="Password" runat="server" Height="20"></asp:TextBox><br />
<asp:Label ID="GenderLabel" runat="server" EnableViewState="false" AssociatedControlID="GenderChoose">מין </asp:Label>
<asp:RadioButtonList ID="GenderChoose" runat="server" Width="717px">
<asp:ListItem>&nbsp;זכר</asp:ListItem>
<asp:ListItem>&nbsp;נקבה</asp:ListItem>
</asp:RadioButtonList>
<asp:Label ID="idLabel" runat="server" EnableViewState="false" AssociatedControlID="txtId">ת.ז. </asp:Label>
<asp:TextBox ID="txtId" runat="server" Height="20"></asp:TextBox><br />
<asp:Label ID="EmailLabel" runat="server" EnableViewState="false" AssociatedControlID="txtEmail">Email </asp:Label>
&nbsp;<asp:TextBox ID="txtEmail" runat="server" Height="20"></asp:TextBox><br />
<asp:Label ID="PhoneLabel" runat="server" EnableViewState="false" AssociatedControlID="txtPhone">מספר נייד </asp:Label>
&nbsp;<asp:TextBox ID="txtPhone" runat="server" Height="20"></asp:TextBox><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="AgeLabel" runat="server" EnableViewState="false" AssociatedControlID="txtAge">גיל </asp:Label>
&nbsp;<asp:TextBox ID="txtAge" runat="server" Height="20"></asp:TextBox>&nbsp; (שנים)<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Submit" runat="server"  Text="שלח" Width="81px" onclick="Submit_Button"/> 
<asp:Button ID="Reset" runat="server" Text="נקה" Width="81px" OnClientClick="document.forms[0].reset();return false;" />
<br />
<div style='font-size:16px;'>
<br />
<%=Answer %>
</div>
<br />
</form>
</div>
<a href="myFirst.aspx">דף הבית</a>
</asp:Content>


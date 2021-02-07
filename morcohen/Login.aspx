<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="icon" href="http://icons.iconarchive.com/icons/artdesigner/emoticons-2/206/eat-icon.png" type="image/x-icon" />
    <style type="text/css">
        .style12
        {
            color: #FF0000;
        }
        .style13
        {
            color: #FF0000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align:center" class="body2">
<form id="Form1" runat="server" action="" style="font-size:26px; text-align:center;">
<h2> כניסה לאתר למשתמשים רשומים</h2>

<asp:Label ID="UserLabel" runat="server" EnableViewState="false">שם משתמש </asp:Label>
<asp:TextBox ID="txtUser" runat="server" Height="20"></asp:TextBox><br />
<asp:Label ID="PassLabel" runat="server" EnableViewState="false">סיסמא </asp:Label>
<asp:TextBox ID="txtPass" TextMode="Password" runat="server" Height="20"></asp:TextBox><br />
<asp:Button ID="Submit" runat="server"  Text="שלח" Width="81px" OnClick="Login_Button" />
<asp:Button ID="Reset" runat="server" Text="נקה" Width="81px" OnClientClick="document.forms[0].reset();return false;" />
<br /><br />
&nbsp;<img src="לב מירקות.jpg">
<div style='font-size:16px;'><br /><%= Answer %>
</div>
</form>
</div>
</asp:Content>


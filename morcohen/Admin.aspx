<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="text-align:center"><%=userList %></p>
<h3 align="center"> מחיקת משתמש </h3>
<form id="Form1" runat="server">
   <asp:TextBox ID="admindelete" runat="server" Height="20"></asp:TextBox>
   <asp:Button ID="delete" runat="server" OnClick="SuperAdmin" Text=" מחק משתמש לפי תעודת זהות" /><br />
  <%=Alert%>
</form>
<br /> 
</asp:Content>


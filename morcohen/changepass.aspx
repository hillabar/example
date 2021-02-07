<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.master" AutoEventWireup="true" CodeFile="changepass.aspx.cs" Inherits="changepass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Change password</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<form id="changeform" runat="server" action="" >
 <br />
 <asp:Label ID="chackidnum" runat="server" font-size="25px" >תעודת זהות:</asp:Label>
   <asp:TextBox ID="textchackIDnum" runat="server" Height="20" MaxLength="9"></asp:TextBox><br />
   <asp:Label ID="passLabel" runat="server" font-size="25px"> סיסמא נוכחית:</asp:Label>
   <asp:TextBox ID="textpass" TextMode="Password" runat="server" Hight="20"></asp:TextBox><br />
   <asp:Label ID="newpass" runat="server" font-size="25px"> סיסמא חדשה:</asp:Label>
   <asp:TextBox ID="textnewpass" TextMode="Password" runat="server" Hight="20"></asp:TextBox><br />
   <asp:Button ID="submit" runat="server" OnClick="repass" Text="שלח" /><br />
   <%=changemsg %>
  </form> </div>
</asp:Content>


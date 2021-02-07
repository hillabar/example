<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddAsks.aspx.cs" Inherits="AddAsks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form runat="server">
  <img src="איש יושב ליד מחשב.jpg" />
<div align="center" style="font-size:30px"><br />
<asp:Label ID="enterask" runat="server">כתוב בספר המבקרים:</asp:Label><br />
   <asp:TextBox ID="textask" TextMode="MultiLine" runat="server" Height="65" Width="400" ></asp:TextBox><br />
   <asp:Button ID="sendasks" runat="server" OnClick="AddAsk" Text="שלח" /><br /></div>
   <div align="center" style="font-family:Arial Black; color:Black; font-size:30px;"><a href="SeeAsks.aspx"> קרא בספר המבקרים</a></div>
<%=instertValid %>
</form>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DeleteAccount.aspx.cs" Inherits="DeleteAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<form runat="server">
<asp:Button ID="Delete" runat="server"  Text="Delete Account" Width="120px" OnClick="Delete_Button"/><br />
<%= Answer %>
</form>
</asp:Content>


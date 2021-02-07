<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SeeAsks.aspx.cs" Inherits="SeeAsks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h3> מספר התגובות עד עכשיו: <%=asksk%></h3>

<div align="center" style="font-family:Arial Black; color:Black; font-size:30px;"><a href="AddAsks.aspx"> הוסף תגובה</a></div>
</asp:Content>


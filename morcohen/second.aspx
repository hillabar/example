<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="second.aspx.cs" Inherits="second" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript">
    function Logopic() {
        pic.src = "images[3].jpg";
    }
    function Tohomepic()
    { pic.src = "סרט מדידה מידע.jpg"; }
</script>


    <style type="text/css">
        .style15
        {
            color: #000000;
        }
        .style16
        {
            text-align: right;
            font-family: Arial;
            color: #000000;
        }
        .style19
        {
            font-family: Arial;
            text-align: right;
            font-size: medium;
        }
        .style21
        {
            color: #000000;
            text-align: right;
        }
        .style22
        {
            text-align: right;
        }
        .style23
        {
            font-size: medium;
        }
        .style24
        {
            text-align: right;
            font-family: Arial;
            color: #000000;
            font-size: medium;
        }
        .style25
        {
            color: #000000;
            text-align: right;
            font-size: medium;
        }
        .style26
        {
            text-align: right;
            font-size: medium;
        }
    </style>

</asp:Content>



<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  

   <div style="text-align:center" class="body2">
<h2 class="style13">חיפוש מתכונים </h2>

<form id="Form1" runat="server" action="" style="font-size:26px; text-align:center; border: 1px solid black">
&nbsp;&nbsp;&nbsp;&nbsp;

<asp:Label ID="FoodLabel" runat="server" EnableViewState="false" AssociatedControlID="FoodChoose">סוג המתכון </asp:Label>
<asp:RadioButtonList ID="FoodChoose" runat="server" Width="717px">
<asp:ListItem>&nbsp;קינוחים</asp:ListItem>
<asp:ListItem>&nbsp;בריאות</asp:ListItem>
<asp:ListItem>&nbsp;תבשילים</asp:ListItem>
</asp:RadioButtonList>
<asp:Label ID="RecepieLabel" runat="server" EnableViewState="false" AssociatedControlID="RecepieName">שם המתכון </asp:Label>
<asp:TextBox ID="RecepieName" runat="server" Height="20"></asp:TextBox><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Submit" runat="server"  Text="שלח" Width="81px" onclick="Submit_Button"/> 
<asp:Button ID="Reset" runat="server" Text="נקה" Width="81px" OnClientClick="document.forms[0].reset();return false;" />
<br />
<div style='font-size:16px;'>
<br />
<%=Answer %>
    <br />
    <br />
    <%=userList1 %>
</div>
<br />
</form>
</div>
<a href="myFirst.aspx">דף הבית</a>
</asp:Content>

















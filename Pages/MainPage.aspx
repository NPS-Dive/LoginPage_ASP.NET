<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="LoginPage.Pages.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Contents/CSS/CSSMainPage.css" rel="stylesheet" type="text/css" />
    <title>MainPage</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p> Dear user Welcome to main Page</p>
            <br />
            <asp:Button ID="btnLogout" runat="server" Text="LogOut" Onclick="btnLogout_Click"/>
        </div>
    </form>
</body>
</html>

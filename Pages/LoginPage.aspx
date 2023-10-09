<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="LoginPage.Pages.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Contents/CSS/CSSLoginPage.css" rel="stylesheet" type="text/css"/>
    <title>Login Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="divLogin">
            UserName:
            <br />
            <input type="text" id="txtUserName" runat="server" maxlength="35"/>
            <br />
            Password:
            <br />
            <input type="password" id="txtPass" runat="server" maxlength="75"/>
            <hr />
            <label id="lblLoginMSG" runat="server"></label>
            <br />
            <asp:Button id="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/>
        </div>
    </form>
</body>
</html>

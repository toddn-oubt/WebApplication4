﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionExampleSubmit.aspx.cs" Inherits="WebApplication4.SessionExampleSubmit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" /> <br />
        <asp:Button ID="Button1" runat="server" 
            Text="Clear Session" 
            onclick="Button1_Click" />
    </div>
    </form>
</body>
</html>

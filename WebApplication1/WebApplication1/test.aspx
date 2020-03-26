<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="WebApplication1.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="txtUsers"></asp:TextBox>
            <asp:TextBox runat="server" ID="txtTask"></asp:TextBox>
            <asp:Button runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" />
            <asp:Label runat="server" ID="lblOutput"></asp:Label>
        </div>
    </form>
</body>
</html>

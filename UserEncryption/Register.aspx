<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="UserEncryption.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtUsername" runat="server" placeholder ="Enter Username"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvUser" runat="server" ControlToValidate="txtUserName" ErrorMessage="USer name is Required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />

            <asp:TextBox ID="txtEnail" runat="server" placeholder="Enter Email"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvEmail" runat="server"
                ControlToValidate="txtEmail" ErrorMessage="Email is Required" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ValidationExpression="\w+@\w\.\w+" ErrorMessage="Inavlid Email" ForeColor="Red"></asp:RegularExpressionValidator> 
            <br />

            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Enter Password"></asp:TextBox>
            <asp:RegularExpressionValidator ID="revPassword" runat="server" ControlToValidate="txtPassword"ErrorMessage="Inavlid Password" ForeColor="Red"></asp:RegularExpressionValidator> 
        </div>
    </form>
</body>
</html>

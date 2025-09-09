<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ValidateFormProject.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Validate me!</h2>
            <asp:Label ID="Label1" runat="server" Text="Username(6-8 characters)"></asp:Label>
            <br /><br />
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="Label2" runat="server" Text="Pin"></asp:Label>
            <br /><br />
            <asp:TextBox ID="txtPin" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="Label3" runat="server" Text="States"></asp:Label>
            <br /><br />
            <asp:DropDownList ID="ddlState" runat="server" AutoPostBack="True">
                <asp:ListItem>----Select----</asp:ListItem>
                <asp:ListItem>Karnataka</asp:ListItem>
                <asp:ListItem>Maharashtra</asp:ListItem>
                <asp:ListItem>Uttar Pradesh</asp:ListItem>
                <asp:ListItem>Gujrat</asp:ListItem>
                <asp:ListItem>Himachal Pradesh</asp:ListItem>
            </asp:DropDownList>
            <br /><br />

            <asp:CheckBox ID="CheckValidate" runat="server" Text="Validate Pin" />
            <br /><br />

            <asp:Label ID="Label4" runat="server" Text="Select one:"></asp:Label>
            <br /><br />
            <asp:RadioButton ID="rbMilk" runat="server" GroupName="Food" Text="Milk" />
            <br /><br />
            <asp:RadioButton ID="rbCheese" runat="server" GroupName="Food" Text="Cheese" />
            <br /><br />
            <asp:RadioButton ID="rbButter" runat="server" GroupName="Food" Text="Butter" />
            <br /><br />

            <asp:Button ID="btncheck" runat="server" Text="Check Form" OnClick="btnCheck_click" />
            <br /><br />
            
            <asp:Label ID="lblResult" runat="server" ForeColor="Red"></asp:Label>

        </div>
    </form>
</body>
</html>

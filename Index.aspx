<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TopSecretAgents.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBoxID" runat="server"></asp:TextBox>
            <asp:Label ID="Label_ID" runat="server" Text="ID"></asp:Label>
        </div>
        <asp:TextBox ID="TextBoxRealName" runat="server"></asp:TextBox>
        <asp:Label ID="Label_RealName" runat="server" Text="Real name"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxCodeName" runat="server"></asp:TextBox>
        <asp:Label ID="Label_CodeName" runat="server" Text="Code name"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxFirstLang" runat="server"></asp:TextBox>
        <asp:Label ID="Label_FirstLang" runat="server" Text="Primary language"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxSecondLang" runat="server"></asp:TextBox>
        <asp:Label ID="Label_SecondLang" runat="server" Text="Secondary language"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button_CreateAgent" runat="server" OnClick="Button_CreateAgent_Click" Text="Create" />
        <br />
        <br />
        <asp:Button ID="Button_ShowAgents" runat="server" OnClick="Button_ShowAgents_Click" Text="Show agents" />
        <br />
        <br />
        <asp:ListBox ID="ListBoxResults" runat="server" Height="289px" Width="436px"></asp:ListBox>
    </form>
</body>
</html>

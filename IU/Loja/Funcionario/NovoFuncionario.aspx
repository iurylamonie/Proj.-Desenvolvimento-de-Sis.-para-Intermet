<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NovoFuncionario.aspx.cs" Inherits="Loja.Funcionario.NovoFuncionario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><asp:Label ID="Label5" runat="server" Text="Label"></asp:Label><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem>Motorista</asp:ListItem>
            <asp:ListItem>Tecnico</asp:ListItem>
        </asp:RadioButtonList><br />
        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label><asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
    </div>
    </form>
</body>
</html>

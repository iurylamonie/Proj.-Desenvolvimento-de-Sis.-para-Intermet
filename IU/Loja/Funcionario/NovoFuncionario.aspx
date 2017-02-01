<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NovoFuncionario.aspx.cs" Inherits="Loja.Funcionario.NovoFuncionario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Código"></asp:Label><br /><asp:TextBox ID="TextBoxCodigo" runat="server" Enabled="false"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="Nome"></asp:Label><br /><asp:TextBox ID="TextBoxNome" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" Text="Telefone(s)"></asp:Label><asp:TextBox ID="TextBoxTelefone" runat="server"></asp:TextBox><asp:Label ID="Label4" runat="server" Text="Identidade"></asp:Label><asp:TextBox ID="TextBoxIdentidade" runat="server"></asp:TextBox><asp:Label ID="Label5" runat="server" Text="Carteira de Trabalho"></asp:Label><asp:TextBox ID="TextBoxCT" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label6" runat="server" Text="Salário"></asp:Label><asp:TextBox ID="TextBoxSalario" runat="server"></asp:TextBox>
        <asp:RadioButtonList ID="RadioButtonListTrabalho" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem>Motorista</asp:ListItem>
            <asp:ListItem>Tecnico</asp:ListItem>
        </asp:RadioButtonList><br />
        <asp:Label ID="Label7" runat="server" Text="Observação"></asp:Label><asp:TextBox ID="TextBoxObservacao" runat="server"></asp:TextBox> <br />
        <asp:Button ID="ButtonGravar" runat="server" Text="Gravar" OnClick="ButtonGravar_Click" /><asp:Button ID="ButtonCancelar" runat="server" Text="Cancelar" OnClick="ButtonCancelar_Click" />
    </div>
    </form>
</body>
</html>

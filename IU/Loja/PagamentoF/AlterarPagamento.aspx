<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AlterarPagamento.aspx.cs" Inherits="Loja.PagamentoF.AlterarPagamento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><asp:TextBox ID="TextBoxCodigo" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><asp:TextBox ID="TextBoxNome" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label><asp:TextBox ID="TextBoxData" runat="server"/>
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label><asp:DropDownList ID="DropDownListMes" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>11</asp:ListItem>
            <asp:ListItem>12</asp:ListItem>
        </asp:DropDownList><asp:Label ID="Label5" runat="server" Text="/"></asp:Label><asp:TextBox ID="TextBoxAno" runat="server"></asp:TextBox> <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label><asp:TextBox ID="TextBoxPagamento" runat="server"></asp:TextBox><br />
        <asp:Button ID="ButtonGravar" runat="server" Text="Gravar" /><asp:Button ID="ButtonCancelar" runat="server" Text="Cancelar" />
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Loja.PagamentoF.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="ButtonFechar" runat="server" Text="Fechar" /><asp:Button ID="ButtonIncluir" runat="server" Text="Incluir" /><asp:Button ID="ButtonAlterar" runat="server" Text="Alterar" /><asp:Button ID="ButtonExcluir" runat="server" Text="Excluir" /><asp:Button ID="ButtonAttDados" runat="server" Text="Atualizar Dados" /><br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><asp:TextBox ID="TextBoxNomeFun" runat="server"></asp:TextBox><asp:Button ID="ButtonPesquisar" runat="server" Text="Button" /><br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><asp:DropDownList ID="DropDownListMes" runat="server">
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
        </asp:DropDownList><asp:Label ID="Label3" runat="server" Text="/"></asp:Label><asp:TextBox ID="TextBoxAno" runat="server"></asp:TextBox> <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label><asp:Label ID="LabelSalario" runat="server" Text="Label"></asp:Label>
        <asp:GridView ID="GridViewPagamentos" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSourcePagamento">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="Funcionario_id" HeaderText="Funcionario_id" SortExpression="Funcionario_id" />
                <asp:BoundField DataField="MesReferente" HeaderText="MesReferente" SortExpression="MesReferente" />
                <asp:BoundField DataField="AnoReferente" HeaderText="AnoReferente" SortExpression="AnoReferente" />
                <asp:BoundField DataField="ValorPago" HeaderText="ValorPago" SortExpression="ValorPago" />
                <asp:BoundField DataField="DataPagamento" HeaderText="DataPagamento" SortExpression="DataPagamento" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSourcePagamento" runat="server" SelectMethod="Listar" TypeName="ModeloLoja.Pagamento">
            <SelectParameters>
                <asp:Parameter Name="_nomeFuncionario" Type="String" />
                <asp:Parameter Name="_mesReferente" Type="Int32" />
                <asp:Parameter Name="_anoReferente" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>

        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label><asp:TextBox ID="TextBoxPagamentoFeito" runat="server"></asp:TextBox><asp:Label ID="Label6" runat="server" Text="Label"></asp:Label><asp:TextBox ID="TextBoxValorDevido" runat="server"></asp:TextBox>
    </div>
    </form>
</body>
</html>

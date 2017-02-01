<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Loja.Funcionario.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="ButtonFechar" runat="server" Text="Fechar" /><asp:Button ID="ButtonIncluir" runat="server" Text="Incluir" OnClick="ButtonIncluir_Click" /><asp:Button ID="ButtonAlterar" runat="server" Text="Alterar" /><asp:Button ID="ButtonExcluir" runat="server" Text="Excluir" /><asp:Button ID="ButtonAttDados" runat="server" Text="Atualizar Dados" /><br />
        <asp:GridView ID="GridViewFuncionarios" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSourceFuncionarios" OnRowCommand="GridViewFuncionarios_RowCommand">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                <asp:BoundField DataField="Telefone" HeaderText="Telefone" SortExpression="Telefone" />
                <asp:BoundField DataField="Identidade" HeaderText="Identidade" SortExpression="Identidade" />
                <asp:BoundField DataField="Ct" HeaderText="Ct" SortExpression="Ct" />
                <asp:BoundField DataField="Observacao" HeaderText="Observacao" SortExpression="Observacao" />
                <asp:BoundField DataField="Salario" HeaderText="Salario" SortExpression="Salario" />
                <asp:CheckBoxField DataField="Motorista" HeaderText="Motorista" SortExpression="Motorista" />
                <asp:CheckBoxField DataField="Tecnico" HeaderText="Tecnico" SortExpression="Tecnico" />                
                <asp:ButtonField Text="Alterar" CommandName="Alterar" />
                <asp:ButtonField Text="Excluir" CommandName="Excluir" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSourceFuncionarios" runat="server" SelectMethod="Listar" TypeName="ModeloLoja.Funcionario"></asp:ObjectDataSource>
    </div>
    </form>
</body>
</html>

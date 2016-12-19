<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicial.aspx.cs" Inherits="Loja.Fornecedor.Inicial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="ButtonFechar" runat="server" Text="Fechar" />
        <asp:Button ID="ButtonIncluir" runat="server" Text="Incluir" />
        <asp:Button ID="ButtonAlterar" runat="server" Text="Alterar" />
        <asp:Button ID="ButtonExcluir" runat="server" Text="Excluir" />
        <asp:Button ID="ButtonAttDados" runat="server" Text="Atualizar Dados" />
        <br />
        <hr />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="nome" HeaderText="Nome" SortExpression="nome" />
                <asp:BoundField DataField="telefone" HeaderText="Telefones" SortExpression="telefone" />
                <asp:CheckBoxField DataField="motorista" HeaderText="Motorista" SortExpression="motorista" />
                <asp:CheckBoxField DataField="tecnico" HeaderText="Técnico" SortExpression="tecnico" />
                <asp:BoundField DataField="identidade" HeaderText="Identidade" SortExpression="identidade" />
                <asp:BoundField DataField="carteiraTrabalho" HeaderText="CLT" SortExpression="carteiraTrabalho" />
                <asp:BoundField DataField="salario" HeaderText="Salário" SortExpression="salario" />
                <asp:BoundField DataField="observacao" HeaderText="Observação" SortExpression="observacao" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ListarFuncionarios" TypeName="Loja.Entidades.Funcionario"></asp:ObjectDataSource>
    </div>
    </form>
</body>
</html>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Loja.Funcionario
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonIncluir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Funcionario/NovoFuncionario.aspx");
        }

        protected void GridViewFuncionarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Excluir")
            {
               int index = int.Parse(e.CommandArgument.ToString());
               string id = GridViewFuncionarios.Rows[index].Cells[0].Text;
                ModeloLoja.Funcionario.Deletar(int.Parse(id));
                Response.Redirect("~/Funcionario/Principal.aspx");
            }
            else if (e.CommandName == "Alterar")
            {
                int index = int.Parse(e.CommandArgument.ToString());
                Session["funcionarioId"] = GridViewFuncionarios.Rows[index].Cells[0].Text;
                Response.Redirect("~/Funcionario/AlterarFuncionario.aspx");
            }
        }
    }
}
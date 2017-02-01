using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Loja.Funcionario
{
    public partial class NovoFuncionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Funcionario/Principal.aspx");
        }

        protected void ButtonGravar_Click(object sender, EventArgs e)
        {
            ModeloLoja.Funcionario funcionario = new ModeloLoja.Funcionario
            {
                Nome = TextBoxNome.Text,
                Telefone = TextBoxTelefone.Text,
                Ct = TextBoxCT.Text,
                Salario = double.Parse(TextBoxSalario.Text),
                Observacao = TextBoxObservacao.Text,
                Motorista = false,
                Tecnico = false
            };

            if (RadioButtonListTrabalho.SelectedValue == "Motorista")
            {
                funcionario.Motorista = true;
                funcionario.Tecnico = false;
            }
            else if (RadioButtonListTrabalho.SelectedValue == "Tecnico")
            {
                funcionario.Motorista = false;
                funcionario.Tecnico = true;
            }

            ModeloLoja.Funcionario.Registrar(funcionario);
            Response.Redirect("~/Funcionario/Principal.aspx");
        }
    }
}
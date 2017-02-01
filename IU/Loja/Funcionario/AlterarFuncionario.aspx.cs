using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Loja.Funcionario
{
    public partial class AlterarFuncionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ModeloLoja.Funcionario funcionario = ModeloLoja.Funcionario.ConsultarPorId(int.Parse(Session["funcionarioId"].ToString()));
                TextBoxCodigo.Text = funcionario.Id.ToString();
                TextBoxNome.Text = funcionario.Nome;
                TextBoxTelefone.Text = funcionario.Telefone;
                TextBoxIdentidade.Text = funcionario.Identidade;
                TextBoxCT.Text = funcionario.Ct;
                TextBoxSalario.Text = funcionario.Salario.ToString();
                TextBoxObservacao.Text = funcionario.Observacao;
                if (funcionario.Motorista == true)
                {
                    RadioButtonListTrabalho.SelectedIndex = 0;
                }
                else if (funcionario.Tecnico == true)
                {
                    RadioButtonListTrabalho.SelectedIndex = 1;
                }
            }
        }

        protected void ButtonGravar_Click(object sender, EventArgs e)
        {
            ModeloLoja.Funcionario funcionario = new ModeloLoja.Funcionario
            {   Id = int.Parse(TextBoxCodigo.Text),
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

            ModeloLoja.Funcionario.Atualizar(funcionario);
            Response.Redirect("~/Funcionario/Principal.aspx");
        }

        protected void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Funcionario/Principal.aspx");
        }
    }
}
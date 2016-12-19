using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Loja.Entidades
{
    public  class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Identidade { get; set; }
        public string CarteiraTrabalho { get; set; }
        public double Salario { get; set; }
        public bool Motorista { get; set; }
        public bool Tecnico { get; set; }
        public string Observacao { get; set; }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<ClassLibrary.Funcionario> ListarFuncionarios()
        {
            var funcionarios = ClassLibrary.DAO.Funcionario.Listar();
            return funcionarios;
        }
    }
}
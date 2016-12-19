using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAO
{
    public static class Funcionario
    {
        public static void Incluir(ClassLibrary.Funcionario funcionario)
        {
            LojaDataContext cd = new LojaDataContext();
            cd.Funcionarios.InsertOnSubmit(funcionario);
            cd.SubmitChanges();
        }

        public static void Alterar(ClassLibrary.Funcionario funcionario)
        {
            LojaDataContext cd = new LojaDataContext();
            var Funcionariobd = (from f in cd.Funcionarios
                                 where f.codigo == funcionario.codigo
                                 select f).Single();
            Funcionariobd = funcionario;
            cd.SubmitChanges();
        }

        public static List<ClassLibrary.Funcionario> Listar()
        {
            LojaDataContext cd = new LojaDataContext();
            var r = from f in cd.Funcionarios select f;
            return r.ToList();
        }

        public static void Deletar(int id)
        {
            LojaDataContext cd = new LojaDataContext();
            var Funcionariobd = (from f in cd.Funcionarios
                                 where f.codigo == id
                                 select f).Single();
            cd.Funcionarios.DeleteOnSubmit(Funcionariobd);
            cd.SubmitChanges();
        }
    }
}

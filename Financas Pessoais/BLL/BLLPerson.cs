using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLPerson
    {

        private DALConexao connection;

        public BLLPerson(DALConexao cx)
        {
            this.connection = cx;
        }

        public void Incluir(ModeloPessoa modelo)
        {
            if (modelo.Nome.Trim().Length == 0)
                throw new Exception("O nome é obrigatório!");

            DALPerson DALobj = new DALPerson(connection);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloPessoa modelo)
        {
            if (modelo.Nome.Trim().Length == 0)
                throw new Exception("O nome é obrigatório!");

            DALPerson DALobj = new DALPerson(connection);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALPerson DALobj = new DALPerson(connection);
            DALobj.Excluir(codigo);
        }

        public ModeloPessoa CarregaModeloPessoa(int codigo)
        {
            DALPerson DALobj = new DALPerson(connection);
            return DALobj.CarregaModeloPessoa(codigo);
        }
    }
}
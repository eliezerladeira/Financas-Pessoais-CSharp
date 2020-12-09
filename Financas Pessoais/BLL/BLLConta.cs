using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLConta
    {
        private DALConexao conexao;

        public BLLConta(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloConta modelo)
        {
            if (modelo.Descricao.Trim().Length == 0)
                throw new Exception("A descrição da conta é obrigatória!");

            DALConta DALobj = new DALConta(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloConta modelo)
        {
            if (modelo.IdConta < 0)
                throw new Exception("O código da Conta é obrigatório!");

            if (modelo.Descricao.Trim().Length == 0)
                throw new Exception("A descrição da Conta é obrigatória!");

            DALConta DALobj = new DALConta(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALConta DALobj = new DALConta(conexao);
            DALobj.Excluir(codigo);
        }

        public ModeloConta CarregaModeloConta(int codigo)
        {
            DALConta DALobj = new DALConta(conexao);
            return DALobj.CarregaModeloConta(codigo);
        }
    }
}
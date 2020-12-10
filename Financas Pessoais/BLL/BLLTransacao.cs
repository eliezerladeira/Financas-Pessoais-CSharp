using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLTransacao
    {
        private DALConexao conexao;

        public BLLTransacao(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloTransacao modelo)
        {
            if (modelo.IdTransacao < 0)
                throw new Exception("O código da transação é obrigatório!");

            if (modelo.IdSequencia < 0)
                throw new Exception("O código da sequência é obrigatório!");

            if (modelo.Data == DateTime.MinValue)
                throw new Exception("A data do lançamento é obrigatória!");

            if (modelo.Tipo.Trim().Length == 0)
                throw new Exception("O tipo do lançamento é obrigatório!");

            if (modelo.Descricao.Trim().Length == 0)
                throw new Exception("A descrição do lançamento é obrigatória!");

            if (modelo.IdContaOrigem < 0)
                throw new Exception("A conta de origem é obrigatória!");

            if (modelo.IdContaDestino < 0)
                throw new Exception("A conta de destino é obrigatória!");

            if (modelo.Valor < 0)
                throw new Exception("O valor da transação é obrigatório!");

            if (modelo.Parcelas < 0)
                throw new Exception("O número de parcelas da transação é obrigatório!");

            DALTransacao DALobj = new DALTransacao(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloTransacao modelo)
        {
            if (modelo.IdTransacao < 0)
                throw new Exception("O código da transação é obrigatório!");

            if (modelo.IdSequencia < 0)
                throw new Exception("O código da sequência é obrigatório!");

            if (modelo.Data == DateTime.MinValue)
                throw new Exception("A data do lançamento é obrigatória!");

            if (modelo.Tipo.Trim().Length == 0)
                throw new Exception("O tipo do lançamento é obrigatório!");

            if (modelo.Descricao.Trim().Length == 0)
                throw new Exception("A descrição do lançamento é obrigatória!");

            if (modelo.IdContaOrigem < 0)
                throw new Exception("A conta de origem é obrigatória!");

            if (modelo.IdContaDestino < 0)
                throw new Exception("A conta de destino é obrigatória!");

            if (modelo.Valor < 0)
                throw new Exception("O valor da transação é obrigatório!");

            if (modelo.Parcelas < 0)
                throw new Exception("O número de parcelas da transação é obrigatório!");

            DALTransacao DALobj = new DALTransacao(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALTransacao DALobj = new DALTransacao(conexao);
            DALobj.Excluir(codigo);
        }

        public ModeloTransacao CarregaModeloTransacao(int codigo)
        {
            DALTransacao DALobj = new DALTransacao(conexao);
            return DALobj.CarregaModeloTransacao(codigo);
        }
    }
}
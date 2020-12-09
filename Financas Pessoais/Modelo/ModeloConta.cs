using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloConta
    {
        public ModeloConta()
        {
            this.IdConta = 0;
            this.IdSequencia = 0;
            this.Descricao = "";
            this.SaldoInicial = 0.00;
            this.SaldoAtual = 0.00;
            this.Cadastro = DateTime.Now;
            this.Inativa = DateTime.Now;
            this.Ativa = "";
        }

        public ModeloConta(int conta, int sequencia, String descricao, Double inicial, Double atual, DateTime cadastro, DateTime inativa, String ativa)
        {
            this.IdConta = conta;
            this.IdSequencia = sequencia;
            this.Descricao = descricao;
            this.SaldoInicial = inicial;
            this.SaldoAtual = atual;
            this.Cadastro = cadastro;
            this.Inativa = inativa;
            this.Ativa = ativa;
        }

        private int _idconta;
        private int _idsequencia;
        private String _descricao;
        private Double _saldoinicial;
        private Double _saldoatual;
        private DateTime _cadastro;
        private DateTime _inativa;
        private String _ativa;

        public int IdConta { get => _idconta; set => _idconta = value; }

        public int IdSequencia { get => _idsequencia; set => _idsequencia = value; }

        public string Descricao { get => _descricao; set => _descricao = value; }

        public double SaldoInicial { get => _saldoinicial; set => _saldoinicial = value; }

        public double SaldoAtual { get => _saldoatual; set => _saldoatual = value; }

        public DateTime Cadastro { get => _cadastro; set => _cadastro = value; }

        public DateTime Inativa { get => _inativa; set => _inativa = value; }

        public string Ativa { get => _ativa; set => _ativa = value; }
    }
}
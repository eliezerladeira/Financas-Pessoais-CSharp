using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloTransacao
    {
        public ModeloTransacao()
        {
            this.Sequencia = 0;
            this.Transacao = "";
            this.Data = DateTime.Now;
            this.Descricao = "";
            this.ContaOrigem = 0;
            this.ContaDestino = 0;
            this.Valor = 0;
            this.Consolidada = "";
            this.Nota = "";
        }

        public ModeloTransacao(int sequencia, String transacao, DateTime data, String descricao, int contaorigem, int contadestino, Double valor, String consolidada, String nota)
        {
            this.Sequencia = sequencia;
            this.Transacao = transacao;
            this.Data = data;
            this.Descricao = descricao;
            this.ContaOrigem = contaorigem;
            this.ContaDestino = contadestino;
            this.Valor = valor;
            this.Consolidada = consolidada;
            this.Nota = nota;
        }

        private int _sequencia;
        private String _transacao;
        private DateTime _data;
        private String _descricao;
        private int _conta_origem;
        private int _conta_destino;
        private Double _valor;
        private String _consolidada;
        private String _nota;

        public int Sequencia
        {
            get { return this._sequencia; }
            set { this._sequencia = value; }
        }

        public String Transacao
        {
            get { return this._transacao; }
            set { this._transacao = value; }
        }

        public DateTime Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        public String Descricao
        {
            get { return this._descricao; }
            set { this._descricao = value; }
        }

        public int ContaOrigem
        {
            get { return this._conta_origem; }
            set { this._conta_origem = value; }
        }

        public int ContaDestino
        {
            get { return this._conta_destino; }
            set { this._conta_destino = value; }
        }

        public Double Valor
        {
            get { return this._valor; }
            set { this._valor = value; }
        }

        public String Consolidada
        {
            get { return this._consolidada; }
            set { this._consolidada = value; }
        }

        public String Nota
        {
            get { return this._nota; }
            set { this._nota = value; }
        }
    }
}
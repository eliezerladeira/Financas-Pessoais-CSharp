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
            this.IdTransacao = 0;
            this.IdSequencia = 0;
            this.Data = DateTime.Now;
            this.Tipo = "";
            this.Descricao = "";
            this.IdContaOrigem = 0;
            this.IdContaDestino = 0;
            this.Valor = 0;
            this.Nota = "";
            this.IdPessoa = 0;
            this.NotaFiscal = "";
            this.Parcelas = 0;
            this.RepetirNumero = 0;
            this.RepetirTempo = "";
        }

        public ModeloTransacao(int transacao, int sequencia, DateTime data, String tipo, String descricao, int idcontaorigem, int idcontadestino, Double valor, String nota, int idpessoa, String notafiscal, int parcelas, int repetirnumero, String repetirtempo)
        {
            this.IdTransacao = transacao;
            this.IdSequencia = sequencia;
            this.Data = data;
            this.Tipo = tipo;
            this.Descricao = descricao;
            this.IdContaOrigem = idcontaorigem;
            this.IdContaDestino = idcontadestino;
            this.Valor = valor;
            this.Nota = nota;
            this.IdPessoa = idpessoa;
            this.NotaFiscal = notafiscal;
            this.Parcelas = parcelas;
            this.RepetirNumero = repetirnumero;
            this.RepetirTempo = repetirtempo;
        }

        private int _idtransacao;
        private int _idsequencia;
        private DateTime _data;
        private String _tipo;
        private String _descricao;
        private int _idcontaorigem;
        private int _idcontadestino;
        private Double _valor;
        private String _nota;
        private int _idpessoa;
        private String _notafiscal;
        private int _parcelas;
        private int _repetirnumero;
        private String _repetirtempo;

        public int IdTransacao { get => _idtransacao; set => _idtransacao = value; }

        public int IdSequencia { get => _idsequencia; set => _idsequencia = value; }

        public DateTime Data { get => _data; set => _data = value; }

        public string Tipo { get => _tipo; set => _tipo = value; }

        public string Descricao { get => _descricao; set => _descricao = value; }

        public int IdContaOrigem { get => _idcontaorigem; set => _idcontaorigem = value; }

        public int IdContaDestino { get => _idcontadestino; set => _idcontadestino = value; }

        public double Valor { get => _valor; set => _valor = value; }

        public string Nota { get => _nota; set => _nota = value; }

        public int IdPessoa { get => _idpessoa; set => _idpessoa = value; }

        public string NotaFiscal { get => _notafiscal; set => _notafiscal = value; }

        public int Parcelas { get => _parcelas; set => _parcelas = value; }

        public int RepetirNumero { get => _repetirnumero; set => _repetirnumero = value; }

        public string RepetirTempo { get => _repetirtempo; set => _repetirtempo = value; }
    }
}
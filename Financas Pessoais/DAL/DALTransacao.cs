using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
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
*/
namespace DAL
{
    public class DALTransacao
    {
        private DALConexao conexao;

        public DALTransacao(DALConexao conn)
        {
            this.conexao = conn;
        }

        public void Incluir(ModeloTransacao modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO transacoes (id_sequencia, data, tipo, descricao, id_conta_origem, id_conta_destino, valor, nota, id_pessoa, nota_fiscal, parcelas, repetir_numero, repetir_tempo) " +
                    "VALUES (@idsequencia, @data, @tipo, @descricao, @idcontaorigem, @idcontadestino, @valor, @nota, @idpessoa, @notafiscal, @parcelas, @repetirnumero, @repetirtempo); SELECT @@IDENTITY;";
                cmd.Parameters.AddWithValue("@idsequencia", modelo.IdSequencia);
                cmd.Parameters.AddWithValue("@data", modelo.Data);
                cmd.Parameters.AddWithValue("@tipo", modelo.Tipo);
                cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
                cmd.Parameters.AddWithValue("@idcontaorigem", modelo.IdContaOrigem);
                cmd.Parameters.AddWithValue("@idcontadestino", modelo.IdContaDestino);
                cmd.Parameters.AddWithValue("@valor", modelo.Valor);
                cmd.Parameters.AddWithValue("@nota", modelo.Nota);
                cmd.Parameters.AddWithValue("@idpessoa", modelo.IdPessoa);
                cmd.Parameters.AddWithValue("@notafiscal", modelo.NotaFiscal);
                cmd.Parameters.AddWithValue("@parcelas", modelo.Parcelas);
                cmd.Parameters.AddWithValue("@repetirnumero", modelo.RepetirNumero);
                cmd.Parameters.AddWithValue("@repetirtempo", modelo.RepetirTempo);
                conexao.Conectar();
                modelo.IdTransacao = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void Alterar(ModeloTransacao modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE transacoes SET id_sequencia = @idsequencia, data = @data, tipo = @tipo, descricao = @descricao, id_conta_origem = @idcontaorigem, " +
                    "id_conta_destino = @idcontadestino, valor = @valor, nota = @nota, id_pessoa = @idpessoa, nota_fiscal = @notafiscal, parcelas = @parcelas, repetir_numero = @repetirnumero, " +
                    "repetir_tempo = @repetirtempo WHERE id_transacao = @idtransacao";
                cmd.Parameters.AddWithValue("@idtransacao", modelo.IdTransacao);
                cmd.Parameters.AddWithValue("@idsequencia", modelo.IdSequencia);
                cmd.Parameters.AddWithValue("@data", modelo.Data);
                cmd.Parameters.AddWithValue("@tipo", modelo.Tipo);
                cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
                cmd.Parameters.AddWithValue("@idcontaorigem", modelo.IdContaOrigem);
                cmd.Parameters.AddWithValue("@idcontadestino", modelo.IdContaDestino);
                cmd.Parameters.AddWithValue("@valor", modelo.Valor);
                cmd.Parameters.AddWithValue("@nota", modelo.Nota);
                cmd.Parameters.AddWithValue("@idpessoa", modelo.IdPessoa);
                cmd.Parameters.AddWithValue("@notafiscal", modelo.NotaFiscal);
                cmd.Parameters.AddWithValue("@parcelas", modelo.Parcelas);
                cmd.Parameters.AddWithValue("@repetirnumero", modelo.RepetirNumero);
                cmd.Parameters.AddWithValue("@repetirtempo", modelo.RepetirTempo);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void Excluir(int codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "DELETE FROM transacoes WHERE id_transacao = @codigo";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public ModeloTransacao CarregaModeloTransacao(int codigo)
        {
            ModeloTransacao modelo = new ModeloTransacao();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM transacoes WHERE id_transacao = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IdTransacao = Convert.ToInt32(registro["id_transacao"]);
                modelo.IdSequencia = Convert.ToInt32(registro["id_sequencia"]);
                modelo.Data = Convert.ToDateTime(registro["data"]);
                modelo.Tipo = Convert.ToString(registro["tipo"]);
                modelo.Descricao = Convert.ToString(registro["descricao"]);
                modelo.IdContaOrigem = Convert.ToInt32(registro["id_conta_origem"]);
                modelo.IdContaDestino = Convert.ToInt32(registro["id_conta_destino"]);
                modelo.Valor = Convert.ToDouble(registro["valor"]);
                modelo.Nota = Convert.ToString(registro["nota"]);
                modelo.IdPessoa = Convert.ToInt32(registro["id_pessoa"]);
                modelo.NotaFiscal = Convert.ToString(registro["nota_fiscal"]);
                modelo.Parcelas = Convert.ToInt32(registro["parcelas"]);
                modelo.RepetirNumero = Convert.ToInt32(registro["repetir_numero"]);
                modelo.RepetirTempo = Convert.ToString(registro["repetir_tempo"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
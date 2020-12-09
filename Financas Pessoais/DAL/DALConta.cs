using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALConta
    {
        private DALConexao conexao;

        public DALConta(DALConexao conn)
        {
            this.conexao = conn;
        }

        public void Incluir(ModeloConta modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO contas(id_sequencia, descricao, saldo_inicial, cadastro, ativa) VALUES (@sequencia, @descricao, @saldoinicial, @cadastro, @ativa); SELECT @@IDENTITY;";
                cmd.Parameters.AddWithValue("@sequencia", modelo.IdSequencia);
                cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
                cmd.Parameters.AddWithValue("@saldoinicial", modelo.SaldoInicial);
                cmd.Parameters.AddWithValue("@cadastro", modelo.Cadastro);
                cmd.Parameters.AddWithValue("@ativa", modelo.Ativa);
                conexao.Conectar();
                modelo.IdConta = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void Alterar(ModeloConta modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE contas SET id_sequencia = @sequencia, descricao = @descricao, saldo_inicial = @saldoinicial, cadastro = @cadastro, ativa = @ativa WHERE id_conta = @idconta";
                cmd.Parameters.AddWithValue("@idconta", modelo.IdConta);
                cmd.Parameters.AddWithValue("@sequencia", modelo.IdSequencia);
                cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
                cmd.Parameters.AddWithValue("@saldoinicial", modelo.SaldoInicial);
                cmd.Parameters.AddWithValue("@cadastro", modelo.Cadastro);
                cmd.Parameters.AddWithValue("@ativa", modelo.Ativa);
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
                cmd.CommandText = "DELETE FROM contas WHERE id_conta = @codigo";
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

        public ModeloConta CarregaModeloConta(int codigo)
        {
            ModeloConta modelo = new ModeloConta();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM contas WHERE id_conta = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IdConta = Convert.ToInt32(registro["id_conta"]);
                modelo.IdSequencia = Convert.ToInt32(registro["id_sequencia"]);
                modelo.Descricao = Convert.ToString(registro["descricao"]);
                modelo.SaldoInicial = Convert.ToDouble(registro["saldo_inicial"]);
                modelo.SaldoAtual = Convert.ToDouble(registro["saldo_atual"]);
                modelo.Cadastro = Convert.ToDateTime(registro["cadastro"]);
                modelo.Ativa = Convert.ToString(registro["ativa"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
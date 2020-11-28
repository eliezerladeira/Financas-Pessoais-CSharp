using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPerson
    {
        private DALConexao conexao;

        public DALPerson(DALConexao conn)
        {
            this.conexao = conn;
        }

        public void Incluir(ModeloPessoa modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO pessoas(nome, cpfcnpj, endereco, bairro, cidade, cep, uf, cadastro, telefone, email, nascimento) VALUES (@nome, @cpfcnpj, @endereco, @bairro, @cidade, @cep, @uf, @cadastro, @telefone, @email, @nascimento); SELECT @@IDENTITY;";
                cmd.Parameters.AddWithValue("@nome", modelo.Nome);
                cmd.Parameters.AddWithValue("@cpfcnpj", modelo.CpfCnpj);
                cmd.Parameters.AddWithValue("@endereco", modelo.Endereco);
                cmd.Parameters.AddWithValue("@bairro", modelo.Bairro);
                cmd.Parameters.AddWithValue("@cidade", modelo.Cidade);
                cmd.Parameters.AddWithValue("@cep", modelo.Cep);
                cmd.Parameters.AddWithValue("@uf", modelo.Uf);
                cmd.Parameters.AddWithValue("@cadastro", modelo.Cadastro);
                cmd.Parameters.AddWithValue("@telefone", modelo.Telefone);
                cmd.Parameters.AddWithValue("@email", modelo.Email);
                cmd.Parameters.AddWithValue("@nascimento", modelo.Nascimento);
                conexao.Conectar();
                modelo.IdPessoa = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void Alterar(ModeloPessoa modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE pessoas SET nome = @nome, cpfcnpj = @cpfcnpj, endereco = endereco, bairro = bairro, cidade = cidade, cep = cep, uf = uf, cadastro = cadastro, telefone = telefone, email = email, nascimento = nascimento WHERE id_pessoa = @id";
                cmd.Parameters.AddWithValue("@id", modelo.IdPessoa);
                cmd.Parameters.AddWithValue("@nome", modelo.Nome);
                cmd.Parameters.AddWithValue("@cpfcnpj", modelo.CpfCnpj);
                cmd.Parameters.AddWithValue("@endereco", modelo.Endereco);
                cmd.Parameters.AddWithValue("@bairro", modelo.Bairro);
                cmd.Parameters.AddWithValue("@cidade", modelo.Cidade);
                cmd.Parameters.AddWithValue("@cep", modelo.Cep);
                cmd.Parameters.AddWithValue("@uf", modelo.Uf);
                cmd.Parameters.AddWithValue("@cadastro", modelo.Cadastro);
                cmd.Parameters.AddWithValue("@telefone", modelo.Telefone);
                cmd.Parameters.AddWithValue("@email", modelo.Email);
                cmd.Parameters.AddWithValue("@nascimento", modelo.Nascimento);
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
                cmd.CommandText = "DELETE FROM pessoas WHERE id_pessoa = @codigo";
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

        public ModeloPessoa CarregaModeloPessoa(int codigo)
        {
            ModeloPessoa modelo = new ModeloPessoa();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM pessoas WHERE id_pessoa = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IdPessoa = Convert.ToInt32(registro["id_pessoa"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
                modelo.CpfCnpj = Convert.ToString(registro["cpfcnpj"]);
                modelo.Endereco = Convert.ToString(registro["endereco"]);
                modelo.Bairro = Convert.ToString(registro["bairro"]);
                modelo.Cidade = Convert.ToString(registro["cidade"]);
                modelo.Cep = Convert.ToString(registro["cep"]);
                modelo.Uf = Convert.ToString(registro["uf"]);
                modelo.Cadastro = Convert.ToDateTime(registro["cadastro"]);
                modelo.Telefone = Convert.ToString(registro["telefone"]);
                modelo.Email = Convert.ToString(registro["email"]);
                modelo.Nascimento = Convert.ToDateTime(registro["nascimento"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
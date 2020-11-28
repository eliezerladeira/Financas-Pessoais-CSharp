using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloPessoa
    {
        public ModeloPessoa()
        {
            this.IdPessoa = 0;
            this.Nome = "";
            this.CpfCnpj = "";
            this.Endereco = "";
            this.Bairro = "";
            this.Cidade = "";
            this.Cep = "";
            this.Uf = "";
            this.Cadastro = DateTime.Now;
            this.Telefone = "";
            this.Email = "";
            this.Nascimento = Convert.ToDateTime("");
        }

        public ModeloPessoa(int id, String nome, String cpfcnpj, String endereco, String bairro, String cidade, String cep, String uf, DateTime cadastro, String telefone, String email, DateTime nascimento)
        {
            this.IdPessoa = id;
            this.Nome = nome;
            this.CpfCnpj = cpfcnpj;
            this.Endereco = endereco;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Cep = cep;
            this.Uf = uf;
            this.Cadastro = cadastro;
            this.Telefone = telefone;
            this.Email = email;
            this.Nascimento = nascimento;
        }

        private int _idpessoa;
        private String _nome;
        private String _cpfcnpj;
        private String _endereco;
        private String _bairro;
        private String _cidade;
        private String _cep;
        private String _uf;
        private DateTime _cadastro;
        private String _telefone;
        private String _email;
        private DateTime _nascimento;

        public int IdPessoa
        {
            get { return this._idpessoa; }
            set { this._idpessoa = value; }
        }

        public String Nome
        {
            get { return this._nome; }
            set { this._nome = value; }
        }

        public String CpfCnpj
        {
            get { return this._cpfcnpj; }
            set { this._cpfcnpj = value; }
        }

        public String Endereco
        {
            get { return this._endereco; }
            set { this._endereco = value; }
        }

        public String Bairro
        {
            get { return this._bairro; }
            set { this._bairro = value; }
        }

        public String Cidade
        {
            get { return this._cidade; }
            set { this._cidade = value; }
        }

        public String Cep
        {
            get { return this._cep; }
            set { this._cep = value; }
        }

        public String Uf
        {
            get { return this._uf; }
            set { this._uf = value; }
        }

        public DateTime Cadastro
        {
            get { return this._cadastro; }
            set { this._cadastro = value; }
        }

        public String Telefone
        {
            get { return this._telefone; }
            set { this._telefone = value; }
        }

        public String Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        public DateTime Nascimento
        {
            get { return this._nascimento; }
            set { this._nascimento = value; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCategoria
    {
        public ModeloCategoria()
        {
            this.Categoria = 0;
            this.Descricao = "";
            this.Data = DateTime.Now;
            this.Ativa = "";
        }

        public ModeloCategoria(int categoria, String descricao, DateTime data, String ativa)
        {
            this.Categoria = categoria;
            this.Descricao = descricao;
            this.Data = data;
            this.Ativa = ativa;
        }

        private int _categoria;
        private String _descricao;
        private DateTime _data;
        private String _ativa;

        public int Categoria
        {
            get { return this._categoria; }
            set { this._categoria = value; }
        }

        public String Descricao
        {
            get { return this._descricao; }
            set { this._descricao = value; }
        }

        public DateTime Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        public String Ativa
        {
            get { return this._ativa; }
            set { this._ativa = value; }
        }
    }
}
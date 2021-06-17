using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Tracing;

namespace Aula14
{
    public abstract class Produto : IImprimivel
    {

        protected string _nome;
        protected double _preco;
        protected Fornecedor _fornecedor;

        public double Preco
        {
            get { return this._preco; }
        }

        public string Nome
        {
            get { return this._nome; }
        }

        public Fornecedor fornecedor
        {
            get { return this._fornecedor; }
        }

        public abstract double CalculaValorTotal();
        public abstract void Imprimir();

    }
}
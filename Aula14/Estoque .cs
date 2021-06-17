using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula14;

namespace Aula14
{
    public class Estoque : Carrinho, IImprimivel
    {

        private Dictionary<Produto, int> _produto;
        public Dictionary<Produto, int> Produto
        {
            get
            {
                return this._produto;
            }
        }

        public Estoque()
        {
            this._produto = new Dictionary<Produto, int>();
        }

       

        public void Remover(Produto item, int quantidade)
        {
            if (this._itens.ContainsKey(item))
                this._itens[item] = this._itens[item] - quantidade;
            else
                this._itens[item] = quantidade;
        }

        public void Remover(Produto item)
        {
            this.Adicionar(item, -1);
        }

        public void ValidacaoCompra(Carrinho c)
        {
            bool validacao = true;

            foreach (KeyValuePair<Produto, int> parordenado in c.Itens)
            {
                int quantidade = this.Itens[parordenado.Key];
                if (parordenado.Value > quantidade && validacao == true)
                {
                    Console.WriteLine("Só temos {0} unidades do produto {1} em nosso estoque, por favor atualize a quantidade deste item para um disponível em nosso estoque ", quantidade, parordenado.Key.Nome);
                    validacao = false;
                    break;
                }
            }
            if (validacao == true)
            {
                foreach (KeyValuePair<Produto, int> produtosComprados in c.Itens)
                {
                       
                     this.Remover(produtosComprados.Key, produtosComprados.Value);
                  
                }
                Console.WriteLine("A compra foi concluída com sucesso");
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("======== ESTOQUE ========");
            foreach (KeyValuePair<Produto, int> parOrdenado in this._itens)
            {
                parOrdenado.Key.Imprimir();
                Console.WriteLine("Quantidade:\t{0}", parOrdenado.Value);
                Console.WriteLine("==========================");
            }

            Console.WriteLine("==========================");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula14;

namespace Aula14
{
    public class Compra : Carrinho, IImprimivel
    {


        private Cliente _cliente;
        public Cliente Cliente
        {
            get { return this._cliente; }
        }

        


        public Compra(Cliente clinte, Carrinho car, Estoque est)
        {
            this._itens = new Dictionary<Produto, int>();
            this._cliente = clinte;
            this._itens = car.Itens;

            
            
        }

      /*  public void ValidacaoCompra(Carrinho c, Estoque e)
        {
            bool validacao = true;

            foreach (KeyValuePair<Produto, int> parordenado in c.Itens)
            {
                int quantidade = e.Itens[parordenado.Key];
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
        */
        public void Recibo(Cliente c)
        {
            DateTime HoraVenda = new DateTime();
            Console.WriteLine("Compra realizada por:\t{0}", c.Nome);
            Console.WriteLine("Data da compra:\t{0}", HoraVenda);
        }

        public void Imprimir()
        {
            Console.WriteLine("======== RECIBO ========");
            foreach (KeyValuePair<Produto, int> parOrdenado in this.Itens)
            {
                parOrdenado.Key.Imprimir();
                Console.WriteLine("Quantidade:\t{0}", parOrdenado.Value);
                Console.WriteLine("Subtotal:\tR$ {0:0.00}", parOrdenado.Value * parOrdenado.Key.CalculaValorTotal());
                Console.WriteLine("==========================");
            }
            Console.WriteLine("Total do carrinho:\tR$ {0:0.00}", this.Total);
            Console.WriteLine("==========================");
            Recibo(this.Cliente);
        }

    }    

        
}


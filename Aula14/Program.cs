using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Tracing;

namespace Aula14
{
    class Program
    {
        static void Main(string[] args)
        {
            Estoque estoque = new Estoque();

            Fornecedor forne1 = new Fornecedor("Microsoft", "123456789-10");
            Fornecedor forne2 = new Fornecedor("Apple", "123456789-10");
            Fornecedor forne3 = new Fornecedor("Samsung", "123456789-10");

            Cliente hermenegildo = new Cliente("Hermenegildo Benevides", "123.456.789-10");
            Cliente zoroastra = new Cliente("Zoroastra Muad'dib", "109.876.543-21");

            Licensa rwindols = new Licensa("Michaelsóft Rwildols", 699.90,"SUAA-HE52-W6WG-B8Y9", forne1);
            Assinatura alface123 = new Assinatura("Michaelsóft Alface", 39.90, 12, "5GNX-VM6Y-L6W8-SCPC", forne2);
            Assinatura cottonshopi = new Assinatura("Aldobo Cottonshopi", 89.90, 12, "H84A-8QDF-4XPT-A2WZ", forne3);
            Assinatura premillere = new Assinatura("Aldobo Premillere", 89.90, 12, "RLBD-YTRZ-UPH7-VQGM", forne1);
            Licensa corehul = new Licensa("Corehul Dreus", 2999.90, "XZLT-CXL9-SLHV-99UM", forne2);

            ProdutoFisico mausi = new ProdutoFisico("Mausi Michaelsóft", 89.90, 12.99, forne3);
            ProdutoFisico lepetope = new ProdutoFisico("Lepetope Dehul", 3499.90, 123.45, forne1);

            estoque.Adicionar(rwindols, 5);
            estoque.Adicionar(alface123, 5);
            estoque.Adicionar(cottonshopi, 2);
            estoque.Adicionar(premillere, 3);
            estoque.Adicionar(corehul, 3);
            estoque.Adicionar(mausi, 3);
            estoque.Adicionar(lepetope, 5);
            estoque.Imprimir();

            Carrinho carrinho = new Carrinho();

            carrinho.Adicionar(rwindols, 2);
            carrinho.Adicionar(alface123, 3);
            carrinho.Adicionar(cottonshopi);
            carrinho.Adicionar(premillere);
            carrinho.Adicionar(corehul);
            carrinho.Adicionar(mausi, 3);
            carrinho.Adicionar(lepetope);
            carrinho.Imprimir();

            Compra cp = new Compra(hermenegildo, carrinho, estoque);
            estoque.ValidacaoCompra(carrinho);
            cp.Imprimir();

            

            Relatorio relatorioArtistico = new Relatorio("Relatorio Artístico", "Este relatório apresenta todos os softwares artisticos vendidos na loja.");
            relatorioArtistico.AdicionarItem(cottonshopi);
            relatorioArtistico.AdicionarItem(premillere);
            relatorioArtistico.AdicionarItem(corehul);
            relatorioArtistico.ImprimirRelatorio();

            

            Relatorio relatorioClientes = new Relatorio("Relatório de Clientes", "Este relatório apresenta uma lista de todos os clientes que compraram no mês de abril");
            relatorioClientes.AdicionarItem(hermenegildo);
            relatorioClientes.AdicionarItem(zoroastra);
            relatorioClientes.ImprimirRelatorio();

            Relatorio relatorioFornecedores = new Relatorio("Relatório de Fornecedores", "Este relatório apresenta uma lista de todos as empresas fornecedoras");
            relatorioFornecedores.AdicionarItem(forne1);
            relatorioFornecedores.AdicionarItem(forne2);
            relatorioFornecedores.AdicionarItem(forne3);
            relatorioFornecedores.ImprimirRelatorio();


            Console.ReadLine();


        }
    }
}
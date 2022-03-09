using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tentingzzz2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> itens = new List<Item>(); 

            itens.Add(new Item { index = 0, nomeproduto = "Camisa", Quantidade = 5, valorproduto = 2 });
            itens.Add(new Item { index = 1, nomeproduto = "Calça", Quantidade = 52, valorproduto = 8 });
            int stopLoop = 0;

            do
            {
                stopLoop = 1;
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("Sistema de Gestão de Estoque de Produtos");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("\n\t Menu: ");
                Console.WriteLine("1 - Cadastrar novo produto");
                Console.WriteLine("2 - Adicionar  quantidade de produtos");
                Console.WriteLine("3 - Listar todos os produtos");
                Console.WriteLine("4 - Remover um produto");
                Console.WriteLine("5 - Valor total em estoque de todos os produtos");
                Console.WriteLine("6 - Sair do programa");
                
                int choose = int.Parse(Console.ReadLine());



                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do produto");
                        string nomeProduct = Console.ReadLine();
                        Console.WriteLine("Digite o id do produto:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a quantidade do produto");
                        int quantityProduct = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor do produto");
                        double valueProduct = double.Parse(Console.ReadLine());
                        itens.Add(new Item { index = id, nomeproduto = nomeProduct, Quantidade = quantityProduct, valorproduto = valueProduct });
                        Console.WriteLine("Produto cadastrado com SUCESSO");
                        break;

                    case 2:
                        int founded = 0;
                        Console.WriteLine("Digite o nome do produto que você deseja adicionar ao estoque: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Digite a quantidade do produtos que você deseja:");
                        int quantity = int.Parse(Console.ReadLine());

                        foreach (Item item in itens)
                        {
                            if (item.nomeproduto == name)
                            {
                                founded = 1;
                                Console.WriteLine("Produto encontrado! Nome: " + item.nomeproduto);
                                Console.WriteLine("Quantidade anterior: " + item.Quantidade);
                                item.Quantidade = item.Quantidade + quantity;
                                Console.WriteLine("Quantidade atual: " + item.Quantidade);
                                Console.WriteLine("Quantidade de produtos atualizada com sucesso!");

                            };
                        }
                        if (founded == 0)
                        {
                            Console.WriteLine("Produto não encontrado");
                        }
                        break;


                    case 3:
                        Console.WriteLine("Listagem de Produtos: \n");
                        foreach (Item item in itens)
                        {
                            

                            Console.WriteLine(item.ToString());
                            

                        }

                        break;

                    case 4:
                        Console.WriteLine("Digite o identificador do produto que irá ser apagado ");
                        int productRemoved = int.Parse(Console.ReadLine());
                        itens.RemoveAt(productRemoved);
                        break;


                    case 5:
                        Console.WriteLine("Valor total do estoque: ");
                        double valorEstoqueTotal = 0;
                        foreach (Item item in itens)
                        {
                            valorEstoqueTotal += item.Total();
                        }
                        Console.WriteLine("Valor total do estoque: " + valorEstoqueTotal);
                        break;



                    case 6:
                        stopLoop = 0;
                        break;

                }







            } while (stopLoop != 0);
        }
    }
}

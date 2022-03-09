using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tentingzzz2
{
    public class Item
    {
                public int index { get; set; }

        public String nomeproduto { get; set; }

        public String tipoProduto { get; set; }

        public double valorproduto { get; set; }

        public int Quantidade { get; set; }



        public double Total()
        {
            return valorproduto * Quantidade;
        }

        public String TipoProduto()
        {
            Console.WriteLine("Insira o tipo do produto");
            String value = Console.ReadLine();

            return value;
        }



        public override String ToString()
        {
            return "Produto: " + nomeproduto + "\nId: " + index +" \nValor: R$" + 
            valorproduto.ToString("F2", CultureInfo.InvariantCulture)
                + "\n" + Quantidade + " unidades \nTotal: R$" + Total().ToString("F2", CultureInfo.InvariantCulture)+"\n";
        }

    }
}
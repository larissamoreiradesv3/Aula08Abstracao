using System;

namespace Aula08Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito visa = new CartaoCredito();
            visa.limite = 3000f;
            Console.WriteLine("Quanto você deseja acrescentar de limite?");
            float acrescimo = float.Parse(Console.ReadLine());
            
            visa.AumentoLimite(acrescimo);
            Console.WriteLine("Seu novo limite é de: R$" +visa.limite);

            //System antes de console é pelo uso do DateTime
            //O parse após um comando serve para permitir o uso/leitura dele no ReadLine
            System.Console.WriteLine("Digite a data de Pagamento:");
            visa.data = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine("Data definida:" +visa.data);


        }
    }
}

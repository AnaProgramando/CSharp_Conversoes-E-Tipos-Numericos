using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 1270.50;
            int valor = (int)salario;            
            Console.WriteLine("O salário R$ 1270.50 convertido de double para int é igual a R$ " + valor + ". \r\n");
            // Basicamente, para as variáveis primitivas, o casting nada mais é do que fazer com que essa conversão seja feita quando ela não ocorre de maneira automática, por isso coloquei o (int), assim converti o double em int para que o programa seja compilado.

            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;
            Console.WriteLine("A soma dos doubles 0.2 e 0.1 é " + total + ". \r\n");


            // Não é possível declarar [float pontoFlutuante = 3.14], pois para o C#, 3.14 é um double, e a mesma ocorreria ao guardar um double dentro de um int. No tipo double podemos armazenar 64 bits, no float e no int apenas 32 bits, o que pode acarretar em perda de informação.

            float pontoFlutuante = 3.14f;
            // Para que esse código funcionasse, informei ao C# que o valor 3.14 é um float, para isso coloquei f ao final do número

            Console.WriteLine("O programa foi executado! \r\n Clique no enter para sair.");
            Console.ReadLine();
        }
    }
}

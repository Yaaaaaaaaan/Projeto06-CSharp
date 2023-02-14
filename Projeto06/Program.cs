using System;
using System.Globalization;

namespace Projeto06
{
    internal class Program
    {
        static void Main(string[] args){
            Funcionario f = new Funcionario();
            Console.WriteLine("Insira o nome; ");
            f.Nome = Console.ReadLine();
            Console.WriteLine("Salário Bruto; ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Imposto; ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário; " + f);

            Console.WriteLine();
            Console.WriteLine("Porcentagem de aumento de salário; ");
            double Porcento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(Porcento);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados; " + f);

            Console.WriteLine("aperte qualquer botão para encerrar.");
            Console.ReadLine();
        }
    }
}

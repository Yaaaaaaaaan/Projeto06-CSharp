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

        }
    }
}

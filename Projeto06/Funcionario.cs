using System;

namespace Projeto06
{
    internal class Funcionario
    {
        public string nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido(){
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double Porcentagem){
            SalarioBruto += (SalarioBruto * Porcentagem / 100.0); 
        }
    }
}

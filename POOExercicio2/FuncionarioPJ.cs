using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOExercicio2
{
    public class FuncionarioPJ : Funcionario
    {
        private int HorasTrabalhadas;
        private double ValorHora;

        public override double CalcularSalarioFinal()
        {
            return this.getSalarioBase() + (this.HorasTrabalhadas * this.ValorHora);
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Horas trabalhadas: {this.HorasTrabalhadas}");
            Console.WriteLine($"Valor hora:  {this.ValorHora}");
            Console.WriteLine($"Salário total: {this.CalcularSalarioFinal()}");
        }

        public void setHorasTrabalhadas(int HorasTrabalhadas)
        {
            this.HorasTrabalhadas = HorasTrabalhadas;
        }

        public int getHorasTrabalhadas()
        {
            return this.HorasTrabalhadas;
        }

        public void setValorHora(double ValorHora)
        {
            this.ValorHora = ValorHora;
        }

        public double getValorHora()
        {
            return this.ValorHora;
        }
    }
}
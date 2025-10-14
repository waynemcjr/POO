using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOExercicio2
{
    public class FuncionarioCLT : Funcionario
    {
        private double Bonus;

        public override double CalcularSalarioFinal()
        {
            return this.getSalarioBase() + this.Bonus;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo(); // "base" acessa a classe base
            Console.WriteLine($"Bônus : {this.Bonus}");
            Console.WriteLine($"Salário total: {this.CalcularSalarioFinal()}");
        }

        public void setBonus(double Bonus)
        {
            this.Bonus = Bonus;
        }

        public double getBonus()
        {
            return this.Bonus;
        }
    }
}
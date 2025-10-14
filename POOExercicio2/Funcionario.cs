using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOExercicio2
{
    public abstract class Funcionario
    {
        private string Nome = string.Empty;
        private double SalarioBase;

        public virtual void ExibirInfo()
        {
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Salário base: {this.SalarioBase}");
        }

        public abstract double CalcularSalarioFinal();

        public void setNome(string Nome)
        {
            this.Nome = Nome;
        }

        public string getNome()
        {
            return this.Nome;

        }

        public void setSalarioBase(double SalarioBase)
        {
            this.SalarioBase = SalarioBase;
        }

        public double getSalarioBase()
        {
            return this.SalarioBase;
        }
    }
}
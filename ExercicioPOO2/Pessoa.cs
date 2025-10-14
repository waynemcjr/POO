using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO2
{
    internal class Pessoa
    {
        public int Idade;
        public string Nome;
        public string Sobrenome;
        public string Sexo;
        public double Altura;
        public Endereco Endereco {get; set;}

        public void setIdade(int Idade)
        {
            this.Idade = Idade;
        }

        public int getIdade()
        {
            return this.Idade;
        }

        public void setNome(string Nome)
        {
            this.Nome = Nome;
        }

        public string getNome()
        {
            return this.Nome;
        }

        public void setSobrenome(string Sobrenome)
        {
            this.Sobrenome = Sobrenome;
        }

        public string getSobrenome()
        {
            return this.Sobrenome;
        }

        public void setSexo(string Sexo)
        {
            this.Sexo = Sexo;
        }

        public string getSexo()
        {
            return this.Sexo;
        }

        public void setAltura(double Altura)
        {
            this.Altura = Altura;
        }

        public double getAltura()
        {
            return this.Altura;
        }

        public Pessoa() // atalho - ctor tab
        {
            
        }

        public void ExibirPessoa()
        {
            Console.WriteLine($"Idade: {this.Idade}");
            Console.WriteLine($"Nome e Sobrenome: {this.Nome} {this.Sobrenome}");
            //Console.WriteLine(this.Sobrenome);
            Console.WriteLine($"Sexo: {this.Sexo}");
            Console.WriteLine($"Altura: {this.Altura}");
        }
    }
}

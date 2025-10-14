using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Pessoa
    {
        public int Idade;
        public string Nome;
        public string Cpf;
        public double Altura;

        public Pessoa() // método construtor da classe (não necessario)
        {

        }

        public void setIdade(int idade)
        {
            this.Idade = idade;
        }

        public int getIdade()
        {
            return this.Idade;
        }

        public void setAltura(double altura)
        {
            this.Altura = altura;
        }

        public double getAltura()
        {
            return this.Altura;
        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }

        public string getNome()
        {
            return this.Nome;
        }

        public void setCpf(string cpf)
        {
            this.Cpf = cpf;
        }

        public string getCpf()
        {
            return this.Cpf;
        }
    }
}

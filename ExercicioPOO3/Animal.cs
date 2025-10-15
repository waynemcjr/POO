using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO3
{
    public class Animal
    {
        private string Nome = string.Empty;
        private int Idade;

        public virtual void EmitirSom()
        {
            Console.WriteLine("Som");
        }

        public void setNome(string Nome)
        {
            this.Nome = Nome;
        }

        public string getNome()
        {
            return this.Nome;
        }

        public void setIdade(int Idade)
        {
            this.Idade = Idade;
        }

        public int getIdade()
        {
            return this.Idade;
        }
    }
}

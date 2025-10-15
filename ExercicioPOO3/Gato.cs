using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO3
{
    public class Gato : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Miau!");
        }

        public Gato(string nome, int idade) : base(nome, idade) { }

    }
}

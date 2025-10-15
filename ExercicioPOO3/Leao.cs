using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO3
{
    public class Leao : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Rarw!");
        }

        public Leao(string nome, int idade) : base(nome, idade) { }
    }
}

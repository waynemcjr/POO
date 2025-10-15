using ExercicioPOO3;

Animal[] animais = new Animal[3];

Animal cachorro = new Cachorro("Willy", 10);
Animal gato = new Gato("Garfield", 7);
Animal leao = new Leao("Simba", 3);

//gato.setNome("Garfield");
//gato.setIdade(7);

//cachorro.setNome("Willy");
//cachorro.setIdade(10);

//leao.setNome("Simba");
//leao.setIdade(3);

animais[0] = cachorro;
animais[1] = gato;
animais[2] = leao;

for (int i = 0; i<animais.Length; i++)
{
    Console.WriteLine();
    Console.WriteLine(animais[i].ToString());
    animais[i].EmitirSom();
}
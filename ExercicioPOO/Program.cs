
using ExercicioPOO;

Pessoa[] pessoas = new Pessoa[3];

//Pessoa pessoa1 = new Pessoa();

//pessoa1.setIdade(45);
//pessoa1.setNome("João");
//pessoa1.setSobrenome("Carlos");
//pessoa1.setSexo("Masculino");
//pessoa1.setAltura(1.80);

//Pessoa pessoa2 = new Pessoa();

//pessoa2.setIdade(20);
//pessoa2.setNome("Maria");
//pessoa2.setSobrenome("Clara");
//pessoa2.setSexo("Femnino");
//pessoa2.setAltura(1.60);

//Pessoa pessoa3 = new Pessoa();

//pessoa3.setIdade(25);
//pessoa3.setNome("Alex");
//pessoa3.setSobrenome("Oliveira");
//pessoa3.setSexo("Outro");
//pessoa3.setAltura(1.70);

//pessoas[0] = pessoa1;
//pessoas[1] = pessoa2;
//pessoas[2] = pessoa3;

//pessoa1.ExibirPessoa();

for (int i = 0; i < pessoas.Length; i++)
{

    if (i > 0) { Console.WriteLine(); }

    pessoas[i] = new Pessoa();

    Console.Write($"Informe o nome da {i + 1}° pessoa: ");
    pessoas[i].setNome(Console.ReadLine()!);

    Console.Write($"Informe o sobrenome da {i + 1}° pessoa: ");
    pessoas[i].setSobrenome(Console.ReadLine()!);

    Console.Write($"Informe o idade da {i + 1}° pessoa: ");
    pessoas[i].setIdade(Convert.ToInt32(Console.ReadLine()));

    Console.Write($"Informe o sexo da {i + 1}° pessoa: ");
    pessoas[i].setSexo(Console.ReadLine()!);

    Console.Write($"Informe o altura da {i + 1}° pessoa: ");
    pessoas[i].setAltura(Convert.ToDouble(Console.ReadLine()));

}

Console.WriteLine();

for (int i = 0; i < pessoas.Length; i++)
{
    pessoas[i].ExibirPessoa();
    Console.WriteLine();
}
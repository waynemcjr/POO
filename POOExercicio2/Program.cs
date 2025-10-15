using Microsoft.VisualBasic;
using POOExercicio2;

Console.Write("Informe quantos funcionarios quer cadastrar: ");
int qtdFuncionarios = int.Parse(Console.ReadLine()!);
int tipo;

Funcionario[] funcionarios = new Funcionario[qtdFuncionarios];

for (int i = 0; i < funcionarios.Length; i++)
{
    do
    {
        Console.Write("\nInforme o tipo de funcionario (1 - CLT ou 2 PJ): ");
        tipo = Convert.ToInt32(Console.ReadLine()!);

        if (tipo == 1)
        {
            funcionarios[i] = new FuncionarioCLT();

            Console.Write("Informe o nome: ");
            funcionarios[i].setNome(Console.ReadLine()!);

            Console.Write("Informe o salário base: ");
            funcionarios[i].setSalarioBase(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Informe o bônus: ");
            ((FuncionarioCLT)funcionarios[i]).setBonus(Convert.ToDouble(Console.ReadLine()));
        }
        else if (tipo == 2)
        {
            funcionarios[i] = new FuncionarioPJ();

            Console.Write("Informe o nome: ");
            funcionarios[i].setNome(Console.ReadLine()!);

            Console.Write("Informe o salário base: ");
            ((FuncionarioPJ)funcionarios[i]).setSalarioBase(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Informe as horas trabalhadas: ");
            ((FuncionarioPJ)funcionarios[i]).setHorasTrabalhadas(Convert.ToInt32(Console.ReadLine()));

            Console.Write("Informe o valor da hora: ");
            ((FuncionarioPJ)funcionarios[i]).setValorHora(Convert.ToDouble(Console.ReadLine()));
        }
        else
        {
            Console.WriteLine("Informe um número válido (1 ou 2)!");
        }
    } while (tipo != 1 && tipo != 2);
}

Console.WriteLine();

for (int i = 0; i < funcionarios.Length; i++)
{
    Console.WriteLine();
    funcionarios[i].ExibirInfo();
}
Console.WriteLine("Descrição do Projeto");
Console.WriteLine("Vamos criar um programa que gerencie uma **lista de notas de alunos** e calcule a média. O usuário poderá:\r\n");
Console.WriteLine("1.Inserir as notas de um aluno. (Cada aluno tem 5 notas)\r\n");
Console.WriteLine("2. Exibir as notas e calcular a média.\r\n");
Console.WriteLine("3. Verificar se o aluno foi aprovado ou reprovado (média >= 7 para aprovação).");
Console.WriteLine();

int[] notas = new int[5];
double soma = 0;

try
{
    for (int i = 0; i < notas.Length; i++)
    {
        Console.WriteLine($"Digite sua nota número {i + 1}.");
        notas[i] = int.Parse(Console.ReadLine());
        if (notas[i] < 0 || notas[i] > 10)
        {
            throw new ArgumentException();
        }
        else
        {
            soma = soma + notas[i];
        }
    }
    Console.WriteLine();

    for (int i = 0; i < notas.Length; i++)
    {
        Console.WriteLine($"Sua nota número {i + 1}ª foi {notas[i]}.");
    }
    Console.WriteLine();
    Console.WriteLine($"Sua media foi {soma / 5}.");

    Console.WriteLine();
    double media = soma / 5.0;

    if (media >= 7)
    {
        Console.WriteLine("Voce foi aprovado!!");
    }
    else
    {
        Console.WriteLine("Voce foi reprovado!!");

    }
}
catch (FormatException ex)
{
    Console.WriteLine("Erro: O tipo valor informado é inválido.");
}
catch (OverflowException ex)
{
    Console.WriteLine("Erro: O valor informado excede o limite de tamanho.");
}
catch (ArgumentException ex)
{
    Console.WriteLine("Erro: O valor informado não pode ser negativo ou acima de 10.");
}
Console.WriteLine();

Console.WriteLine("=== Gerenciador de Notas ===\r\n");
Console.WriteLine("1. Adicionar aluno\r\n");
Console.WriteLine("2. Listar alunos\r\n");
Console.WriteLine("3. Estatísticas\r\n");
Console.WriteLine("4. Sair\r\n");
Console.WriteLine();


Console.WriteLine("Escolha uma opção:");
Console.WriteLine();
//int escolha = int.Parse(Console.ReadLine());
//if (escolha < 1 || escolha > 4)
//{
//    throw new ArgumentException();
//}
//else
//{
//    if (escolha == 1)
//    {
        
//    }
//}
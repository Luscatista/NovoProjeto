Console.WriteLine("Descrição do Projeto");
Console.WriteLine("Vamos criar um programa que gerencie uma **lista de notas de alunos** e calcule a média. O usuário poderá:\r\n");
Console.WriteLine("1.Inserir as notas de um aluno. (Cada aluno tem 5 notas)\r\n");
Console.WriteLine("2. Exibir as notas e calcular a média.\r\n");
Console.WriteLine("3. Verificar se o aluno foi aprovado ou reprovado (média >= 7 para aprovação).");
Console.WriteLine();
Console.WriteLine("Extras：\r\n");
Console.WriteLine("1. Melhor tratamento de erros:\r\n");
Console.WriteLine("Use try/catch para evitar erros de entrada inválida. (Dica: Lembre - se do FormatException e ArgumentOutOfRangeException para notas acima de 10 ou menores que 0)\r\n");
Console.WriteLine("2. Menu interativo:\r\n");
Console.WriteLine("Adicione opções para cadastrar, listar alunos e sair.\r\n");
Console.WriteLine("💡 Dica:  Utilize um laço de repetição\r\n");
Console.WriteLine("Exemplo de Saída: \r\n");
Console.WriteLine("=== Gerenciador de Notas ===\r\n");
Console.WriteLine("1. Cadastrar notas\r\n");
Console.WriteLine("2. Listar notas\r\n");
Console.WriteLine("3. Estatísticas\r\n");
Console.WriteLine("4. Sair\r\n");
Console.WriteLine("Escolha uma opção:\r\n");
Console.WriteLine();

int[] vetorNotas = new int[5];
int escolha = 0;
double media = 0;
double soma = 0;

try
{
    do
    {

        Console.WriteLine("=== Gerenciador de Notas ===");
        Console.WriteLine("1. Cadastrar notas");
        Console.WriteLine("2. Listar notas");
        Console.WriteLine("3. Estatísticas");
        Console.WriteLine("4. Sair");
        Console.WriteLine();


        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine();

        escolha = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (escolha == 4)
        {
            break;
        }
        if (escolha < 1 || escolha > 3)
        {
            Console.WriteLine("A escolha escolha deve estar entre 1 e 4.");
        }
        else
        {
            if (escolha == 1)
            {
                for (int i = 0; i < vetorNotas.Length; i++)
                {
                    Console.WriteLine($"Digite sua nota número {i + 1}.");
                    vetorNotas[i] = int.Parse(Console.ReadLine());
                    if (vetorNotas[i] < 0 || vetorNotas[i] > 10)
                    {
                        throw new ArgumentException();
                    }
                    else
                    {
                        soma = soma + vetorNotas[i];
                    }
                }
                media = soma / 5;
            }
            else if (escolha == 2)
            {
                Console.WriteLine("As notas são: ");
                for (int i = 0; i < vetorNotas.Length; i++)
                {
                    Console.WriteLine($"Sua nota número {i + 1}º foi: {vetorNotas[i]}");
                }
            }
            else if (escolha == 3)
            {
                Console.WriteLine($"Sua média foi igual a {media}.");
                Console.WriteLine();
                if (media >= 7)
                {
                    Console.WriteLine("Voce foi aprovado!!");
                }
                else
                {
                    Console.WriteLine("Voce foi reprovado!!");

                }
            }
        }
        Console.WriteLine();
    } while (escolha != 1 || escolha != 2 || escolha != 3);

    Console.WriteLine();
    Console.WriteLine("Programa finalizado!");
}
catch (FormatException)
{
    Console.WriteLine("Erro: O tipo valor informado é inválido.");
}
catch (OverflowException)
{
    Console.WriteLine("Erro: O valor informado excede o limite de tamanho.");
}
catch (ArgumentException)
{
    Console.WriteLine("Erro: O valor informado não pode ser negativo ou acima de 10.");
}
Console.WriteLine();

Console.WriteLine("Descrição do Projeto");
Console.WriteLine("Vamos criar um programa que gerencie uma **lista de notas de alunos** e calcule a média. O usuário poderá:\r\n");
Console.WriteLine("1.Inserir as notas de um aluno. (Cada aluno tem 5 notas)\r\n");
Console.WriteLine("2. Exibir as notas e calcular a média.\r\n");
Console.WriteLine("3. Verificar se o aluno foi aprovado ou reprovado (média >= 7 para aprovação).");
Console.WriteLine();

int[] notas = new int[5];
int soma = 0;

for(int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"Digite sua nota numero {i + 1}.");
    notas[i] = int.Parse(Console.ReadLine());
    soma = soma + notas[i];
}
Console.WriteLine();

for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"Sua nota numero {i + 1} foi {notas[i]}.");
}
Console.WriteLine();
Console.WriteLine($"Sua media foi {soma / 5}.");

Console.WriteLine();
int media = soma / 5;

if (media >= 7)
{
    Console.WriteLine("Voce foi aprovado!!");
}
else
{
    Console.WriteLine("Voce foi reprovado!!");

}





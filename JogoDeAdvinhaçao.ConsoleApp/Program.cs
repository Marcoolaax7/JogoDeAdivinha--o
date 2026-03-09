

// Objetivos / Passo-a-passo
// 1. Nosso jogo deve aceitar o input do jogador e exibir o valor digitado.
// 2. Nosso jogo deve gerar um numero secreto aleatório.
// 3. Nosso jogo deve validar a tentativa do jogador e exibir uma mensagem.

using System.Security.Cryptography;



while (true == true)
{
    Console.Clear();

Console.WriteLine("---------------------------");
Console.WriteLine("Jogo de Advinhação!");
Console.WriteLine("---------------------------");

int numeroAleatorio = RandomNumberGenerator.GetInt32(1,21);

Console.Write("Digite um número entre 1 e 20: ");
int numeroEscolhido = Convert.ToInt32(Console.ReadLine());


if (numeroAleatorio == numeroEscolhido)
{
    Console.WriteLine("---------------------------");
    Console.WriteLine("Parabens voce acertou!");
    Console.WriteLine("---------------------------");
    
}
else if (numeroAleatorio > numeroEscolhido)
{
    Console.WriteLine("---------------------------");
    Console.WriteLine("O número digitado é maior que o número secreto!.");
    Console.WriteLine("---------------------------");
}

else 
{
    Console.WriteLine("---------------------------");
    Console.WriteLine("O número digitado é menor que o número secreto!.");
    Console.WriteLine("---------------------------");
}
Console.WriteLine("Deseja continuar? (s/n): ");
string? opcaoContinuar = Console.ReadLine();

if (opcaoContinuar.ToUpper() != "s" )
    {
        break;
    }
  Console.ReadLine();

}




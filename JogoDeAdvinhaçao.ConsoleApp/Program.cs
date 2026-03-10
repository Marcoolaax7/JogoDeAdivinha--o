

// Objetivos / Passo-a-passo
// 1. Nosso jogo deve aceitar o input do jogador e exibir o valor digitado.
// 2. Nosso jogo deve gerar um numero secreto aleatório.
// 3. Nosso jogo deve validar a tentativa do jogador e exibir uma mensagem.

//v2 
// 1. Nosso jogo deve implentr a dificuldade e tentativas ilimitadas 



using System.Security.Cryptography;

while (true == true)
{
    int[] numerosDigitados = new int[100];
    int contadorNumerosDigitados = 0;
    int pontuacao = 1000;

    Console.Clear();
    Console.WriteLine("-------------------------------");
    Console.WriteLine("Jogo de Advinhação!");
    Console.WriteLine("-------------------------------");
    Console.WriteLine("Escolha o nivel de dificuldade:");
    Console.WriteLine("-------------------------------");
    Console.WriteLine("1 - Fácil (10 tentativas)");
    Console.WriteLine("2 - Médio (5) tentativas)");
    Console.WriteLine("3 - Dificil (3 tentativas)");
    Console.WriteLine("-------------------------------");
    Console.Write("Digite sua escolha: ");

    string? dificuldade = Console.ReadLine();

    int numeroMaximo;
    int tentativasMaximas;

    switch (dificuldade)
    {
        case "1":
            numeroMaximo = 20;
            tentativasMaximas = 10;
            break;

        case "2":
            numeroMaximo = 50;
            tentativasMaximas = 5;
            break;

        case "3":
            numeroMaximo = 100;
            tentativasMaximas = 3;
            break;

        default:
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Por favor, selecione uma dificuldade válida.");
            Console.Write("Digite ENTER para continuar...");
            Console.ReadLine();
            continue;
    }

    int numeroAleatorio = RandomNumberGenerator.GetInt32(1, numeroMaximo + 1);

    for (int tentativa = 1; tentativa <= tentativasMaximas; tentativa++)
    {
        Console.Clear();
        Console.WriteLine("---------------------------");
        Console.WriteLine($"Tentativa {tentativa} de {tentativasMaximas}.");
        Console.WriteLine("---------------------------");
        Console.Write($"Digite um número entre 1 e {numeroMaximo}: ");

        int numeroEscolhido = Convert.ToInt32(Console.ReadLine());

        bool numeroEstaRepetido = false;

        for (int contadorNumeros = 0; contadorNumeros < contadorNumerosDigitados; contadorNumeros++)
        {
            if (numerosDigitados[contadorNumeros] == numeroEscolhido)
            {
                numeroEstaRepetido = true;
                break;
            }
        }

        if (numeroEstaRepetido == true)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Voce ja digitou esse número, Tente novamente!!");
            Console.WriteLine("---------------------------");
            Console.Write("Digite ENTER para continuar...");
            Console.ReadLine();
            tentativa--;
            continue;
        }

        if (contadorNumerosDigitados < numerosDigitados.Length)
        {
            numerosDigitados[contadorNumerosDigitados] = numeroEscolhido;
            contadorNumerosDigitados++;
        }

        if (numeroAleatorio == numeroEscolhido)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Parabens voce acertou!");
            Console.WriteLine("---------------------------");
            break;
        }
        else if (numeroAleatorio > numeroEscolhido)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("O número digitado é menor que o número secreto!");
            Console.WriteLine("---------------------------");
        }
        else
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("O número digitado é maior que o número secreto!");
            Console.WriteLine("---------------------------");
        }

        int diferencaNumerica = Math.Abs(numeroAleatorio - numeroEscolhido);

       if (diferencaNumerica >= 10)
        {
            pontuacao -= 100;
        }

       else if (diferencaNumerica >= 5) 
        {
            pontuacao -= 50;
        }
        else
        {
            pontuacao -= 20;
        }

         Console.WriteLine("Sua pontuacao é: " + pontuacao);
            Console.WriteLine("---------------------------");
            Console.Write("Digite ENTER para continuar...");
            Console.ReadLine();

        if (tentativa == tentativasMaximas)
        {
            Console.WriteLine($"Voce usou todas as tentativas! O número era {numeroAleatorio}");
            Console.WriteLine("---------------------------");
            break;
        }

        Console.WriteLine("Sua pontuacao final é: " + pontuacao);
            Console.WriteLine("---------------------------");
            
        
    }

    Console.WriteLine("Deseja continuar? (s/n): ");
    string? opcaoContinuar = Console.ReadLine();

    if (opcaoContinuar?.ToUpper() != "S")
    {
        break;
    }

    Console.ReadLine();
}




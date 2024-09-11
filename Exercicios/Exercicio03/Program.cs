using System;

public class Person
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public int Level { get; set; } = 1;
    public string Class { get; set; } = "";
    public int InitialHealth { get; set; }
    public int InitialDamage { get; set; }
}

class Program
{
    static void Main()
    {
        Person player = new Person();

        Console.WriteLine("Digite o nome do seu personagem:");
        player.Name = Console.ReadLine()!;
        Console.WriteLine($"Olá, {player.Name}!");

        Console.WriteLine("Digite sua idade:");
        player.Age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("------------------------------------");
        Console.WriteLine("Suas informações");
        Console.WriteLine($"Nome: {player.Name}");
        Console.WriteLine($"Idade: {player.Age}");
        Console.WriteLine($"Level: {player.Level}");

        Console.WriteLine("------------------------------------");
        Console.WriteLine("Você está pronto para começar?");
        Console.WriteLine("1 - Sim");
        Console.WriteLine("2 - Não");
        string? resposta = Console.ReadLine();

        if (resposta == "1")
        {
            Console.WriteLine("Ótimo, vamos começar");
            StartGame(player);
        }
        else if (resposta == "2")
        {
            Console.WriteLine("Que pena, esperamos para quando estiver pronto");
        }
        else
        {
            Console.WriteLine("Resposta inválida. Por favor responda com '1' ou '2'.");
        }
    }

    static void StartGame(Person player)
    {
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Escolha um estilo de personagem:");
        Console.WriteLine("1 - Mago: | 10 vida inicial | 7 dano inicial");
        Console.WriteLine("2 - Arqueiro: | 7 vida inicial | 8 dano inicial");
        Console.WriteLine("3 - Cavaleiro: | 13 vida inicial | 6 dano inicial");

        string? escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                player.Class = "Mago";
                player.InitialHealth = 10;
                player.InitialDamage = 7;
                break;
            case "2":
                player.Class = "Arqueiro";
                player.InitialHealth = 7;
                player.InitialDamage = 8;
                break;
            case "3":
                player.Class = "Cavaleiro";
                player.InitialHealth = 13;
                player.InitialDamage = 6;
                break;
            default:
                Console.WriteLine("Escolha inválida. Por favor selecione 1, 2 ou 3.");
                return; // Interrompe o método se a escolha for inválida
        }

        Console.WriteLine("------------------------------------");
        Console.WriteLine($"Classe escolhida: {player.Class}");
        Console.WriteLine($"Vida inicial: {player.InitialHealth}");
        Console.WriteLine($"Dano inicial: {player.InitialDamage}");
        Console.WriteLine("------------------------------------");
    }
}

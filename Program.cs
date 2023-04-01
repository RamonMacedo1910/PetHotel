// See https://aka.ms/new-console-template for more information
Console.WriteLine("***Coloque os dados do seu pet abaixo:***");
        
        Console.WriteLine();

Console.WriteLine("Qual a espécie do seu pet? ");
        string especie = Console.ReadLine()!;

                Console.WriteLine();

Console.WriteLine("Qual a Raça do seu pet? ");
        string raca = Console.ReadLine()!;

                Console.WriteLine();

Console.WriteLine("Qual o nome do seu pet? ");
        string nome = Console.ReadLine()!;

                Console.WriteLine();

Console.WriteLine("Qual a idade do seu pet? ");
        string idade = Console.ReadLine()!;

                Console.WriteLine();

Console.WriteLine("Qual a pelage/cor do seu pet? ");
        string cor = Console.ReadLine()!;

                Console.WriteLine();

Console.WriteLine($"+=========================================================+");
Console.WriteLine($"|                  Pet Hotel Floresta                     |");
Console.WriteLine($"+=========================================================+");
Console.WriteLine($"| Espécie:{especie.PadLeft(16, '.')} | Raça:{raca.PadLeft(24, '.')}|");
Console.WriteLine($"+=========================================================+");
Console.WriteLine($"| Atende pela alcunha de:{nome.PadLeft(33, '.')}|");
Console.WriteLine($"| Idade: {idade.PadLeft(17, '.')} | Pelagem/cor: {cor.PadLeft(16, '.')}|");
Console.WriteLine($"+=========================================================+");
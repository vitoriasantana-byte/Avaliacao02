int voto, a = 0, b = 0, c = 0, nulos = 0;

do
{
    Console.WriteLine("\nDigite seu voto:");
    Console.WriteLine("1 - Candidato A");
    Console.WriteLine("2 - Candidato B");
    Console.WriteLine("3 - Candidato C");
    Console.WriteLine("9 - Voto Nulo");
    Console.WriteLine("0 - Encerrar votação");
    voto = int.Parse(Console.ReadLine());

    switch (voto)
    {
        case 1: a++; break;
        case 2: b++; break;
        case 3: c++; break;
        case 9: nulos++; break;
        case 0: break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

} while (voto != 0);

Console.WriteLine("\nRESULTADO FINAL:");
Console.WriteLine($"Candidato A: {a}");
Console.WriteLine($"Candidato B: {b}");
Console.WriteLine($"Candidato C: {c}");
Console.WriteLine($"Votos Nulos: {nulos}");
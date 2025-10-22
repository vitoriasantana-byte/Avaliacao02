double n1, n2, n3, p1, p2, p3, media;

Console.Write("Nota 1: ");
n1 = double.Parse(Console.ReadLine());
Console.Write("Peso 1: ");
p1 = double.Parse(Console.ReadLine());

Console.Write("Nota 2: ");
n2 = double.Parse(Console.ReadLine());
Console.Write("Peso 2: ");
p2 = double.Parse(Console.ReadLine());

Console.Write("Nota 3: ");
n3 = double.Parse(Console.ReadLine());
Console.Write("Peso 3: ");
p3 = double.Parse(Console.ReadLine());

media = (n1 * p1 + n2 * p2 + n3 * p3) / (p1 + p2 + p3);

Console.WriteLine($"\nMédia Ponderada: {media:F2}");

if (media >= 7)
    Console.WriteLine("Aprovado");
else if (media >= 5)
    Console.WriteLine("Recuperação");
else
    Console.WriteLine("Reprovado");

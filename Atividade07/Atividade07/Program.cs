int start, end;

Console.Write("Número inicial: "); 
while (!int.TryParse(Console.ReadLine(), out start)) //início do while início
    Console.Write("Entrada inválida. Digite um número inteiro para o inicial: ");

Console.Write("Número final: ");
while (!int.TryParse(Console.ReadLine(), out end))
    Console.Write("Entrada inválida. Digite um número inteiro para o final: ");  //fim

// Se o usuário digitou start > end, vai inverte pra evitar loop vazio
if (start > end)
{
    int tmp = start;
    start = end;
    end = tmp;
}

for (int i = start; i <= end; i++)
{
    Console.WriteLine($"\nTabuada do {i}:");
    for (int j = 1; j <= 10; j++)
        Console.WriteLine($"{i} x {j} = {i * j}");
}

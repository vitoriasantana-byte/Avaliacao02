string[] nomes = { "Ana", "Bruno", "Carlos", "Daniela", "Eduardo" };
Console.Write("Digite um nome para procurar: ");
string nomeBusca = Console.ReadLine();
bool achou = false;
for (int i = 0; i < nomes.Length; i++)
{
    if (nomes[i].ToLower() == nomeBusca.ToLower())
    {
        achou = true;
        break;
    }
}
if (achou == true)
{
    Console.WriteLine("O nome " + nomeBusca + " foi encontrado no vetor.");
}
else
{
    Console.WriteLine("O nome " + nomeBusca + " não está no vetor.");
}
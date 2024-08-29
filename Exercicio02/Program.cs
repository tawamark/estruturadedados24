int[] pares = new int[50];
int[] impares = new int[50];

int contpar = 0;
int contimpar = 0;

for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        pares[contpar] = i;
        contpar++;
    }
    else
    {
        impares[contimpar] = i;
        contimpar++;
    }
}

foreach (int np in pares)
{
    Console.WriteLine(np);
}

Console.WriteLine("----------------------------");

foreach (int ni in impares)
{
    Console.WriteLine(ni);
}
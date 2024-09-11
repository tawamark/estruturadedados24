int[] pares = new int[50];
int[] impares = new int[50];

int countpar = 0;
int countimpar = 0;

for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        pares[countpar] = i;
        countpar++;
    }
    else
    {
        impares[countimpar] = i;
        countimpar++;
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
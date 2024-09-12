Stack<char> caracteres = new Stack<char>();

Console.WriteLine ("Digite uma palavra:");
string? palavra = Console.ReadLine ();

foreach(char c in palavra)
{
    caracteres.Push (c);
}

//Desempihando
string invertido = string.Empty;
while(caracteres.Count > 0)
{
    invertido += caracteres.Pop ();
}
Console.WriteLine (invertido);

Console.WriteLine ("as palavras são iguais?");
Console.WriteLine ("1 - sim | 2 - não");
string? resposta = Console.ReadLine ();

switch (resposta)
{
    case "1":
    Console.WriteLine ("a palavra é um palindro");
    break;
    case  "2":
    Console.WriteLine ("a palavra não é um palindro");
    break;
}

// Basicamente as pilas trabalham com uma etrututra LIFO -> Last in First OUT
// Três métodos importantes:
// Push() -> insere um elemento no topo da pilha
// Pop() -> remove um elemento do topo e o retorna
// Peek() -> retorna o elemento ao topo sem remove-lo

//Invertendo as bolas
Stack<char> caracteres = new Stack<char> ();
foreach(char c in "DARCY DA MONATANHA")
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

// faça em programa que leia a entrada do usuário e identifique se a palavra informada é ou não um palindromo




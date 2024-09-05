using System.Collections;

//utilizando a lista simples
ArrayList arrList = new();
arrList.Add(5);
arrList.Add("Thauan");
//É possível adicionar um conjunto de valores de uma só vez
arrList.AddRange(new int [] {1,2,3});
//O método .add() insere o valor ao final do vetor
arrList.Insert(0,15);
//Já o método insert me permite incluir o valor desejado na posição específicada no primeiro parâmetro

//Lendo valores da lista 
object primeiro = arrList[0]!;
int quarto = (int) arrList[3]!;

//Percorrendo a lista com foreach
foreach(object obj in arrList)
{
    Console.WriteLine(obj); //Console.Write($" | {obj");
}

//obtendo tamanho total da lista, quantios elementos tem
int tamanho = arrList.Count;
//obter a capacidade, quantos podem ser armazenados
int capacidade = arrList.Capacity;

Console.WriteLine(tamanho);
Console.WriteLine(capacidade);

//percorrendo o modo clássico
for (int i =0; 1 < arrList.Count; i++)
{
    Console.Write($" | {arrList[i]}");
}

//Recursos importantes da lista
//Verificar se um valor é contido na lista

bool contemNome = arrList.Contains("Thauan");
if(!contemNome) 
{
    Console.WriteLine("Nome Thauan não é contido");
}

//para saber o indíce que contém o valor buscado
//Neste caso se o valor existir na lista ele retorna o indíce (número inteiro)
//Caso o valor não exista na lista, retorna -1
int indiceDoValor = arrList.IndexOf("Thauan");
if(indiceDoValor >= 0)
{}Console.WriteLine($"Thauan está em [{indiceDoValor}]");
else
    Console.WriteLine("É, realmente não tem.");
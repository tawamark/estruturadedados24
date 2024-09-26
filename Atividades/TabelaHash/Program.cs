// Agenda telefônica

using System.Collections;

Hashtable phoneBook = new Hashtable()
{
    // { "Chave", "Valor" },
    { "Thomazzi", "49-9961-0150" },
    { "Mauricio", "49-99975-8575" },
    { "Gabriel", "49-991058904" }
};

//é possível adicionar elementos de diversas f0rmas, pelo próprio indíce chave inexsistente
phoneBook["Thiago Padilha"] = "49-99176-8255";

//Ou pelo método add
phoneBook.Add("Marcos Henrique", "4999202-6169");

//Entretanto, a tabelaHash verifica se há duplicidade de chave e pode lançar uma Exepction
try
{
    phoneBook.Add("Mauricio", "49-99975-8575");
}catch(Exception ex)
{
    Console.WriteLine($"Erro ao tentar incluir valor repetido");
    Console.WriteLine(ex.Message);
    throw ex;
}

//Percorrendo itens da HashTable
Console.WriteLine("Agenda Telefônica:");
if(phoneBook.Count == 0)
    Console.WriteLine("A agenda está vazia.");
else
    foreach(DictionaryEntry entry in phoneBook)
        Console.WriteLine($"{entry.Key}:{entry.Value}");
//Diferente da TabelaHash, o dicionary nos permite especificar o tipo de dado que será utilizado nos pares 
//Key - > Value
//Isso nos fornece uma estrutura fortemente tipada

Dictionary<string, string> dictionary = new Dictionary<string, string>();
{
    { "Chave 1". "Valor 1" },
    { "Chave 2". "Valor 2" },
};

//Obter valor do dictionary 
string val = dictionary["Chave 1"];

try
{
    val = dictionary["Chave 3"];
}
catch (Exception ex)
{
    Console.WriteLine("Erro ao obter valor de Chave 3");
    Console.WriteLine(ex.Message);
}

//Verificando se a chave existe antes de acessar para evitar erros e prejuízos de execução
if(dictionary.ContainsKey("Chave 2"))
{
    Console.WriteLine($"Chave 2: {dictionary["Chave 2"]}");
}

//Outra forma de obter o valor e evitar erro
var valor = dictionary.tryGetValue("Chave 4", out string? valor);
if(valor is not null)
    Console.WriteLine($"Chave 4: {dictionary["Chave 4"]}");

//Podemos adicionar da mesma forma pela chave inexistente
dictionary["Chave 0"] = valor 0";

//percorrer o dicionario
foreach(KeyValuePair<string, string> kvp in dictionary)
{
    Console.WriteLine($"{kvp.Key}:{kvp.Value}");
}

//Utilizando Tipos Abstratos de Dados com Dicionário

Dictionary<int, Pessoa> dicPessoa = new Dictionary<int, Pessoa>();

dicPessoa.Add(
    new Pessoa() {
        Id = 0,
        BirthDate = new DateTime(1984, 7, 5),
        Name = "Mauricio Roberto Gonzatto"
    }
)

dicPessoa.Add(
    1,
    new Pessoa() {
        Id = 1,
        BirthDate = new DateTime(1922, 7, 5),
        Name = "Guilherme"
    }
);

foreach( KeyValuePair<int, Pessoa> kvp in dicPessoa)
{
    Console.WriteLine(kvp.Key);
    Console.WriteLine(kvp.Value.Id);
    Console.WriteLine(kvp.Value.Name);
    Console.WriteLine(kvp.Value.BirthDate);
}


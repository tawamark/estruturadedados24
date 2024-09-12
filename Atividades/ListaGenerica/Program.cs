using ListaGenerica;

List<double> numbers = new List<double>();

do
{
    Console.WriteLine("Informe um número:");
    string? numberStr = Console.ReadLine();
    //validando a entrada do usuário
    if(!double.TryParse(numberStr, out double number))
    {
        break;
    }

    numbers.Add(number);
    Console.WriteLine($"a média dos valores é: {numbers.Average()}");
}
while(true);

//Lista de pessoas
List<Person> people = new List<Person>();
Person p1 = new Person();
p1.Name = "Joaquim";
p1.Age = 12;
p1.Country = CountryEnum.PY;
people.Add(p1);

//------------------------------------------
people.Add( new Person() 
{
    Name = "Sharo Stone",
    Age = 60,
    Country = CountryEnum.PY,
});

//------------------------------------------
Person p3 = new Person()
{
    Name = "Arnold e Suasnega",
    Age = 65,
    Country = CountryEnum.JP
};
people.Add(p3);

//------------------------------------------------
//formas de percorrer a lista genérica
foreach(Person p in people)
{
    Console.WriteLine(p.Name);
}

//Modo for tradicional
for(int i = 0; i < people.Count; i++)
{
    Console.WriteLine(people[1].Name);
}    
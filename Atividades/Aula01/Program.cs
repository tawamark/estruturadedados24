using Aula01;

// comentário de uma linha

/*
    comentário de 
    múltiplas linhas
*/

using Aula01;

int number; // Declarando variável
number = 10; //Atribuindo valor

const int DAYS_IN_WEEK = 7; // Declarando constante

Console.WriteLine( $"A semana tem {DAYS_IN_WEEK}, dias"); //imprimindo String concatenada

/*
 new tipoenumerador() -> Invoca o método construtor do objeto,
 toda classe tem o seu construtor padrao implícito sem argumentos
 é possível reesecrever este método especificando argumentos
 todavia, se o fizermos, perdemos o original implícito e 
 precisaremos defini-lo expilictamente
*/
TipoEnumerador TypeEnum = new TipoEnumerador();

TipoEnumerador.Language enumEnglish = 
    TypeEnum.GetLanguageEnum("inglês");

Console.WriteLine($"o enum de english é {enumEnglish}");


using System.Globalization;

//criando um vetor multidimensional com 5 linhas e 2 colunas
int[,] numbers = new int[5,2];

//Criando um vetor tridmensional
int[,,] trinumbers = new int[5,4,3];

// podemos incializar os valores do vetor no momento de sua declaração
int[,] iniNumbers = new int[,]  
{
    {1,5,-1},
    {12,14,-12},
    {23,33,-43},
    {54,52,-54},
    {65,61,-75},
};

int menorvalor = iniNumbers[0,0];
int maiorvalor = iniNumbers[0,0];

for (int i = 0; i < 5; i++){
    for (int j=0; j < 3; j++)
    {
        if(iniNumbers[i,j]> maiorvalor)
            maiorvalor = iniNumbers[i,j];
    }

}    

Console.WriteLine($"o maior valor é: {maiorvalor}");




    

    




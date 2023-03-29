using System;

string[] line = Console.ReadLine().Split(' ');
int n1 = int.Parse(line[0]);
int n2 = int.Parse(line[1]);
int[,] mat = new int[n1, n2];

//loop de repetição para alimentar a linha
for (int i = 0; i < n1; i++)
{
    string[] values = Console.ReadLine().Split(' '); 
    
    //loop de repetição para alimentar a coluna, depois de alimentar todas as colunas, volta para
    //o loop das linhas e acrescenta uma linha, até chegar no máximo de n
    for (int j = 0; j < n2; j++)
    {
        //preenche as colunas com os valores digitados e os transforma em int
        mat[i, j] = int.Parse(values[j]);          
    }
}

int number = int.Parse(Console.ReadLine());
for (int i = 0; i < n1; i++)
{
    for (int j = 0; j < n2; j++)
    {
        if (number == mat[i, j])
        {
            Console.WriteLine("Position: " + i + " , " + j);
            if (j > 0)
            Console.WriteLine("Left : " + mat[i, j - 1]);
            if (j < n1 - 1)
            Console.WriteLine("Right : " + mat[i, j + 1]);
            if (i < n2 - 1)
            Console.WriteLine("Down : " + mat[i + 1, j]);
            if (i > 0)
            Console.WriteLine("Up : " + mat[i - 1, j]);
        }
    }
}
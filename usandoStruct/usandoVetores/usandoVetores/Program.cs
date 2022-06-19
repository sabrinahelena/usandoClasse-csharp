using System;
using System.Globalization;

Console.Write("Digite a quantidade de alturas que serão inseridas: ");
int n = int.Parse(Console.ReadLine());


    double[] vect = new double[n]; //cria um vetor com o tamanho definido pelo usuário acima
    for (int i = 0; i < n; i++)
        {
            vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //coloca os valores inseridos pelo usuário no vetor
        }

    double sum = 0.0; //cria a variável soma com 0 inicialmente 

    for (int i = 0; i < n; i++)
        {
            sum += vect[i]; //vai somando as posições do vetor
        }

    double avg = sum / n; //calcula média 
    Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));
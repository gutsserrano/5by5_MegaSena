// Faça um programa que sorteie os 6 numeros da mega sena e grave-os num vetor ordenado

int size = 6;
int cont;
int[] numeros = new int[size];
int aux;
bool achou;
int option;

do
{
    cont = 0;

    for (int i = 0; i < size; i++)
    {
        do
        {
            achou = false;
            aux = new Random().Next(1, 60);
            for (int j = 0; j < cont; j++)
            {
                if (numeros[j] == aux)
                {
                    achou = true;
                }
            }
        } while (achou);

        numeros[i] = aux;
        cont++;
    }

    for (int i = 0; i < size; i++)
    {
        for (int j = i + 1; j < size; j++)
        {
            if (numeros[i] > numeros[j])
            {
                aux = numeros[i];
                numeros[i] = numeros[j];
                numeros[j] = aux;
            }
        }
    }

    Console.WriteLine("Numeros:");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{numeros[i]} ");
    }

    do
    {
        Console.WriteLine("\n\nSortear números novamente?");
        Console.WriteLine("1 - Sim");
        Console.WriteLine("2 - Não");
        option = int.Parse(Console.ReadLine());
    } while (option < 1 || option > 2);
} while (option == 1);

//Найти максимальное из трех чисел

int numberA = 43;
int numberB = 6;
int numberC = 23;

int max = numberA;

if (max < numberB)
{
    max = numberB;
}
if (max < numberC)
{
    max = numberC;
}
Console.WriteLine(max);
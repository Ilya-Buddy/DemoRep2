int[] array = { 11, 22, 33, 43, 5, 66, 76, 83, 92};

int n = array.Length;
int find = 22;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}
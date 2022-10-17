
int[] array = { 55, 2, 1312, 9, 5, 234, 7, 8, 9 };
int n = array.Length;

int find = 9;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
        index++;
}




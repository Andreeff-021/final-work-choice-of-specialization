// Формирует новый массив из элементов, количество символов которых <= N
string[] FillsArrayElementsNcharacters(string[] array, int n)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) // Определяем кол-во элементов для нового массива
    {
        if (array[i].Length <= n) count++;
    }

    string[] new_array = new string[count]; // Создаём новый массив

    count = 0;
    for (int i = 0; i < array.Length; i++) // Заполняем новый массив
    {
        if (array[i].Length <= n)
        {
            new_array[count] = array[i];
            count++;
        }
    }
    return new_array;
}

int N = 3;
string[] arr1 = {"hello", "2", "world", ":-)"};
string[] arr2 = {"1234", "1567", "-2", "computer science"};
string[] arr3 = {"Russia", "Denmark", "Kazan"};

string[] newArr1 = FillsArrayElementsNcharacters(arr1, N);
string[] newArr2 = FillsArrayElementsNcharacters(arr2, N);
string[] newArr3 = FillsArrayElementsNcharacters(arr3, N);

Console.WriteLine(string.Join(", ", arr1));
Console.WriteLine(string.Join(", ", newArr1));
Console.WriteLine();
Console.WriteLine(string.Join(", ", arr2));
Console.WriteLine(string.Join(", ", newArr2));
Console.WriteLine();
Console.WriteLine(string.Join(", ", arr3));
Console.WriteLine(string.Join(", ", newArr3));
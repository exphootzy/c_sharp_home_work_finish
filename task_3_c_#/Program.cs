
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
//  пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int[] FillArrayIndex()
{
    Random rnd = new Random();
    int temp;
    int a = rnd.Next(0, 4);
    int[] array = new int[a];
    for (int i = 0; i < a; i++)
    {

        temp = rnd.Next(0, 5);
        while (SearchDublicate(temp, array))
        {
            temp = rnd.Next(0, 5);
        }
        array[i] = temp;

    }

    return array;
}

bool SearchDublicate(int tmp, int[] array)
{
    foreach (var item in array)
    {
        if (item == tmp)
        {
            return true;
        }
    }
    return false;
}

int[] SelectionSort(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1 - i; j++)
        {
            if (array[j] > array[j + 1])
            {
                temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
    return array;
}

string[] FillArrayString(string[] array, int[] index)
{
    string[] arrayNew = new string[index.Length];
    for (int x = 0; x < index.Length; x++)
    {
        {
            arrayNew[x] = array[index[x]-1];
        }
    }
    return arrayNew;
}

void PrintArrayString(string[] array)
{
    int count = array.Length;
    Console.Write("[");
        for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}

void PrintArrayInt(int[] array)
{
    int count = array.Length;
    Console.Write("Индексы для печати: ");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


string[] arrayOriginal = { "HelloWorld", "725", "Create", ":-)", "-2" };
Console.Write("Исходный массив: ");
PrintArrayString(arrayOriginal);
int[] index = FillArrayIndex();
SelectionSort(index);
PrintArrayInt(index);
string[] arrayNew = FillArrayString(arrayOriginal, index);
Console.Write("Полученный массив: ");
PrintArrayString (arrayNew);

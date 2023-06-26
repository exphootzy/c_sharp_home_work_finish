
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
//  пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] FillArray(string[] array)
{
    Random random = new Random();
    int a = random.Next(0, 4);
    string[] numbers = new string[a];
        Console.WriteLine($"Рандомное число для длинны массива: {a}");
    for (int x = 0; x < numbers.Length; x++)
    {
        {
            int b = random.Next(0, numbers.Length);
            numbers[x] = array[b];
        }
    }
    return numbers;
}

void PrintArray(string[] array)
{
    int count = array.Length;
    Console.Write("Исходный массив: ");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


string[] arrayOriginal = { "HelloWorld", "725", "Create", ":-)", "-2" };
PrintArray(arrayOriginal);
string [] arrayNew = FillArray(arrayOriginal);
PrintArray(arrayNew);

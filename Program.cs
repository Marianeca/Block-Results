/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/


Console.WriteLine($"Введите количество элементов в массиве: ");
int elemCount=int.Parse(Console.ReadLine()!);

string[] array1 = new string[elemCount];
string[] array2 = new string[array1.Length];

for (int i=1; i<array1.Length+1; i++)
{
    Console.WriteLine($"Введите элемент {i}: ");
    array1 [i-1]=Console.ReadLine()!;
}


FirstArrayToSecond(array1, array2);
Print(array2);


void FirstArrayToSecond(string[] array1, string[] array2)
{
    int count = 0;

    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count=count+1;
        }
    }
}


void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
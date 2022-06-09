// Задача: Написать программу, которая из имеющегося массива строк
//формирует массив строк, длина которого меньше или равна 3 символам
//Первоначальный массив можно ввести с клавиатуры, либо задать в начале
//выполнения алгоритма.
void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.Write("Задайте размер массива: ");
int N = int.Parse(Console.ReadLine());
string[] array = new string[N];
Console.WriteLine("Введите элементы массива поочередно: ");
for (int n = 0; n < array.Length; n++)
{
    array[n] = Console.ReadLine();
}
Console.WriteLine();
int index = 0;
string[]array1 = new string[N];
for (int i = 0; i < array.Length; i++)
{
    if ( array[i].Length <= 3)
    {
        array1[index] = array[i];
        index++;
    }
}
Print(array1);
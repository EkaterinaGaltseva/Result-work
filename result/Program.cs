/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. */


string[] arrayOne = new string[5] {"HELLO", "res", "world", "Kazan", "two"};
string[] arrayTwo = new string[arrayOne.Length];
void ResultArray(string[] arrayOne, string[] arrayTwo)
{
    int count = 0;
    for (int i = 0; i < arrayOne.Length; i++)
    {
    if(arrayOne[i].Length <= 3)
        {
        arrayTwo[count] = arrayOne[i];
        count++;
        }
    }
}
Console.Write("Символов меньше или равно 3 ->");
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
}
ResultArray(arrayOne, arrayTwo);
PrintArray(arrayTwo);
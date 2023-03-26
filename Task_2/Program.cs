// Написать программу, которая из имеющегося массива строк сфломирует массив
//  из строк, длина которых меньше, либо равна 3 символам. Первоначальный 
// массив можно ввести с клавиатуры, либо задать на старте выполнения 
// алгоритма.

// Пример: ["hello", "2", "world", ";-)"]  =>  ["2", ";-)"]


Console.Clear();

string[] arrayOne = new string[7] {"Москва", "ОН", "Платон", "не", "007", "Phizik", "!!"};
Console.Write($"{arrayOne} ==> ");
string[] arrayTwo = new string[arrayOne.Length];


int count = 0;
void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
      {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(arrayOne, arrayTwo);
PrintArray(arrayTwo);


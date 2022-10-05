// Программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Console.Clear();

string[] array1 = new string[8] {"sdf", "2sbsb3", "D", "GASV", "AA", "D", "GASDVSV", "zA"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
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
SecondArrayWithIF(array1, array2);
PrintArray(array2);

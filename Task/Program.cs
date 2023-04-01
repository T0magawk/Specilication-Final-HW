// //Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше 
//либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения 
//алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивам

Console.WriteLine("Итоговое задание по курсу Знакомство со специализациями ");

string[] MassiveNew = new string[7] {"peace", "game", "war", "school", "life", "shame", "horror"};
string[] MassiveFind = new string[MassiveNew.Length];
void Find(string[] array1, string[] array2)
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
Find(MassiveNew, MassiveFind);
PrintArray(MassiveFind);


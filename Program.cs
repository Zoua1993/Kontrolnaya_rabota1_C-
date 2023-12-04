// Написать программу, которая из имеющегося массива строк, формирует новый массив строк, длинна которых меньше
// или равна 3 символам. 

int length;
string buff;

Console.Write("Введите длину массива: ");
length = int.Parse(Console.ReadLine()!);

string[] sourse = new string[length];

for (int iterator = 0; iterator < length; iterator++)
{
    Console.Write("Введите строку: ");
    buff = Console.ReadLine();
    sourse[iterator] = buff;
}
int count = 0; 
for (int iterator = 0; iterator < length; iterator++)
{
    if (sourse[iterator].Length <= 3)
    {
        count++;
    }
}

string[] result = new string[count]; 

for (int iterator = 0; iterator < length; iterator++)
{
    if (sourse[iterator].Length <= 3)
    {
        count--;
        result[count] = (sourse[iterator]);
    }
}
Array.Reverse(result);
Console.WriteLine($"Исходный массив: [{String.Join(", ",  sourse)}]");
Console.WriteLine($"Вывод массива с подходящими строками: [{String.Join(", ",  result)}]");

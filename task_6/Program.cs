// Задача 6. На вход принимается число, на выходе необходимо указать,
// является ли число четным или нет.

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

if(a % 2 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

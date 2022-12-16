// Задача 8. На вход принимается число N, на выходе необходимо показать 
// все четные числа от 1 до N.

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

int i = 1;

while(i <= N)
{
    if(i % 2 == 0)
{
    Console.Write(i + " ");
}
    i = i + 1;
}

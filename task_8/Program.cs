// Задача 8. На вход принимается число N, на выходе необходимо показать 
// все четные числа от 1 до N.

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

while(N >= 1)
{
    if(N % 2 == 0)
{
    Console.Write(N + " ");
}
    N = N - 1;
}

/*Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

int N;

Console.Write($"Введите N= ");
int.TryParse(Console.ReadLine()!, out N);

for (int index = 2; index <= N; index += 2)
{
    Console.Write($"{index} ");
}

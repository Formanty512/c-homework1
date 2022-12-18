/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/*
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a < b)
{
    Console.WriteLine ($"max =" + b + ", min =" + a );
}
else
{
    Console.WriteLine ($"max =" + a + ", min =" + b );
}
*/

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
 /*
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int maximal = Math.Max(Math.Max(a, b), c); //я загуглила в нете команду для сравнения нескольких чисел тк делать это через конструкцию if else мне показалось очень стрёмным, надеюсь, меня не побьют за это :О
int minimal = Math.Min(Math.Min(a, b), c);

Console.WriteLine ($"max =  " + maximal + " min = " + minimal); 
*/

/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

/*
int a = Convert.ToInt32(Console.ReadLine());
if (a%2 == 0)
{
    Console.WriteLine ($"Число является чётным");
}
else
{
    Console.WriteLine ($"Число не является чётным");
}
*/

/* 
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < N+1;i++)
{
    if (i%2 == 0)
    Console.WriteLine(i);
}
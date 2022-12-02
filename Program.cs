// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Введите целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1>num2)
{
    Console.Write("Число " + num1 + " больше, чем число " + num2);
}
else
{
    Console.Write("Число " + num2 + " больше, чем второе " + num1);
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.WriteLine("Введите 3 целых числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}

Console.Write("Число max= " + max);
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.WriteLine("Введите целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1%2==0)
{
    Console.WriteLine("Число " + num1 + " чётное ");
}
else
{
    Console.WriteLine("Число " + num1 + " нечётное ");  
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
int i = 1;
bool not = true;

Console.WriteLine("Введите целое число N: ");
int num1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Чётные числа от 1 до " + num1);
while (i <= num1)
{
        if (i % 2 != 1)
        {
            Console.Write(i + ", ");
            not = false;
        }
    i++;
}

        if (not)
{
    Console.WriteLine("Нет чётных чисел!");
}
/*
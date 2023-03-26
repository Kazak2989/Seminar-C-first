// Home work 1
// Task 1.
// Напишите прогамму которая на вход принимает два числа и выдает какое число больше, а какое меньше

// Console.Write("Enter number1: ");

// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter number2: ");

// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 < num2)
// {
//     Console.WriteLine("Max is number2 = " + num2);
//     Console.WriteLine("Min is number1 = " + num1);
// }
// else 
// {
//     Console.WriteLine("Max is number1 = " + num1);
//     Console.WriteLine("Min is number2 = " + num2);
// }

//  Task 2.
//  Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
// Console.Write("Введите любое первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите любое второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите любое третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = num1;

// if(num1 > max) max = num1;
// if(num2 > max) max = num2;
// if(num3 > max) max = num3;

// Console.Write("Максимальное число = ");
// Console.WriteLine(max);

// Task 3.
// Напишите программу, которая на вход принимает число и выдает, 
// является ли число четным (делится ли оно на два без остатка)

// Console.Write("Введите число для проверки: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int even = num % 2;
// if(even == 0)
// {
//     Console.Write("Да, число " + num + " является четным!");
// }
// else 
// {
//     Console.Write("Нет, число " + num + " не является четным!");
// }

// Task 4.
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все числа от 0 до N.

// Console.Write("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// int current = 0;

// while(current <= num)
// {
//     Console.Write(current + " ");
//     current++;
// }
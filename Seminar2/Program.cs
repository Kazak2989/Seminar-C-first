// Seminar 2
// Task 1. Напишите программу, которая выводит случайное число и удаляет вторую цифру этого числа

// int cutNumber(int num)
// {
//     int hundreds = num / 100;
//     int units = num % 10;

//     int result = hundreds * 10 + units;
//     return result;
// }

// int randNumber = new Random().Next(100, 1000);
// int newNumber =  cutNumber(randNumber);

// Console.WriteLine($"New version of {randNumber} is {newNumber}");

// Task 2. Напишите программу, которая выводит случайное число из отрезка от 10 до 99 и показывает наибольшую цифру этого числа.

// int MaxDigit(int num)

// {
//     int tens = num / 10;
//     int units = num % 10;
//     int max = 0;
    
//     if (tens > units)
//     {
//         max = tens;
//     }
//     else 
//     {
//         max = units;
//     }

//     return max;

// }
// int randNumber = new Random().Next(10, 100);
// int newNumber = MaxDigit(randNumber);
// Console.WriteLine($"Max digits of {randNumber} is {newNumber}");

// Task 3. Напишите программу, которая принимает на вход число и проверяет кратно ли оно одновременно А или Б.

/*
bool ModNumber(int num, int a, int b)
{
    if (num % a == 0 && num % b ==0)
    {
        return true;
    }
    else 
    {
        return false;
    }

}
Console.WriteLine("Inpur your number  ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inpur your a number  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inpur your b number  ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ModNumber(num, a, b));
*/

// Task 4. Напишите программу, которая принимает на вход два числа и проверяет является ли оно квадратом другого. (метод bool, 
// два аргумета)

// bool quad(int a, int b)
// {
//     if(a == b * b || b == a * a)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }
// Console.WriteLine("Input your a number ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input your b number ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(quad(a, b));

// Home Work
// Task 1.
// Напишите программу, которая на вход принимает трехзначное число и на выходе показывает вторую цифру этого числа.

int HundNum(int num)
{
    if(num > 99 && num < 1000)
    {
    int twonum = num / 10 % 10;
    return twonum;
    }
    else
    return -1;

}

Console.WriteLine("Input your number 100 to 999 ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your second digit = {HundNum(num)}");


// Task 2.
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int ThirdDigit(int num)
// {
//     while(num > 999)
//     {  
//         num = num /= 10;                                     
//     }
//     if(num < 100)
//     {
//         Method1();
//     }
   
//     return num = num % 10;
// }
// void Method1()
// {
//     Console.Write("отсутствует ");
// }

// Console.WriteLine("Input your number ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"ваша третья цифра {ThirdDigit(num)}");

// Task 3.
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// bool DayWeek(int num)
// {
//     if(num >= 6 && num <= 7)
//     {
//        return true;
//     }
//     else
//     {
//         return false;
//     } 
    
// }
// Console.Write("Enter your day of week: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Your day is weekend {DayWeek(num)}");


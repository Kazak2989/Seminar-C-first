// Seminar 3.
// Task 1. напишите программу которая по заданному номеру четверти,
// показывает диапозон возможных координат точек в этой четверти(x и y).

// void ShowRange(int quadrant)
// {
//     if(quadrant == 1) Console.WriteLine("x > 0 and y > 0");
//     else if(quadrant == 2) Console.WriteLine("x < 0 and y > 0");
//     else if(quadrant == 3) Console.WriteLine("x < 0 and y < 0");
//     else if(quadrant == 4) Console.WriteLine("x > 0 and y < 0");
//     else Console.WriteLine("Quadrant doesnt exist!");
// }

// Console.Write("Input a number of quadrant: ");
// int quadrant = Convert.ToInt32(Console.ReadLine());
// ShowRange(quadrant);

// Task 2. напишите программу которая принимает на вход координаты 
// точки х и у не нулевые и возвращает номер четверти плоскости в которой находится эта точка.

// int ShowRange(int x, int y)
// {
//     if(x > 0 && y > 0) return 1;
//     if(x < 0 && y > 0) return 2;
//     if(x < 0 && y < 0) return 3;
//     if(x > 0 && y < 0) return 4; 
//     return -1;
// }

// Console.Write("Input x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(ShowRange(x, y));

// Task 2.Координата принимает на вход координаты двух точек и находит расстояние между ними.

// double Way(double x1, double y1, double x2, double y2)
// {
//     double lenx = x2 - x1;
//     double leny = y2 - y1;
//     double lenxy = Math.Sqrt(lenx*lenx + leny*leny);
//     return lenxy;
// }

// Console.Write("Input x1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input x2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine(Way(x1, y1, x2, y2));

// Task 3. Напишите программу которая принимает на вход число (N)и выдает таблицу квадратов от 1 до N.

// void Way(int num)
// {
//     for(int i = 1; i <= num; i++) Console.WriteLine($"{i} * {i} = {i*i}");
// }

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Way(num);


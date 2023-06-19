// Задача 19 
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// System.Console.WriteLine("Введите пятизначное число");
// string? num = Console.ReadLine();

// if (num[0] == num [4] || num [1] == num [3])
// {
//     System.Console.Write("Является полиндромом"); 
// }
// else
// {
//     System.Console.Write("Не является полиндромом");
// }




// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// System.Console.WriteLine("Введите координаты первой точки через пробел:");
// int[] fp = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

// System.Console.WriteLine("Введите координаты второй точки через пробел:");
// int[] sp = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

// int point1 = (int)Math.Pow(fp[0]-sp[0], 2);
// int point2 = (int)Math.Pow(fp[1]-sp[1], 2);
// int point3 = (int)Math.Pow(fp[2]-sp[2], 2);

// System.Console.WriteLine(Math.Round(Math.Sqrt(point1 + point2 + point3), 3));






// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// System.Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int index = 1;
// while (index <= number)
// {
//     System.Console.Write(Math.Pow(index , 3)+ " ");
//     index++;
// }
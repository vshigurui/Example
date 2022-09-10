// Задача № 25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

// Console.Write("Введите число A = ");
//     int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B = ");
//     int b = Convert.ToInt32(Console.ReadLine());

// int DegreeAB (int a, int b) { 
// int result = 1;
//     for (int i = 1; i <= b; i++) {
//         result = result * a;
//         Console.WriteLine(result);
//     }
//     return result;
// }
// int degree = DegreeAB (a,b);
// Console.WriteLine("Ответ:" + degree);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// int sum = 0;
// while(a > 0) {
//     sum = sum + a % 10;
//     Console.WriteLine(sum);
//     a = a / 10;
//     Console.WriteLine(a); 
// }

// Console.WriteLine(sum);



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int [] array = new int [8];

// for (int i = 0; i < array.Length; i++){
//     array[i] = new Random().Next(0, 100);
// }
// Console.WriteLine("[" + string.Join(",", array) + "]"); 
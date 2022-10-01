Console.Clear();



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.WriteLine("Введите начальное число M:");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите начальное число N:");
// int N = Convert.ToInt32(Console.ReadLine());

// ///Метод нахождения суммы натуральных элементов в промежутке от M до N
// void GapNumberSum (int M, int N, int sum)
// {
//     if (M > N) 
//     {
//         Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
//         return;
//     }
//     sum = sum + (M++);
//     GapNumberSum(M, N, sum);
// }

// GapNumberSum(M, N, 0);


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Console.WriteLine("Введите начальное число M:");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите начальное число N:");
// int N = Convert.ToInt32(Console.ReadLine());


// int AckermannFunction (int M, int N)
// {
//     if (M == 0) return N + 1;
//     if (M != 0 && N == 0) return AckermannFunction(M - 1, 1);
//     if (M > 0 && N > 0) return AckermannFunction(M - 1, AckermannFunction(M, N - 1));
// return AckermannFunction(M, N);
// }

// Console.WriteLine($"Функция Аккермана для чисел A({M},{N}) = {AckermannFunction(M, N)}");
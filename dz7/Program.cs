// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


Console.Clear();

// Console.Write("Введите число строк m: ");
//     int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввведите число столбцов n: ");
//     int n = Convert.ToInt32(Console.ReadLine());

// double [,] matrix = new double [m, n];

// void PrintArray(double [,] RandomMatrix) {
//     for (int i = 0; i < RandomMatrix.GetLength(0); i++ ) {
//         for (int j = 0; j < RandomMatrix.GetLength(1); j++) {
//             Console.Write($"{RandomMatrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void RandomNambers (double [,] matr) {
//     for (int i = 0; i < matr.GetLength(0); i++) {
//         for (int j = 0; j < matr.GetLength(1); j++) {
//             matr[i, j] = Convert.ToDouble(new Random().Next(-100, 1000)) / 10;
//         }
//     }
// }

// RandomNambers(matrix);

// PrintArray(matrix);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.Write("Введите номер строки: ");
//     int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввведите номер столбца: ");
//     int n = Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int [4, 6];

// void RandomNambers (int [,] matr) {
//     for (int i = 0; i < matr.GetLength(0); i++) {
//         for (int j = 0; j < matr.GetLength(1); j++) {
//             matr[i, j] = new Random().Next(0, 10);
//         }
//     }
// }
// RandomNambers(matrix);



// void PrintArray(int [,] RandomMatrix) {
//     for (int i = 0; i < RandomMatrix.GetLength(0); i++ ) {
//         for (int j = 0; j < RandomMatrix.GetLength(1); j++) {
//             Console.Write($"{RandomMatrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// PrintArray(matrix);


// if (m > matrix.GetLength(0) || n > matrix.GetLength(1)){
//     Console.WriteLine("такого элемента нет");
// }
// else {
//     Console.WriteLine($"значение элемента {m} строки и {n} столбца равно {matrix[m-1,n-1]}");
// }



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Console.Write("Введите число строк: ");
//     int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввведите число столбцов: ");
//     int n = Convert.ToInt32(Console.ReadLine());


// int [,] matrix = new int [m, n];

// void RandomNambers (int [,] matr) {
//     for (int i = 0; i < matr.GetLength(0); i++) {
//         for (int j = 0; j < matr.GetLength(1); j++) {
//             matr[i, j] = new Random().Next(0, 10);
//         }
//     }
// }
// RandomNambers(matrix);

// void PrintArray(int [,] RandomMatrix) {
//     for (int i = 0; i < RandomMatrix.GetLength(0); i++ ) {
//         for (int j = 0; j < RandomMatrix.GetLength(1); j++) {
//             Console.Write($"{RandomMatrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// PrintArray(matrix);

// for (int j = 0; j < matrix.GetLength(1); j++) {
//     double SrAr = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++) {
//         SrAr = (SrAr + matrix[i, j]);
//     }
//     SrAr = SrAr / m;
//     Console.WriteLine($"среднее арифметическое :{SrAr} ");
// }
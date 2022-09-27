// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


Console.Clear();



// Console.Write("Введите число строк m: ");
//     int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввведите число столбцов n: ");
//     int n = Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int [m, n];

// void SortingArray (int [,] array) {
//     for (int i = 0; i < array.GetLength(0); i++) {
//         for (int j = 0; j < array.GetLength(1); j++) {
//             for (int k = 0; k < array.GetLength(1) - 1; k++) {
//                 if (array[i, k] < array[i, k + 1]){
//                     int arr = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = arr;
//                 }
//             }
//         }
//     }
//     Console.WriteLine();
// }


// void NewMatrix (int [,] matr) {
//     for (int i = 0; i < matr.GetLength(0); i++) {
//         for (int j = 0; j < matr.GetLength(1); j++) {
//             matr[i, j] = new Random().Next(0, 20);
//         }
//     }
// }

// NewMatrix(matrix);


// void PrintArray(int [,] RandomMatrix) {
//     for (int i = 0; i < RandomMatrix.GetLength(0); i++ ) {
//         for (int j = 0; j < RandomMatrix.GetLength(1); j++) {
//             Console.Write($"{RandomMatrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// PrintArray(matrix);


// SortingArray(matrix);
// PrintArray(matrix);




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Console.Write("Введите число строк m: ");
//     int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввведите число столбцов n: ");
//     int n = Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int [m, n];

// int minsum = Int32.MaxValue;
// int indexLine = 0; 




// void NewMatrix (int [,] matr) {
//     for (int i = 0; i < matr.GetLength(0); i++) {
//         for (int j = 0; j < matr.GetLength(1); j++) {
//             matr[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// NewMatrix(matrix);


// void PrintArray(int [,] RandomMatrix) {
//     for (int i = 0; i < RandomMatrix.GetLength(0); i++ ) {
//         for (int j = 0; j < RandomMatrix.GetLength(1); j++) {
//             Console.Write($"{RandomMatrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// PrintArray(matrix);

// for (int i = 0; i < matrix.GetLength(0); i++) {
//     int sum = 0;
//     for (int j = 0; j < matrix.GetLength(1); j++) {
//         sum = sum + matrix[i, j];
//     }
//     if (sum < minsum) {
//         minsum = sum;
//         indexLine++;
//     }
// }
// Console.WriteLine($"строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum));



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


// Console.Write("Введите число строк первой матрицы m: ");
//     int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввведите число столбцов первой матрицы (и строк второй )n: ");
//     int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввведите число столбцов второй матрицы p: ");
//     int p = Convert.ToInt32(Console.ReadLine());
// int [,] firstMatrix = new int [m, n];
// NewMatrix(firstMatrix);
// PrintArray(firstMatrix);

// int [,] secondMatrix = new int [n, p];
// NewMatrix(secondMatrix);
// PrintArray(secondMatrix);

// int [,] result = new int [m, p];


// void firstSecondMatrix (int [,] firstMatrix, int [,] secondMatrix, int [,] result) {
//     for(int i = 0; i < result.GetLength(0); i++) {
//         for(int j = 0; j < result.GetLength(1); j++) {
//             int rezult = 0; 
//             for (int k = 0; k < result.GetLength(1); k++){
//                 rezult = firstMatrix[i, k] * secondMatrix[k, j];
//             }
//             result[i, j] = rezult;
//         }
//     }
// }


// void NewMatrix (int [,] matrix) {
//     for (int i = 0; i < matrix.GetLength(0); i++) {
//         for (int j = 0; j < matrix.GetLength(1); j++) {
//             matrix[i, j] = new Random().Next(0, 10);
//         }
//     }
// }




// void PrintArray(int [,] matrix) {
//     for (int i = 0; i < matrix.GetLength(0); i++ ) {
//         for (int j = 0; j < matrix.GetLength(1); j++) {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// firstSecondMatrix(firstMatrix, secondMatrix, result);
// Console.WriteLine($"\nПроизведение первой и второй матриц:");
// PrintArray(result);



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Console.Write("Введите X: ");
//     int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите Y: ");
//     int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите Z: ");
//     int z = Convert.ToInt32(Console.ReadLine());

// int [,,] array = new int [x, y, z];
// NewArray(array);
// PrintArray(array);



// void PrintArray (int [,,] array) {
//     for (int i = 0; i < array.GetLength(0); i++) {
//         for (int j = 0; j < array.GetLength(1); j++) {
//             Console.Write($"X({i}) Y({j}) ");
//             for (int k = 0; k < array.GetLength(2); k++) {
//                 Console.Write($"Z({k})={array[i,j,k]}; ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }


// void NewArray (int [,,] array) {
//     int [] arr = new int [array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
//     int number;
//     for (int i = 0; i < arr.GetLength(0); i++) {
//         arr[i] = new Random().Next(10, 100);
//         number = arr[i];
//         if (i >= 1) {
//             for (int j = 0; j < i; j++){
//                 while(arr[i] == arr[j]) {
//                     arr[i] = new Random().Next(10, 100);
//                     j = 0;
//                     number = arr[i];
//                 }
//                 number = arr[i];
//             }
//         }
//     }
//     int count = 0;
//     for (int x = 0; x < array.GetLength(0); x++){
//         for (int y = 0; y < array.GetLength(1); y++) {
//             for (int z = 0; z < array.GetLength(2); z++) {
//                 array[x, y, z] = arr[count];
//                 count++;
//             }
//         }
//     }
// }





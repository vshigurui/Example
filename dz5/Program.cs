// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

// Console.Write("Введите размер массива:  ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [] array = new int[n]; 
// int count = 0;

// void InputArray(int [] array) {
//     for (int i = 0; i < array.Length; i++){
//         array[i] = new Random().Next(100, 1000);
//     }
// }
//     InputArray(array);
//     Console.WriteLine("наш массив: [" + string.Join(",", array) + "]");

// for (int j = 0; j < array.Length; j++) {
//     if (array[j] % 2 == 0) {
//         count++;
//     }
// }
//     Console.Write("количество чётных чисел:" + count);



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


// Console.Write("Введите размер массива:  ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [] array = new int[n];
// int sum = 0;

// void InputArray (int [] array) {
//     for (int i = 0; i < array.Length; i++) {
//         array[i] = new Random().Next(1, 10);
//     }
// }
// InputArray(array);
// Console.WriteLine("наш массив: [" + string.Join(",", array) + "]");

// for (int j = 1; j < array.Length; j+=2) {
//     sum += array[j];
// }
// Console.Write("сумму нечётных элементов:" + sum);


// Задача 38: Задайте массив дробных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// Console.Write("Введите размер массива:  ");
// int n = Convert.ToInt32(Console.ReadLine());
// double [] array = new double[n];
// double max = Int32.MinValue;
// double min = Int32.MaxValue;

// void InputArray (double [] array) {
//     for (int i = 0; i < array.Length; i++) {
//         array[i] = Convert.ToDouble(new Random().Next(-100, 1000)) / 100;
//     }
// }
// InputArray(array);
// Console.WriteLine("массив: [" + string.Join(" ; ", array) + "]");

// for (int j = 0; j < array.Length; j++) {
//     if (array[j] > max) {
//         max = array[j];
//     }
//     if(array[j] < min) {
//         min = array[j];
//     }
// }
// Console.WriteLine("максимальное: " + max);
// Console.WriteLine("минимальное: " + min);
// Console.WriteLine("разницу между максимальным и минимальным элементов массива: " + (max - min));

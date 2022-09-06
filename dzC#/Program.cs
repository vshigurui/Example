    // Задача №10   Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

// int a = new Random().Next(100, 1000);
// Console.WriteLine(a);
// Console.Write(Convert.ToString(a)[1]);

    // Задача №13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
//      if (n > 100) {
//          Console.Write(Convert.ToString(n)[2]);
//}
//      else {
//          Console.WriteLine("третьей цифры нет");
// }


    // Задача № 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber == 6 || dayNumber==7) {
    Console.WriteLine("этот день выходным");
}
else if (dayNumber < 1 || dayNumber > 6) {
    Console.WriteLine("это не день недели");
}
else {
    Console.WriteLine("этот день рабочий");
}


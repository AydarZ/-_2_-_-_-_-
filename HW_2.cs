// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.WriteLine("Введите трехзначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine((number/10)%10);



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number / 100 > 0)
// {
//     while (number / 10 > 99)
//     {
//         number = number / 10;
//     }
//     int num3 = number % 10;
//     Console.WriteLine(num3);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 || number == 7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


// PS: Андрей, удобно ли принимать ДЗ в таком виде, когда все задачи в одном файле закоментированны???
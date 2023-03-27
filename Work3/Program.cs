/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введи любое число: ");
int a = int.Parse(Console.ReadLine());

if (a > 99 ) {
    
    Console.Write($"{a} -> ");
    Console.Write(a > 99 ? a.ToString()[2] : '-');
}
else {

    Console.Write($"{a} -> ");
    Console.Write("Третьей цифры нет");
}
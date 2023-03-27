

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/*Console.Write("Введи любое число: ");
int a = int.Parse(Console.ReadLine());

int result = -1;
if (a >= 100)
    {
    while (a > 999)
    {
       a = a / 10;
    }
    result = a % 10;
return result;      
    }   
Console.Write(result);
*/
Console.Write("Введи любое число: ");
int a = int.Parse(Console.ReadLine());


/* if (a < 100)
  {
   Console.Write($"{a} -> ");
   Console.Write("Третьей цифры нет");
  }
int GetSecond(int a)
  {
  while (a >= 100)
  a = (a / 10);
  int d = a % 10;
  return d;
  }
  Console.Write(a);
*.
/* if (a >= 100) 
  {
   a = (a / 10) % 10;
  
   return a;
  }  
Console.Write(a);

/*
Console.Write("Введи любое число: ");
string collection = Console.ReadLine();
string str = collection.ToString();
if (collection > 3)
{
Console.Write($" {collection} -> ");
Console.Write(str[2]);
}
else
{
Console.Write($" {collection} -> третьей цифры нет");
}







/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

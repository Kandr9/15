// 15
System.Console.WriteLine("Введите от 1 до 7");
int n =Convert.ToInt32(Console.ReadLine());

if(n>=1 && n<=7)
{
    if (n==6  | n==7) 
    System.Console.WriteLine("Сегодня выходной");
    else
    System.Console.WriteLine("Сегодня рабочий день");
}
else
System.Console.WriteLine("Неверное число");

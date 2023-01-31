//Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе

 
/*int a = int.Parse(Console.ReadLine()!);
int s = 0;
while (a > 0)
{

    s = s + a % 10;
    a = a /10 ;

}

 Console.WriteLine(s);*/
int input(string str)
{
    Console.WriteLine($"{str}");
    int a = int.Parse(Console.ReadLine()!);
    return a;
}

int SumNum(int arg1)
{
    arg1 = Math.Abs(arg1);
    int result = 0;
    int num = arg1;
    while(num > 0)
{
    result += num % 10;
    num /= 10;
}
return result;
}
void Main()
{
    Console.Clear();
    int num1 = input("Введите число: ");    
    int res = SumNum(num1);
    Console.WriteLine($"Сумма цифр числа {num1} равна {res}");
}    
Main();
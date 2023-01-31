// Задача 25: Напишите функцию, которая принимает на вход
// два числа (A и B) и возводит число A в натуральную степень B.
int array(string str)
{
    Console.WriteLine($"{str}");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int Degree(int arg1, int arg2)
{    
    int res = 1;
    arg1 = Math.Abs(arg1);
    arg2 = Math.Abs(arg2);
    for(int i = 1; i <= arg2; i++)
    {   
        res *= arg1 ;
    }
            
    return res;
}

void Print()
{
    Console.Clear();
    int a = array("Введите число A: ");
    int b = array("Введите степень числа A: ");
    int result = Degree(a, b);
    Console.WriteLine($"A в степени {b} равно {result}");
}
Print();
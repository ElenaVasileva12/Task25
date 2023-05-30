//  Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Degree(double num1, int num2)  //возведение в степень
{
    double degree=1;
    int i=0;
    while (i<num2)
    {
        degree=degree*num1;
        i++;
    }
    return degree;
}


Console.WriteLine("Введите первое число: ");
double number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число, больше 0: ");
int number2 = Convert.ToInt32(Console.ReadLine());


if (number2<=0)
    {
        Console.WriteLine("Введенно некоректное число");
    return;
    }

Console.WriteLine($"{Degree(number1,number2)}");
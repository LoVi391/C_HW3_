// Напишите цикл, который принимает на вход
//два числа (A и B) и возводит число A в натуральную
//степень B.

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int Pow_ab(int a, int b)
{
    int a_temp = a;
    for(int i = 1; i < b; i++)
    {
        a = a * a_temp;
    }
    return a;
}

// double Pow_ab(int num1, int num2)
// {
//    double num1_d = Convert.ToDouble(num1);
//    double num2_d = Convert.ToDouble(num2);
//    double pow = Math.Pow(num1_d, num2_d);
//    return pow;
// }

Console.WriteLine($"Число {a} в степени {b} = {Pow_ab(a, b)}");

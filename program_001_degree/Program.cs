// Цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

//метод возведения числа num в степень dg путем его перемножения на само себя
double degree(int num, int dg)
{   
    int resault = num;
    for (int i=2; i<=dg; i++)
    {
        resault = resault * num;
    }
    return resault;
}

//принимаем числа на вход
Console.Write("Введите число A ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B ");
int B = Convert.ToInt32(Console.ReadLine());

//возводим введенне число в веденну пользовтаелем степень и выводим результат на экран
Console.WriteLine(degree(A,B));
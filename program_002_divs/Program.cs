// Программа, которая принимает на вход число и выдаёт сумму цифр в числе, которые являются делителями этого числа

//описываем метод возведения числа 10 в степень 
int Ten(int degree)
{   
    int ten_in_degree = 1;
    for (int i = 1; i <= degree;i++)
        {
            ten_in_degree = ten_in_degree * 10;
        }
    return ten_in_degree;
}

//описываем метод определения разрядности числа
int Numeric(int num)
{
    int dec = 10;
    int index = 1;
    while (num % dec < num)
    {
        dec *= 10;
        index++;
    }
    return index;
}

//принимаем число на вход
Console.Write("Введите число ");
int Number = Convert.ToInt32(Console.ReadLine());

//определем разрядность числа
int N = Numeric(Number);
//Console.WriteLine(N);

//заполняем массив цифрами числа
int[] digits = new int[N];

//остаток числа при определении его цифр
int Division = 0;

// определяем цифры числа
int sum = 0;
for (int index = 0; index < N;index++)
{
    digits[index] = (Number - Division)/Ten(N-index-1);
    if (digits[index] != 0) 
    {
        if (Number % digits[index] == 0) sum += digits[index];
    }   
    Division += digits[index]*Ten(N-index-1);
}

Console.WriteLine($"Cумма цифр в числе, которые являются его делителями - {sum}");



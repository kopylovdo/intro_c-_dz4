// Программа, которая заполняет массив на N «интересных» случайных целых чисел.
// Назовём число «интересным» если его произведение цифр делится на их сумму

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

//метод определения цифр числа и преобразование числа в массив, определение суммы цифр и произведения
int Array(int Number)
{
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
    //находим сумму и произведение чисел
    int summa = 0;
    int multiplicat = 1;
    for (int index = 0; index < N;index++)
    {
        summa += digits[index];
        multiplicat *=digits[index];
    }
    //проверяем условие кратности произведения цифр сумме цифр числа
    int res = 0;
    if (sum != 0)
    {
        if (multiplicat % summa == 0) res = 1;
    }
    return res;
}

//принимаем длину массива на вход
Console.Write("Введите длину массива N ");
int num_len = Convert.ToInt32(Console.ReadLine());

int[] array_number = new int[num_len];

Random rnd = new Random();
int index = 0;
//заполняем массив "интересными числами"
while (index < num_len)
{
    int Number = rnd.Next(1,100000);
    //проверяем, выполняется ли условие "интересности", вызывая метод, описанный выше
    if (Array(Number) == 1)
    {
        array_number[index] = Number;
        index++;
    }
}

//Выводим получившийся массив
for (index = 0; index < num_len; index++)
{
    Console.Write($"{array_number[index]} ");
}

Console.WriteLine();
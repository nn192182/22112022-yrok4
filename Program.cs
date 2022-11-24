//Напишите программу , которая принимает на вход число (А)
// и выдает сумму чисел от 1 до А.
// 1. Возвратный метод
/*
void MetFindSum(int a)
{
    int summa = 0;
    for (int current = 1; current <= a; current++)
{
        summa +=current;  //suma= suma+ current
}
Console.WriteLine($"Summ of elements from 1 to {a} is {summa}");
}
Console.WriteLine("Input your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());
MetFindSum(user_num);
*/
// int/double, bool/Met2(){...return a;}
// невозвратный метод
/*
int MetFindSum2(int a)
{
    int summa = 0;
    for (int current = 1; current <= a; current++)
    {
            summa += current;  //suma= suma+ current
    }
     return summa;
}
Console.WriteLine("Input your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

int result = MetFindSum2(user_num);

Console.WriteLine($"Summ of elements from 1 to {user_num} is {result}");
*/
//Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5
/*
int CountofDigits(int number)
{
int current = 1;
// if ( number >= Math.Pow (10,index);
while (number >= 10)
{
    number = number /10; // 123 /10 -> 12/10 -> 1/10 -> 0
    current ++;
}
// current -= 1;
return current;
}

Console.WriteLine("Input number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

int count_digit;
int user_num1 = (-1) * user_num;
if (user_num >= 0)
   count_digit = CountofDigits(user_num);
else 
    user_num1 = (-1)* user_num;  //*= += -+ user_num * (-1) user_name = user_num +(-1) user_name = user_num -(-1)
    count_digit = CountofDigits(user_num);

Console.WriteLine($"Entered number {user_num} -> {count_digit}");     


// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.
//4 -> 24
//5 -> 120
/*
void Factorial (int n)
{
    int multi = 1;   //5 -> 120 multi> n multi*2 *3
    for (int cur = 1; cur <= n; cur++)
    {
        multi *= cur;
    }
    Console.WriteLine($"{n} -> {multi}");
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine()); // -5

if(number < 0)
{
    while (number < 0)
    {
    Console.WriteLine("Pls, input POSITVE int number ");
    number = Convert.ToInt32(Console.ReadLine());
    }
}    
else {
    Factorial(number);
}
*/

//Напишите программу, которая выводит массив из 8 элементов
//заполненный нулями и единицами в случайном порядке
// [1,0,1,1,0,1,0,0]
/*
int [] CreatNewArray (int size)
{
    int [] array = new int [size];// int(1) тип данных массива [] array - имя массива new int[размер массива] - резерврованте памяти
    for (int i = 0; i < size; i++)
         array [i] = new Random().Next(0,2); // (min, max +1)
    return array;
}

void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
}

Console.Write("Input count of elements: ");
int count_of_elem = Convert.ToInt32(Console.ReadLine());



int [] array1 = CreatNewArray(count_of_elem);
ShowArray(array1);
//ShowArray(CreatNewArray(count_of_elem));
*/
// Домашнее задание 
// Задача 29. Напишите программу, которая задает массив из 8 элементов и выводит их на экран
//1,2,5,7,19->[1,2,5,7,19]
//6,1,33 ->[6,1,33]
/*
int [] CreatNewArray (int size, int min, int max)
{
    int [] array = new int [size];// int(1) тип данных массива [] array - имя массива new int[размер массива] - резерврованте памяти
    for (int i = 0; i < size; i++)
         array [i] = new Random().Next(min, max +1); // (min, max +1)
    return array;
}

void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
}

Console.Write("Input count of elements: ");
int count_of_elem = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value of elements: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value of elements: ");
int minValue = Convert.ToInt32(Console.ReadLine());



int [] array1 = CreatNewArray(count_of_elem, minValue, maxValue);
ShowArray(array1);
*/
//ShowArray(CreatNewArray(count_of_elem));

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
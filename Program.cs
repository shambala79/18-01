// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
// натуральную степень B. (Задачи, решенные через Math.Pow, будут отправлены на переделку, 
// так как задача стоит в том, чтобы написать цикл)

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine ("Введите натуральное число А: "); 
int A = int.Parse(Console.ReadLine()!); 
Console.WriteLine ("Введите число В: "); 
int B = int.Parse(Console.ReadLine()!); 

Console.WriteLine($"Число A в степени B: {GetPower(A, B)}"); 

int GetPower(int A, int B)
{
int Power = 1; 
for (int i = 1; i <= B; i++) 
{ 
    Power = Power * A; 
}
return Power; 
}


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine ("Введите число: "); 
int num = int.Parse(Console.ReadLine()!); 

Console.WriteLine($"Сумма цифр в числе {num}: {GetSum(num)}"); 

int GetQuantity (int A) 
{ 
    int Quantity = 0; 
    if (A == 0) return 1; 
    while (A > 0) 
    {Quantity = Quantity + 1; A = A / 10;} 
    return Quantity; 
} 

int GetSum(int num)
{

 int sum = 0; 
for (int i = 1; i <= GetQuantity (num); i++) 
{ 
    sum = sum + ((num*10)/ GetPower (10, i))%10; 
}
return sum; 
}

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

int[] Array = GetArray(8); 
Console.WriteLine($"[{String.Join("; ", Array)}]"); 
 
int[] GetArray (int size) 
{ 
    int[] Array = new int[size]; 
    for (int i = 0; i < size; i++) 
    { 
        Array[i] = new Random().Next(999); 
    } 
    return Array; 
}
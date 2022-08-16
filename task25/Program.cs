//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

System.Console.Clear();

void DegreeOfNumber (int numberA, int numberB)
{
    int result = 1;
    int count = 0;
 while (count < numberB)
 {
 result *=numberA;  
 count ++;
 }
 System.Console.WriteLine($"Число {numberA} в степени {numberB} = {result}");
}

System.Console.WriteLine("Введите первое число");
int numberA = int.Parse(System.Console.ReadLine()!);

System.Console.WriteLine("Введите степень в которую будем возводить первое число");
int numberB = int.Parse(System.Console.ReadLine()!);

DegreeOfNumber(numberA,numberB);
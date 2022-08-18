//Задача 27: Напишите программу, которая принимает 
//на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

System.Console.Clear();


  int SumDigitsInNumber(int userNumber)
  {
    int sum = 0;
    int digit = 0;
    int count = 0;
    
    while (count < userNumber)
    { 
        if (userNumber % 10 == 0)
            userNumber /= 10;
        digit = userNumber % 10;
        sum +=digit;
        userNumber /= 10;
        count++; 
    }
    return sum;
  }

System.Console.WriteLine("Введите любимое число");
int userNumber = int.Parse(System.Console.ReadLine()!);

System.Console.WriteLine($"Сумма цифр вашего числа = {SumDigitsInNumber(userNumber)}");
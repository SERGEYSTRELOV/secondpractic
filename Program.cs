//int num = new Random().Next(10,100); //(10. 100)

//int secondDigit = num % 10; //
//int firstDigit = num / 10;
//int max = secondDigit;

//if (firstDigit > secondDigit)
//max = firstDigit;

//Console.WriteLine($"В числе {num} максимальная цифра {max}");

//int MaxDigit(int num)
//{
   // int secondDigit = num % 10; //
    //int firstDigit = num / 10;
    //int max = secondDigit;

    //if (firstDigit > secondDigit)
      //  max = firstDigit;

       //return max;
//}

//int number = new Random().Next(10,100); //(10. 100)
//int maxDigit = MaxDigit(number);

//Console.WriteLine($"В числе {number} максимальная цифра {maxDigit}");


Console.Clear();
Console.WriteLine("Задача 10 ");
Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);



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


//Console.Clear();
//Console.WriteLine("Задача 10 ");
//Console.Write("Введи трёхзначное число: ");
//int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
//string stringNumber = Convert.ToString(threeDigitNumber);
//Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);

//Console.WriteLine("Задача 13 ");

//Console.Write("Введи число: ");
//int anyNumber = Convert.ToInt32(Console.ReadLine());
//string anyNumberText = Convert.ToString(anyNumber);
//if (anyNumberText.Length > 2){
  //Console.WriteLine("третья цифра -> " + anyNumberText[2]);
//}
//else {
 // Console.WriteLine("-> третьей цифры нет");
//}

Console.WriteLine("Задача 15 ");

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);



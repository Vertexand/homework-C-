// ДЗ Задача 13: Напишите программу, которая выводит третью цифру заданного
// // числа или сообщает, что третьей цифры нет. 645 -> 5; 78 -> третьей цифры нет; 32679 -> 6;
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);// модуль числа
if(number<100)
{
    Console.WriteLine("3-й цифры нет");
}
else
{
    while(number >= 1000)
    {
        number/=10;
    }
    int digit3 = number % 10;// % остаток 
    Console.WriteLine(digit3);// условное слово digit3? можно любое? результат = остаток 
}
// __________________________
// Console.Write("Введите число: "); //13 зад. 3 вар, не работает
// string numberStr = Console.ReadLine();// Str только чтение ,если строку конверт.shar[]- можно запис.
// int digitIndex = 2;//  доп переменная = 2 т.е. первые две позиции в числе

// if (numberStr[0] == -)// ковычку не могу постав  , индекс 0 = минусу, 
// {
//     digitIndex++;
// }
  
// if (numberStr.Length < digitIndex + 1)
// {
//     Console.WriteLine("3-й цифры нет");
// }
// else
// {
//     Console.WriteLine(numberStr[digitIndex]);
// }
// строка str- урезанный массив символов(чаров) только для чтения.
// _________________________
// Console.Write("Введите число: "); // 13 зад. 2 вар работает
// string numberStr = Console.ReadLine();// string number - число не сконв со строки 

// if (numberStr.Length < 3)
// {
//     Console.WriteLine("3-й цифры нет");
// }
// else
// {
//     Console.WriteLine(numberStr[2]);//(numberStr[2])выводим индекс [2] от numberStr
// } //сем4 27.30


// lesson 2 tack 12: Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
// Console.WriteLine("введите число 1");// вар 1 сработало
// int number1 = Convert.ToInt32(Console.ReadLine());// Почему numberA, а не 1?
// Console.WriteLine("введите число 2");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int number = number1%number2; // создали переменную mod 
// if (number == 0)
// {
//     Console.WriteLine("кратно");    
// }
// else
// {
//     Console.WriteLine($"не кратно, остаток {number}");  
// }

// Console.Write("введите число 1  ");// tack 12 вар 2 Иван. сработало
// int numberA = Convert.ToInt32(Console.ReadLine());// Почему numberA, а не 1? short есть псевдоним int16
// Console.Write("введите число 2  ");
// //string text = Console.ReadLine(); // строка не конв в число
// int numberB = Convert.ToInt32(Console.ReadLine());// ..ToInt32(text); а теперь стр в число
// int mod = numberA % numberB; // создали переменную mod 
// if (mod == 0)
// {
//     Console.WriteLine("кратно");    
// }
// else
// {
//     Console.WriteLine($"не кратно, остаток {mod}");  
// }




// lesson 2 tack 14: Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// lesson 2 tack 16: Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
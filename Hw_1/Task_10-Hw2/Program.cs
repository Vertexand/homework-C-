///ДЗ Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
// вторую цифру этого числа. 456 -> 5; 782 -> 8; 918 -> 1;
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit2 = number/10%10;
Console.WriteLine($"Вторая цифра числа - {digit2}");



// зад 9 урок 2 вар 1: Нап. программу, которая выводит случ. число из отр. [10,99]
// и показывает найбольшую цифру числа. 78 -> 8, 85 -> 5.
// int number = new Random().Next(10, 100); //[10, 99) получить случ число
// Console.WriteLine(number);// вывод случ числа
// int digit2 = number %10;
// int digit1 = number / 10;
// Console.WriteLine("Первая цифра числа -" + digit1);// + digit1 без + не работает
// Console.WriteLine("Вторая цифра числа -" + digit2);// обращение на прямую к переменной-кавыч не надо
// if(digit1>digit2)
// {
//     Console.WriteLine("Первая цифра найбольшая");
// }
// else
// {
//     Console.WriteLine("Вторая цифра найбольшая");
// } 

// зад 9 урок 2 вар 2
// int number = new Random().Next(10, 100); //[10, 99) получить случ число
// Console.WriteLine($"Случайное число = {number}");// вывод случ числа
// int digit2 = number %10;
// int digit1 = number / 10;
// Console.WriteLine($"Первая цифра числа - {digit1}");// digit1  это локальная переменная
// Console.WriteLine($"Вторая цифра числа - {digit2}");// обращение на прямую к переменной-кавыч не надо
// if(digit1>digit2)
// {
//     Console.WriteLine($"{digit1} найбольшая");
// }
// else
// {
//     Console.WriteLine($"{digit2} найбольшая");
// }

// lesson 2 Task 11: Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа. 456 -> 46    782 -> 72
// int number = new Random().Next(100, 1000); мой работает
// Console.WriteLine($"Случайное число = {number}");
// int digit2 = number %10;
// int digit1 = number / 100;
// Console.WriteLine($"без второй цифры - {digit1}{digit2}");

// int number = new Random().Next(100, 1000); //олег. работает
// Console.WriteLine(number); // Console.WriteLine(%"случайное число - {number}");
// int number1 = number%10;
// int number2 = number/100;
// Console.WriteLine(number2*10 + number1); // в () одно число без имени, не переменная не можем обращаться к цифре

// int number = new Random().Next(100, 1000); //олег. работает
// Console.WriteLine($"случайное число - {number}");
// int number1 = number%10;
// int number2 = number/100;
// Console.WriteLine($"Ответ {number2}{number1}");

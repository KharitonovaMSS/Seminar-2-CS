// Напишите программу, которая выводит трехзначное число и удаляет среднюю цифру

int randomNum = new Random().Next(100,1000);
Console.WriteLine(randomNum);
// 238
int num = (randomNum / 100) * 10 + randomNum % 10;
Console.WriteLine(num);

// See https://aka.ms/new-console-template for more information

string fullName = "Орлова Анна Сергеевна";
byte age = 23;
string email = "orlova.@mail.ru";
double pointProg = 5.5;
double pointMath = 7.6;
double pointPhys = 4.8;

string pattern = 
    "Ф.И.О.: {0} " +
    "Возраст: {1} "+
    "Email: {2} "+
    "Баллы по програмированию: {3} "+
    "Баллы по математике: {4} "+
    "Баллы по физике: {5} ";

Console.WriteLine(pattern,
    fullName,
    age,
    email,
    pointProg,
    pointMath,
    pointPhys);
Console.ReadKey(true);


double allPoint = pointProg + pointMath + pointPhys;
Console.WriteLine("Сумма баллов: " + allPoint);
Console.ReadKey(true);


double averPoint = allPoint / 3;
Console.WriteLine("Средний балл: " + averPoint);
Console.ReadKey(true);
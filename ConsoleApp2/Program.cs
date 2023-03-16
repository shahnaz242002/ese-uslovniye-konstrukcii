using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Пользователь должен вести пароль");
string parol1 = Console.ReadLine();
string parol2=Console.ReadLine();
if(parol1==parol2)
{
    Console.WriteLine("регистрация прошла успешно");
}
else
{
    Console.WriteLine("регистрация не прошла успешно");
}

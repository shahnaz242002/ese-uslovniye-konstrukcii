using System.Text;
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Сколько гостей");
int qost =Convert.ToInt32(Console.ReadLine());
if(qost<=2)
{
    Console.WriteLine("Присаживайтесь к маленькому столику");
}
if(qost>2 && qost<=4)
{
    Console.WriteLine("Присаживатесь к среднему столику");
}
if(qost>4 && qost<=8)
{
    Console.WriteLine("Присаживайтесь к большому столику");
}
else
{
    Console.WriteLine("Для вас нет подходящего места");
}
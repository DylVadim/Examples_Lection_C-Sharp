using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine() ?? "";

if(username == "Маша")
{   
    Console.WriteLine("УРА! Это Маша!");
}
else
{
        Console.WriteLine("Привет, ");
        Console.WriteLine(username);
    }
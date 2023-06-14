Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine() ?? "";

if(username == "Masha")
{   
    Console.WriteLine("YES! this is Masha!");
}
else
{
        Console.WriteLine("Hello, ");
        Console.WriteLine(username);
    }
Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "olga")
{
    Console.WriteLine("Ура, это же Olga!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
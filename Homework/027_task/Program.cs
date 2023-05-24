/*while (true)
{
    Console.Write("Enter a number: ");
    string user_input;
    user_input = Console.ReadLine();
    if (int.TryParse(user_input, out int number))
    {
        Console.WriteLine("You have entered a number.");
        break;
    }
        Console.WriteLine("That's not a number!");
}*/ // Я вообще не понял почему, но эта переменная была вне контекста проекта

Console.Write("Enter a number: ");
string user_input;
user_input = Console.ReadLine();
int res = 0;
for (int i = 0; i < user_input.Length; i++)
{
    int elem = System.Convert.ToInt32(user_input[i]);
    res = res + elem;
    Console.WriteLine($"elem: {user_input[i]}; sum: {res}");
}
Console.WriteLine($"Result => {res}");


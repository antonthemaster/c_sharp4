int MultiplyFromZero(int num)
{
    int result = 0;
    for (int i = 1; i <= num; i++)
    {
        result *= i;
    }
    return result;
}


int user_input;
user_input = System.Convert.ToInt32(Console.ReadLine());
int result = MultiplyFromZero(user_input);
Console.WriteLine(result);


int GradesOfNumber (int number)
{
    string string_number = System.Convert.ToString(number);
    int result = string_number.Length;
    return result;
}

Console.Write("Enter a digit: ");
int user_input = System.Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GradesOfNumber(user_input));

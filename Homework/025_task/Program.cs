int fst_digit;
fst_digit = System.Convert.ToInt32(Console.ReadLine());
int scd_digit;
scd_digit = System.Convert.ToInt32(Console.ReadLine());
int res = fst_digit;
for (int i = 1; i < scd_digit; i++)
{
    res *= fst_digit;
}
Console.WriteLine($"Result -> {res}");

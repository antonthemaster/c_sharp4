int[] ZerosOnes()
{
    int[] result = new int[8];
    for (int i = 0; i != 7; i++)
    {
        int coin = new Random().Next(10000);
        result[i] = coin;
    }
    return result;
}
Console.Write("[");
Console.Write(String.Join(", ", ZerosOnes()));
Console.WriteLine("]");

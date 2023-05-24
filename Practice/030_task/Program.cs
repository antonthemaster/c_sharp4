int[] ZerosOnes()
{
    int[] result = new int[8];
    for (int i = 0; i != 7; i++)
    {
        int coin = new Random().Next(2);
        result[i] = coin;
    }
    return result;
}

Console.WriteLine(ZerosOnes());
Console.WriteLine(String.Join(", ", ZerosOnes()));

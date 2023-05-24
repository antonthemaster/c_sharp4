int SumFromZero(int num)
{
    int result = 0;
    for (int i = 0; i < num + 1; i++){
        result = result + i;
    }
    
    return result;
}

Console.WriteLine(SumFromZero(7));


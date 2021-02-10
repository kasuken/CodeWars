public static int GetAverage(int[] marks)
{
    int sum = 0;

    for (int i = 0; i < marks.Length; i++)
    {
        sum += marks[i];
    } 
    
    int avg = sum / marks.Length;

    return avg;
}


Console.WriteLine(GetAverage(new int[]{5,10}));
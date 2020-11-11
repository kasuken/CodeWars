public static int? AdjacentElementsProduct(int[] array)
{
    int? max = null;

    for (int i = 0; i < array.Length - 1; i++)
    {
        if (max == null || array[i] * array[i + 1] > max)
            max = array[i] * array[i + 1];
    } 
    
    return max;
}
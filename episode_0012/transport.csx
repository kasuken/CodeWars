public static int RentalCarCost(int d)
{
    var cost = 40;

    cost *= d;

    if (d >= 3 && d < 7)
        cost -= 20;

    if (d >= 7)
        cost -= 50;    

    return cost;
}
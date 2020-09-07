function getSum(a, b) {
    if (a == b) return a;

    var min, max;
    if (a < b) {
        min = a; max = b;
    } else {
        min = b; max = a;
    }
    
    var sum = 0;
    do {
        sum += min;
    } while (min++ != max); return sum;
}
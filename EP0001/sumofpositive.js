function positiveSum(arr) {
  
    if (arr.length == 0)
    {
        console.log("empty");
        return 0;
    } 

    let result = 0;

    for (let index = 0; index < arr.length; index++) {
        const element = arr[index];
        
        if (element > 0){
            result += element;
        }
    }

    console.log(result);
    return result;
}

positiveSum([1,2,3,4,5]);
positiveSum([1,-2,3,4,5]);
positiveSum([]);
positiveSum([-1,-2,-3,-4,-5]);
positiveSum([-1,2,3,4,-5]);
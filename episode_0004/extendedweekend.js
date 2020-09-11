function solve(a, b){
    var contamesi = 0;
    
    for (let year = a; year <= b ; year++) {
        for (let month = 0; month < 12; month++) {
            var date = new Date(year, month,1);
            if (date.getDay() == 4 && (new Date(year, month, 0)).getDate() == 30)
            {
                console.log(date);
                contamesi++;
            }
        }
    }
    return contamesi;
}

solve(2016,2020);
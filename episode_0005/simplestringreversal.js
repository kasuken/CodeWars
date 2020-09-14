function solve(str){

    let result = '';
    let spacePositions = [];

    for (let index = 0; index < str.length; index++) {
        if (str[index] == ' ')
        {
            spacePositions.push(index);
        }
    }

    for (let index = str.length - 1; index >= 0; index--) {

        if (spacePositions.includes(str.length - index -1))
        {
            result += ' ';
        }

        if (str[index] != ' ')
        {
            result += str[index];  
        }        
    }

  return result;
 }

 console.log(solve("your code"));
 console.log(solve("your code rocks"));
 console.log(solve("i love codewars"));
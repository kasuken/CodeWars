function solution(str){
    let result = '';
  
    for (let index = str.length - 1; index >= 0; index--) {
        result += str[index];  
    }

  return result;
}

console.log(solution('hello'));
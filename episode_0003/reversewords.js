function reverseWords(str) {
    
    var reversedString = "";

    var splittedString = str.split(" ");

    splittedString.forEach(element => {
        for (let index = element.length - 1; index >= 0; index--) {
            const char = element[index];
            
            reversedString += char;
        }
        reversedString += " ";
    });

    reversedString = reversedString.trim();
}

console.log(reverseWords("I Love Tencar!"));
console.log(reverseWords("We Love Gren"));
console.log(reverseWords("We love Triathlon"));
console.log(reverseWords("Come se fosse Antani"));
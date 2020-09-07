// Return the number (count) of vowels in the given string.
// We will consider a, e, i, o, u as vowels for this Kata (but not y).
// The input string will only consist of lower case letters and/or spaces.

function getCount(str) {
    var vowelsCount = 0;

    var vowels = "aeiou";

    for (let index = 0; index < str.length; index++) {
        if (vowels.indexOf(str[index]) !== -1) {
            vowelsCount += 1;
        }
    }

    return vowelsCount;
}

console.assert(getCount("abracadabra") == 5);
console.assert(getCount("andreagiunta") == 6);
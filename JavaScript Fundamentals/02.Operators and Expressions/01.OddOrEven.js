function isOdd(number) {
    var result;
    if (number % 2) {
        result = 'odd' + ' ' + number;
        return result;
    } else {
        result = 'even' + ' ' + number;
        return result;
    }
}

console.log(isOdd(3));


// Implement a javascript function that uses an expression to check if given integer is odd or even,
// and prints "even NUMBER" or "odd NUMBER", where you should print the input number's value instead of NUMBER.

// The functions should look like that:
// function solve(args) {
//     // your code goes here
// }
// Input

// You will receive the input as an array with only one element - the integer number as a javascript string.
// Output

// Output a single value - if the number is even, output even, followed by a space and the value of the number.
// Otherwise, print odd, again followed by a space and the number's value. See the sample tests.
// You can use console.log to print the results or you can use return to return the answer. Both are correct.
// Constraints

// The input number will always be a valid integer number.
// The input number will always be in the range [-30, 30].
// Time limit: 0.2s
// Memory limit: 16MB
// Sample tests

// Input	Output
// 3		odd 3
// 2		even 2
// -2		even -2
// -1		odd -1
// 0		even 0
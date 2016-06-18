function solve(params) {
    var input = Number(+params);

    var third = Math.floor(input / 100);
    third = third % 10;

    if (third === 7) {
        console.log('true');
    } else {
        console.log('false ' + third);
    }
}

solve(['9999799']);


// Description
//
// Implement a javascript function that takes an array with a single element - an integer N as parameter and prints true if the third digit of N is 7, or "false THIRD_DIGIT", where you should print the third digits of N.
//
//     The counting is done from right to left, meaning 123456's third digit is 4.
//
// Input
//
// The input will always consist of an array with exactly one element, the integer N as a string.
//
//     Output
//
// The output should be a single line - print whether the third digit is 7, following the format described above.
//     You can use console.log to print the results or you can use return to return the answer. Both are correct.
//
//     Constraints
//
// N will always be valid non-negative integer number.
//     Time limit: 0.2s
// Memory limit: 16MB
//
// Sample tests
// Input 	Output
// 5 	false 0
// 701 	true
// 9703 	true
// 877 	false 8
// 777877 	false 8
// 9999799 	true
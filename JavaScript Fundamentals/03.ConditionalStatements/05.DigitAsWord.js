function solve(args) {
    var input = +args[0];

    switch(input){
        case 0: return 'zero'; break;
        case 1: return 'one'; break;
        case 2: return 'two'; break;
        case 3: return 'three'; break;
        case 4: return 'four'; break;
        case 5: return 'five'; break;
        case 6: return 'six'; break;
        case 7: return 'seven'; break;
        case 8: return 'eight'; break;
        case 9: return 'nine'; break;

        default: return 'not a digit';
    }

}

console.log(solve(['22']));
console.log(solve(['0']));
console.log(solve(['7']));




// Description
//
// Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). Print not a digit in case of invalid input. Use a switch statement.
//     Input
//
//     The input will consist of an array containing a single string
//
//         Output
//
//         The output should be a single line
//
//         Constraints
//
//         Time limit: 0.2s
//         Memory limit: 16MB
//
//         Sample tests
//         Input 	Output
//         2 	two
//         1 	one
//         0 	zero
//         5 	five
//     -0.1 	not a digit
//         hi 	not a digit
//         9 	nine
//         10 	not a digit
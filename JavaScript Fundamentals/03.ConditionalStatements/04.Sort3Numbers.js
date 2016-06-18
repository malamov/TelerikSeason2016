function solve(args) {
    var a = +args[0],
        b = +args[1],
        c = +args[2],
        first,
        second,
        third;

    if(a >= b && a >= c){
        first = a;
        if(b >= c){
            second =  b;
            third = c;
        } else{
            second = c;
            third = b;
        }
    }

    if(b >= a && b >= c){
        first = b;
        if(a >= c){
            second =  a;
            third = c;
        } else{
            second = c;
            third = a;
        }
    }

    if(c >= b && c >= c){
        first = c;
        if(a >= b){
            second =  a;
            third = b;
        } else{
            second = b;
            third = a;
        }
    }


return first + ' ' + second + ' ' + third;
}



console.log(solve(["9","2","2"]));
console.log(solve(["-1.1","-0.2","-0.326292"]));




// Description
//
// Sort 3 real values in descending order. Use nested if statements.
//
//     Note: Don’t use arrays and the built-in sorting functionality.
//     Input
//
// The input will consist of an array containing three values represented as strings
//
// Output
//
// The output should be a single line containing three numbers separated by spaces
//
// Constraints
//
// Time limit: 0.2s
// Memory limit: 16MB
//
// Sample tests
// Input 	Output
// 5
// 1
// 2 	5 2 1
// -2
// -2
// 1 	1 -2 -2
// -2
// 4
// 3 	4 3 -2
// 0
// -2.5
// 5 	5 0 -2.5
// -1.1
// -0.5
// -0.1 	-0.1 -0.5 -1.1
// 10
// 20
// 30 	30 20 10
// 1
// 1
// 1 	1 1 1


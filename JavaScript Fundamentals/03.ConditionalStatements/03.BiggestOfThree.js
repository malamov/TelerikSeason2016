function solve(args) {
    var a = +args[0],
        b = +args[1],
        c = +args[2],
        biggest;

    if(a > b ){
        if(a > c){
            return a;
        }
        else{return c;}
    }
    if(b > a ){
        if(b > c){
            return b;
        }
        else{return c;}
    }
    if(c > b ){
        if(c > a){
            return a;
        } else{return a;}
    }



}

console.log(solve(['-2','4','3']));




// Description
//
// Write a script that finds the biggest of three numbers. Use nested if statements.
//     Input
//
//     The input will consist of an array containing three values represented as strings
//
// Output
//
// The output should be a single line containing a number
//
// Constraints
//
// Time limit: 0.2s
// Memory limit: 16MB
//
// Sample tests
// Input 	Output
// 5
// 2
// 2 	5
// -2
// -2
// 1 	1
// -2
// 4
// 3 	4
// 0
// -2.5
// 5 	5
// -0.1
// -0.5
// -1.1 	-0.1

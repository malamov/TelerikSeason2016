function solve(args) {
    var  a = +args[0],
         b = +args[1],
         c= +args[2],
         d= +args[3],
         e= +args[4],
         biggest = a;

        if(biggest < b){
            biggest = b;
        }
        if(biggest < c){
         biggest = c;
        }
        if(biggest < d){
        biggest = d;
         }
         if(biggest < e) {
             biggest = e;
         }
    return biggest;



}

console.log(solve(['5','222','2','4','1']));



// Description
//
// Write a script that finds the biggest of given 5 variables. Use nested if statements.
//     Input
//
//     The input will consist of an array containing five values represented as strings
//
// Output
//
// The output should be a single line containing the answer
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
// 2
// 4
// 1 	5
// -2
// -22
// 1
// 0
// 0 	1
// -2
// 4
// 3
// 2
// 0 	4
// 0
// -2.5
// 0
// 5
// 5 	5
// -3
// -0.5
// -1.1
// -2
// -0.1 	-0.1


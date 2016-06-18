function solve(args) {
    var a = +args[0],
        b = +args[1],
        c = +args[2];
    var positiveProduct = true;

    if(a == 0|| b == 0 || c == 0){
        return 0;
    }

    if(a < 0){
        positiveProduct = !positiveProduct;
    }
    if(b < 0){
        positiveProduct = !positiveProduct;
    }
    if(c < 0){
        positiveProduct = !positiveProduct;
    }
   if(positiveProduct){
       return "+";
   } else{
       return"-";
   }
}

console.log(solve(["5","2","-2"]));





// Description
//
// Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. Use a sequence of if operators.
//     Input
//
//     The input will consist of an array containing three values - a, b and c represented as strings
//
// Output
//
// The output should be a single line containing +, - or 0
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
// 2 	+
// -2
// -2
// 1 	+
// -2
// 4
// 3 	-
// 0
// -2.5
// 4 	0
// -1
// -0.5
// -5.1 	-


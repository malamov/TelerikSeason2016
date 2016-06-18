function solve(args){
    var width = parseFloat(args[0]);
    var heigth = parseFloat(args[1]);
    function CalculateArea(a,b) {
        return  (a*b);
    }
    function CalculatePerimeter(a,b) {
       return  Math.round((2*a + 2*b)*100)/100;
    }

    console.log(  CalculateArea(width,heigth).toFixed(2) + " " + CalculatePerimeter(width,heigth).toFixed(2))
}

solve(['2.5','3']);

// Description
//
// Implement a javascript function that takes an argument array as a parameter and calculates rectangle’s area and perimeter by given width and height. The width and height will both be passed in the argument array.
//     Input
//
// The array that will be passed as argument will always have exactly 2 elements:
//     The first element - a floating-point number that will represent the width of the rectangle.
//     The second element - another floating-point number that will represent the height of the rectangle.
//
//     Output
//
// Output a single line - the rectangle's area and perimeter, separated by a whitespace.
// Print the area and perimeter values with exactly 2-digits precision after the floating point.
//     You can use console.log to print the results or you can use return to return the answer. Both are correct.
//
//     Constraints
//
// The width and height will always be valid floating-point numbers.
//     Time limit: 0.2s
// Memory limit: 16MB
//
// Sample tests
// Input 	Output
// 2.5
// 3 	7.50 11.00
// 5
// 5 	25.00 20.00
// 3
// 4 	12.00 14.00
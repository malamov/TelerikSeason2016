function solve(args) {
    var input = +args[0],
        index = 0;
    var arr = [];
    for (index = 0; index < input; index++) {
        arr[index] = index * 5;
        console.log(arr[index]);
    }
}
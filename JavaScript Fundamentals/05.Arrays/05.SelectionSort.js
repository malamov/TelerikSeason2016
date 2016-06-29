function solve(args) {
    var len = args.length,
        sortedArr = [];

    for (var j = 0; j < len; j += 1) {
        var min = Number.MAX_SAFE_INTEGER ;
        for (var i = 0; i < len; i += 1) {
            if (min > args[i + 1]) {
                min = args[i + 1];
            }
        }
        if(args.length == 1){
            min = args[0];
        }
        sortedArr.push(min);
        var index = args.indexOf(min);
        args.splice(index, 1);
    }
    console.log(sortedArr);

}
solve(['10', '36', '10', '1', '34', '28', '38', '31', '27', '30', '20']);
solve([ '27', '1', '20']);
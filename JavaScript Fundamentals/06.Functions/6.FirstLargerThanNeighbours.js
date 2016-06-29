function CheckNeighbours(input) {
    var numArr = input[1].split(' ').map(Number),
        len = numArr.length,
        IndexOfAppearance ;

    for(var i = 1; i < len - 1 ; i += 1){
        if(numArr[i] > numArr[i + 1] && numArr[i] > numArr[i - 1]){
            IndexOfAppearance = i;
            break;
        }
    }
    console.log(IndexOfAppearance);
}

CheckNeighbours(['6','-26 -25 -28 31 2 27']);
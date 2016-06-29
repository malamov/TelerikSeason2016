function CountAppearance(input) {
      var  searchedNum = input[2],
        arrOfNums = input[1].split(' '),
        len = arrOfNums.length,
        counter = 0;

    for(var i = 0; i < len; i += 1){
        if(arrOfNums[i] == searchedNum){
            counter += 1;
        }
    }
    console.log(counter)
}

// CountAppearance([ '8', '28 6 21 6 -7856 73 73 -56', '73' ] );
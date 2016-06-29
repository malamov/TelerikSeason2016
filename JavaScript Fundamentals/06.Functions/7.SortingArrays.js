function SortArr(input) {
    var arrOfNumbers = input[1].split(' ').map(Number),
        output = String(),
        max;

    FindMax(arrOfNumbers);
        function FindMax(arr) {
            var arrGiven = arr,
                len = arr.length;
                for(var i = 0; i< len; i += 1){
                    max =Math.max.apply( Math, arrGiven);
                   indexOfMax = arrGiven.indexOf(max);
                   output =  max + ' ' + output ;
                    arrGiven.splice(indexOfMax, 1);
                }

        }
    output = output.trim(' ');
        console.log(output);
}



SortArr(['10','36 10 1 34 28 38 31 27 30 20']);

// koda e qko nechetim znam
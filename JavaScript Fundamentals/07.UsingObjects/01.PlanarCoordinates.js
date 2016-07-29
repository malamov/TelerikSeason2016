function CheckIfFormTriangle(inputNum) {
    var firstLine = inputNum.slice(0,4),
        secondLine = inputNum.slice(4,8),
        thirdLine = inputNum.slice(8,12);

        function CalculateLength(args) {
        var x1 = args[0],
            y1 = args[1],
            x2 = args[2],
            y2 = args[3],
            len;
        len = (Math.sqrt(Math.pow((x1-x2),2)+ Math.pow((y1-y2),2)));
        len =Math.round(len * 100) / 100;
             return len;
        }

      var firstDist = (CalculateLength(firstLine)),
          secondDist = (CalculateLength(secondLine)),
          thirdDist = (CalculateLength(thirdLine));

    console.log(firstDist);
    console.log(secondDist);
    console.log(thirdDist);


    if(firstDist + secondDist < thirdDist ){
        console.log('Triangle can not be built');

    }
   else  if(firstDist + thirdDist < secondDist ){
        console.log('Triangle can not be built');
    }
   else if(thirdDist + secondDist < firstDist ){
        console.log('Triangle can not be built');
    }else{
        console.log('Triangle can be built');
    }
}




CheckIfFormTriangle([
    '5', '6', '7', '8',
    '1', '2', '3', '4',
    '9', '10', '11', '12'
]);
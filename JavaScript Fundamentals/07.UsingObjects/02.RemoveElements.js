function ext(args) {
    var index = 0,
        input = [];

    for (var i = 0; i < args.length; i += 1) {
        input[i] = args[i];
    }

    Array.prototype.remove = function remove(par) {
        index = this.indexOf(par);
        for (var i = 0; i < this.length; i += 1) {
            if (index !== -1) {
                this.splice(index, 1);
            }
            index = this.indexOf(par, index + 1);
        }
    };

    input.remove(input[0]);

    for (i = 0; i < input.length; i += 1) {
        console.log(input[i]);
    }
}




// Array.prototype.RemoveFirstElement = function () {
//     let RemovedSymbolArr = Array(this);
//     var arguments = RemovedSymbolArr[0];
//     for(var i =  RemovedSymbolArr.length-1; i>0; i--){
//         var v =  this[i];
//         for(var j = 1; j <arguments.length; j++){
//             if(v == arguments[j]){
//                 RemovedSymbolArr =  RemovedSymbolArr.splice(i,1);
//             }
//         }
//     }
//
//     return RemovedSymbolArr;
// };
//
// var arr = [ '1', '2', '3', '2', '1', '2' ,  '2' ];
// console.log(arr.RemoveFirstElement());
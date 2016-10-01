function oddEven(num) {

    if (num % 2 == 0){
        console.log("even");
    } else if(num % 2 == Math.round(num % 2)){
        console.log("odd");
    } else {
        console.log("invalid");
    }
}
oddEven(8);
function solve(input) {
    let result =[];
    for (let i in input){
        if(i % 2 == 0){
            result.push(input[i]);
        }
    }
    console.log(result.join(' '));
}
solve(['20', '30', '40']);
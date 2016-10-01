function solve(input) {
    input = input.map(Number);
    let result =[];
    for(let num of input){
        if(num < 0){
            result.unshift(num);
        } else {
            result.push(num);
        }
    }
    console.log(result.join('\n'));
}
solve(['3', '-4', '0', '-3']);
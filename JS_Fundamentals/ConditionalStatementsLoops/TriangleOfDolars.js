function solve(input) {
    let row = Number(input[0]);
    for (let i = 1; i <= row; i++) {
        console.log(new Array(i + 1).join('$'));
    }

}
solve(['4']);
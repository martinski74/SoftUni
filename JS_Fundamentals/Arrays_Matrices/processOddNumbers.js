function solve(arr) {
    let result = arr.filter((num,i) =>i % 2 == 1)
        .map(x => x * 2)
        .reverse();
    console.log(result.join(' '));
}
solve(['10', '15', '20', '25']);
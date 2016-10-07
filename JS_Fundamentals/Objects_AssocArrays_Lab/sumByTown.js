function sumByTown(input) {
    let sum = {};
    for (let i = 0; i < input.length; i += 2) {
        let [town,income] = [input[i], Number(input[i + 1])];
        if (sum[town] == undefined) {
            sum[town] = income;
        } else {
            sum[town] += income;
        }
    }
    return JSON.stringify(sum);
}
console.log(sumByTown(
    ['Sofia','20', 'Varna','10', 'Sofia','5']
    )
);

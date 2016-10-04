function solve(input) {
    let totalSum =0;
    let products = [];
    for (let item in input){
        if (item % 2 === 1){
            totalSum += Number(input[item]);
        } else {
            products.push(input[item]);
        }
    }
    console.log(`You purchased ${products.join(', ')} for a total sum of ${totalSum}`);

}
solve(['Cola', '1.35', 'Pancakes', '2.88']);
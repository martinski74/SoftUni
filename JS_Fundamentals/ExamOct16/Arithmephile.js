function solve(input) {
    input = input.map(Number);
    let bestProduct = Number.NEGATIVE_INFINITY;
    let curProduct = 1;
    for (let i = 0; i < input.length; i++) {
        let curNum = input[i];
        if (curNum >= 0 && curNum < 10) {
            for (let j = 0; j < curNum; j++) {
                curProduct *= input[++i];
            }
            i -= curNum;
        }
        if (curProduct > bestProduct) {
            bestProduct = curProduct;
        }
        curProduct = 1;
    }
    console.log(bestProduct);
}

solve(['10',
    '20',
    '2',
    '30',
    '44',
    '123',
    '3',
    '56',
    '20',
    '24',
]);
solve(['100',
    '200',
    '2',
    '3',
    '2',
    '3',
    '2',
    '1',
    '1',
]);
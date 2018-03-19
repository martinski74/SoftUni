function solve(args) {
    let len = args[0];
    let result = new Array(len).fill(0);
    for (let i = 1; i <args.length; i++){
        let tokens = args[i].split(/\s-\s/);
        let idx = tokens[0];
        let value = tokens[1];
        result[idx] = value;
    }

    console.log(result.join('\n'));

}

solve([
    '3',
    '0 - 5',
    '1 - 6',
    '2 - 7'
]);
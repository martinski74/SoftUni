function solve(input) {
    let towns = [];
    let sums = 0;
    for (let row of input) {
        let token = row.split(' ');
        token = token.filter(s => s != '').join(' ');
        token = token.split('|');
        let town = token[1].trim();
        let num = token[2];

        towns.push(town);
        sums +=Number(num);
    }
    console.log(towns.join(', '));
    console.log(sums);
}

solve(['| Sofia           | 300',
    '| Veliko Tarnovo  | 500',
    '| Yambol          | 275']
);
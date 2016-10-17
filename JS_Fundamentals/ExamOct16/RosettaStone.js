function solve(input) {
    let len = Number(input.shift());
    let template = input.splice(0, len);
    template = template.map(row => row.split(/\s+/g).map(Number));
    let matrix = input.map(row => row.split(/\s+/g).map(Number));

    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[row].length; col++) {
            let value = matrix[row][col];
            matrix[row][col] = value + template[row % template.length][col % template[0].length];
            matrix[row][col] = findLetter(matrix[row][col]);
        }
    }
    let result = matrix.map(r=>r.join('')).join('');
    console.log(result);

    function findLetter(number) {
        let alphabet = ' ABCDEFGHIJKLMNOPQRSTUVWXYZ';
        if (number > 27) {
            number = number % 27;
        } else if (number == 27) {
            number = 0;
        }
        return alphabet[number];
    }
}

solve(['2',
    '59 36',
    '82 52',
    '4 18 25 19 8',
    '4 2 8 2 18',
    '23 14 22 0 22',
    '2 17 13 19 20',
    '0 9 0 22 22']
);
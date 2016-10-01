function equalNeighborsCount(matrixRows) {
    let matrix = matrixRows.map(row => row.split(' '));
    let neighbors = 0;
    for (let row = 0; row < matrix.length - 1; row++) {
        for (let col = 0; col < matrix[row].length; col++) {
            if (matrix[row][col] == matrix[row + 1][col]) {
                neighbors++;
            }
        }
    }
    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[row].length - 1; col++) {
            if (matrix[row][col] == matrix[row][col + 1]) {
                neighbors++;
            }
        }
    }
    console.log(neighbors);
}
solve(['test yes yo ho',
    'well done yo 6',
    'not done yet 5']
);

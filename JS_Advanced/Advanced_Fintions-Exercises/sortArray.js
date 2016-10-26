function solve(arr, order) {
    let ascSort = (a, b)=> a - b;
    let descSort = (a, b)=> b - a;

    let sortStrategies = {
        'asc':ascSort,
        'desc':descSort
    };
    return arr.sort(sortStrategies[order]);
}
console.log(solve([14, 7, 17, 6, 8], 'desc'));
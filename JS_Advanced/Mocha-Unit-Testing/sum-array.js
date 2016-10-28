function sum(arr) {
    let sum = 0;
    for (let x of arr) {
        sum += Number(x);
    }
    return sum;
}
module.exports = {sum};
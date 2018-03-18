let x = 6;
let n = 8;

function multiplyOrDevide(n, x) {
    if (x >= n) {
        return x * n;
    } else {
        return n / x;
    }
}

console.log(multiplyOrDevide(n,x));
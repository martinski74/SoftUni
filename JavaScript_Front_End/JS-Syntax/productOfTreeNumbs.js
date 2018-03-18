let x = 2;
let y = 6;
let z = -8;
let minuses = 0;

function multiply(x, y, z) {
    if (x == 0 || y == 0 || z == 0) {
        return "Positive";
    }
    if (x > 0) {
        minuses++;
    }
    if (y > 0) {
        minuses++;
    }
    if (z > 0) {
        minuses++;
    }
    if (minuses % 2 != 0) {
        return "Positive";
    } else {
        return "Negative";
    }

}

console.log(multiply(x, y, z));
function solve(num1, num2) {
    if (num1 == 0) {
        return num2;
    }
    if (num2 == 0) {
        return num1;
    }
    let result = solve(num2,num1%num2);
    return result;
}
console.log(solve(252, 105));
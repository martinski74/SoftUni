function solve(n) {
    let fib = (function () {
        let first = 0,second = 1;
        return function () {
            let temp = first;
           first = second;
            second = temp + first;
            return first;

        }
    })();

    let fibNumbers =[];
    for (let i = 0; i < n; i++) {
        fibNumbers.push(fib());
    }
    return fibNumbers;
}


console.log(solve(15));

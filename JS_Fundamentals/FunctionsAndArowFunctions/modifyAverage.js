function solve(number) {
    //number = number.map(Number);
        while (true) {
            let sum = 0;
            let avg = 1;

            for (let i = 0; i < number.length; i++) {
                sum += parseInt(number[i]);
            }
            avg = sum / number.length;
            if (avg > 5){
                break;
            } else {
                number.push(9);
            }

        }
        console.log(number.join(''));

}
solve([1, 1, 1]);
solve(['5','8','3','5']);
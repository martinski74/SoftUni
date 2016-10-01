function solve(input) {
    let num = Number(input[0]);

    for (let i = 1; i < input.length; i++) {
        switch (input[i]) {
            case 'chop':
                num = num / 2;
                console.log(num);
                break;
            case 'dice':
                num = Math.sqrt(num);
                console.log(num);
                break;
            case 'spice':
                num += 1;
                console.log(num);
                break;
            case 'bake':
                num *= 3;
                console.log(num);
                break;
            case 'fillet':
                num = num - 0.20 * num;
                console.log(num);
                break;
            default:
                break
        }
    }
}
solve(['32', 'chop', 'chop', 'chop', 'chop', 'chop']);
//solve([10, 'fillet', 'fillet', 'fillet', 'fillet', 'fillet']);
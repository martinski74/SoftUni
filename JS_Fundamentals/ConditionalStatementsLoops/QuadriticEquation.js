function solve([a,b,c]) {
    [a, b, c] = [a, b, c].map(Number);

    let discriminant = (b * b) - 4 * a * c;

    if (discriminant > 0) {
        let x1 = (-b + Math.sqrt(discriminant)) / (2 * a);
        let x2 = (-b - Math.sqrt(discriminant)) / (2 * a);
        console.log(Math.min(x1, x2));
        console.log(Math.max(x1, x2));
    }
    else if (discriminant === 0) {
        let x = -b / (2 * a);
        console.log(x);
    }
    else {
        console.log('No');
    }
}
solve(['1','-12','36']);
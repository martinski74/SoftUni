function silve(input) {
    let expretion = input[0];
    let elements = expretion.split(/[\s.();,]+/);
    console.log(elements.join('\n'));
}
silve(['let sum = 4 * 4,b = "wow";'])

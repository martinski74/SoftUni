function solve([num]) {
    let inch = Number(num);
    let foot = inch / 12;
    let rem = inch % 12;
    console.log(Math.floor(foot) + "'" + "-" + rem +'"');

}
solve([11]);
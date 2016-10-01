function solve([x, y, z, x1, y1, z1]) {
    [x, y, z, x1, y1, z1] = [x, y, z, x1, y1, z1].map(Number);
    let xPoiit = Math.pow(x1 - x, 2);
    let yPoiit = Math.pow(y1 - y, 2);
    let zPoiit = Math.pow(z1 - z, 2);
    let dist1 = Math.sqrt(xPoiit + yPoiit + zPoiit);
    console.log(dist1)
}
solve([3.5, 0, 1, 0, 2, -1]);
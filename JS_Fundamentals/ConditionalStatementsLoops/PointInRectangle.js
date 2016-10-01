function solve(input) {
    let [x,y,xMin,xMax,yMin,yMax] =input.map(Number);
    if (x >= xMin && x <= xMax && y >= yMin && y <= yMax) {
        console.log('inside');
    } else {
        console.log('outside');
    }
}
solve(['8','-1','2','12','-3','3']);
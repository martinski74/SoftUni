function solve([speed1,speed2,time]) {
    [speed1,speed2,time]=[speed1,speed2,time].map(Number);
    let dist1 = (speed1*1000)* (time/3600);
    let dist2 = (speed2 *1000)* (time/3600);
    let delta = Math.abs(dist1-dist2);
    console.log(delta);
}
solve([11, 10, 120]);
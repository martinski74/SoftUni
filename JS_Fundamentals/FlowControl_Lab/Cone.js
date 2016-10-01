function cone(input) {
    let [r,h]= input.map(Number);
    let s = Math.sqrt(r * r + h * h);
    let volume = Math.PI * r * r * h / 3;
    let area = Math.PI * r * (r + s);
    console.log("volume = "+ volume);
    console.log("area = "+area);
}
cone([10,12]);
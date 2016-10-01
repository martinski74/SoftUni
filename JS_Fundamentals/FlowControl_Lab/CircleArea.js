function area(r) {
    let area = Math.PI * r * r;

    let roundedArea = Math.round(area * 100) / 100;
    console.log(roundedArea);
}
area(5);
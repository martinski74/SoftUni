function orderRect(rectsData) {
    let rects = [];
    for(let line of rectsData){
        let rect = (function createRectangle() {
            let rect = {
                width: Number(line[0]),
                height: Number(line[1]),
                area: () => rect.width * rect.height,
                compareTo: function (other) {
                    let result = other.area() - rect.area();
                    return result || (other.width - rect.width);
                }
            };
            return rect;
        })();
        rects.push(rect);
    }
    rects.sort((a,b)=>a.compareTo(b));
    return rects;

}

console.log(orderRect([[10,5],[5,12]]));
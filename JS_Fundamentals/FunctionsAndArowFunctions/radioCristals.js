function shape(input) {

    let targetSize = Number(input[0]);
    for (let i = 1; i < input.length; i++) {
        let size = Number(input[i]);
        console.log(`Processing chunk ${size} microns`);

        let op = 'Cut';
        let times = 0;
        let cutSize = cut(size);

        while (cutSize >= targetSize || parseInt(targetSize - cutSize) === 1) {
            size = cutSize;
            times++;
            cutSize = cut(size);
        }

        if (times > 0) {
            console.log(`${op} x${times}`)
            size = wash(size);
            times = 0;
        }
        op = "Lap";
        let lapSize = lap(size);
        while (lapSize >= targetSize || parseInt(targetSize - lapSize) === 1) {
            size = lapSize;
            times++;
            lapSize = lap(size);
        }
        if (times > 0) {
            console.log(`${op} x${times}`)
            size = wash(size);
            times = 0;
        }

        op = "Grind";
        let grindSize = grind(size);
        while (grindSize >= targetSize || parseInt(targetSize - grindSize) === 1) {
            size = grindSize;
            times++;
            grindSize = grind(size);
        }
        if (times > 0) {
            console.log(`${op} x${times}`)
            size = wash(size);
            times = 0;
        }

        op = "Etch";
        let etchSize = etch(size);
        while (etchSize >= targetSize || parseInt(targetSize - etchSize) === 1) {
            size = etchSize;
            times++;
            etchSize = etch(size);
        }
        if (times > 0) {
            console.log(`${op} x${times}`)
            size = wash(size);
            times = 0;
        }

        if (targetSize - size === 1){
            size = xRay(size);
            console.log("X-ray x1");
        }
        console.log(`Finished crystal ${targetSize} microns`);
    }
    function cut(size) {
        return size / 4;
    }

    function lap(size) {
        return size * 0.8;
    }

    function grind(size) {
        return size - 20;
    }

    function etch(size) {
        return size - 2;
    }

    function xRay(size) {
        return size + 1;
    }

    function wash(size) {
        console.log("Transporting and washing")
        return Math.floor(size);

    }
}
shape(['1375', '50000']);
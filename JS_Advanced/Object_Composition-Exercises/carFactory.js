function solve(obj) {
    let result = {
        model: obj.model,
        engine: {},
        carriage: {},
        wheels: []
    };
    let outweels = [];

    let smallEngine = {power: 90, volume: 1800};
    let normalEngine = {power: 120, volume: 2400};
    let monsterEngine = {power: 200, volume: 3500};

    let outcarriage = {type: obj.carriage, color: obj.color};

    let inputPower = obj.power;
    if (inputPower <= 90) {
        result.engine = smallEngine;
        result.carriage = {};
    } else if (inputPower > 90 && inputPower <= 120) {
        result.engine = normalEngine;
    } else {
        result.engine = monsterEngine;
    }
    result.carriage = outcarriage;

    if (obj.wheelsize % 2 == 0) {
        obj.wheelsize--;
    }
    for (let i = 0; i < 4; i++) {
        outweels.push(Number(obj.wheelsize));
    }

    result.wheels = outweels;
    return result;
}

console.log(solve({
    model: 'Opel Vectra',
    power: 110,
    color: 'grey',
    carriage: 'coupe',
    wheelsize: 17 }

));
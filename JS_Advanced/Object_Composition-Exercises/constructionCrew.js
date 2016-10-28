function solve(obj) {

    if (!obj.handsShaking == true) {
        return obj;
    } else {
        let modifier = (0.1 * Number(obj.weight) * Number(obj.experience)) + Number(obj.bloodAlcoholLevel);
        obj.bloodAlcoholLevel = modifier;
        obj.handsShaking = false;
    }
    return obj;
}
console.log(solve({
        weight: 120,
        experience: 20,
        bloodAlcoholLevel: 200,
        handsShaking: true
    }
));
function cappyJuice(input) {
    let bottles = new Map();
    let juicesMap = new Map();

    for (let i = 0; i < input.length; i++) {
        let tokens = input[i].split(' => ');
        let [fruit, quantity] = [tokens[0], Number(tokens[1])];

        if (!juicesMap.has(fruit)) {
            juicesMap.set(fruit, 0);
        }
        juicesMap.set(fruit, juicesMap.get(fruit) + quantity);

        if (juicesMap.get(fruit) >= 1000) {
            bottles.set(fruit, Math.floor(juicesMap.get(fruit) / 1000));
        }
    }
    for (let [key,val] of bottles) {
        console.log(`${key} => ${val}`);
    }
}
cappyJuice(["Kiwi => 234", "Pear => 2345", "Watermelon => 3456", "Kiwi => 4567", "Pear => 5678", "Watermelon => 6789"]);
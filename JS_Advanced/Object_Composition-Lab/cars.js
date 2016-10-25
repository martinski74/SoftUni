function cars(commands) {
    let carsMap = new Map();
    let carManager = {
        create: function ([name, ,parent]) {
            parent = parent ? carsMap.get(parent) : null;
            let newObj = Object.create(parent);
            carsMap.set(name, newObj);
            return newObj;
        },
        set: function ([name, key, value]) {
            let obj = carsMap.get(name);
            obj[key] = value;
        },
        print: function (name) {
            let obj = carsMap.get(name);
            console.log(
                Object.keys(obj).map((key)=>`${key}:${obj[key]}`).join(', '));
        }
    };


    for (let command of commands) {
        let tokens = command.split(' ');
        let camandName = tokens.shift();
        carManager[camandName](...tokens);
    }
}

console.log(cars(['create pesho', 'create gosho inherit pesho', 'create stamat inherit gosho', 'set pesho rank number1', 'set gosho nick goshko', 'print stamat']));
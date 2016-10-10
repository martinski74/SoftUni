function autoCompany(input) {
    let result = new Map();
    for (let line of input) {
        let splited = line.split(/\s*\|\s*/);
        let carBrand = splited[0];
        let carModel = splited[1];
        let producedCars = Number(splited[2]);

        if(!result.has(carBrand)){
            result.set(carBrand,new Map());
        }
        if(!result.get(carBrand).has(carModel)){
            result.get(carBrand).set(carModel,0);
        }
        result.get(carBrand).set(carModel,result.get(carBrand).get(carModel)+producedCars);
    }
    for(let[key,val] of result){
        console.log(key);
        for(let [key2,val2] of val){
            console.log(`###${key2} -> ${val2}`);
        }
    }

}
autoCompany(['Audi | Q7 | 1000',
    'Audi | Q6 | 100',
    'BMW | X5 | 1000',
    'BMW | X6 | 100',
    'Citroen | C4 | 123',
    'Volga | GAZ-24 | 1000000',
    'Lada | Niva | 1000000',
    'Lada | Jigula | 1000000',
    'Citroen | C4 | 22',
    'Citroen | C5 | 10'
]);
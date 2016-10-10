function store(input) {
    let initials = new Map();
    for (let i = 0; i < input.length; i++) {
        let itemInfo = input[i].split(' : ');
        let productName =itemInfo[0];
        let prodPrice = itemInfo[1];
        let initial = productName[0];

        if (!initials.has(initial)){
            initials.set(initial, new Map());
        }
        if(!initials.get(initial).has(productName)){
            initials.get(initial).set(productName,0);
        }
        initials.get(initial).set(productName,prodPrice);
    }

    function alphabeticSort(a,b) {
        return a[0].toLowerCase().localeCompare(b[0].toLowerCase());
    }
    let sortedInitials = [...initials].sort(alphabeticSort);
    for (let[key,val] of sortedInitials){
        console.log(key);
        let sortedProdVal = [...val].sort(alphabeticSort);
        for (let [key2,val2] of sortedProdVal){
            console.log(`  ${key2}: ${val2}`);
        }
    }
}
store(['Banana : 2',
'Rubic\'s Cube : 5',
'Raspberry P : 4999',
'Rolex : 100000',
'Rollon : 10',
'Rali Car : 2000000',
'Pesho : 0.000001',
'Barrel : 10'
]);
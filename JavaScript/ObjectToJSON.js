"use strict";
function solve(input) {
    let obj = {};
    for (let i = 0; i < input.length; i++) {
        let line = input[i].split(' -> ');
        let key = line[0];
        let val = line[1];
        if (!isNaN(val)) {
            val= parseInt(val);
        }
        obj[key]= val;
    }
    let str = JSON.stringify(obj);
    console.log(str);

}


solve(['name -> Angel', 'surnamne -> Georgiev', 'age -> 20', 'grade -> 6.00', 'date -> 23/05/1995', 'town -> Sofia']);

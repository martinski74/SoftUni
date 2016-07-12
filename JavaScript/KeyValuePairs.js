"use strict";
function solve(arr) {
    let result = {};
    var isFound = false;
    for (let i = 0; i < arr.length - 1; i++) {
        let pair = arr[i].split(' ');
        var key = pair[0];
        let value = pair[1];
        var lastKey = arr[arr.length - 1];

        if (!isNaN(key) && !isNaN(lastKey)) {
            key = parseInt(key);
            lastKey = parseInt(lastKey);
        }
        if (key === lastKey) {
            isFound = true;
            if (key in result) {
                result[key] += '\n' + value;
            } else {
                result[key] = value;
                //isFound = true;
            }

        }
    }
    if (!isFound) {
        console.log('None')
    } else {
        console.log(result[lastKey]);
    }

}
solve(['key value', 'key eulav', 'test tset', 'key']);
solve(['3 test', '3 test1', '4 test2', '4 test3', '4 test5', '4']);
solve(['3 bla', '3 alb', '2']);

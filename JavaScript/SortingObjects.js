"use strict";
function sort(arr) {
    let obj ={};
    for (var i = 0; i < arr.length; i++) {
        let line = arr[i].split(' -> ');
        let name = line[0];
        let age = line[1];
        let grade = line[2];

        obj.name = name;
        obj.age = age;
        obj.grade = grade;
        console.log('Name: '+ obj.name);
        console.log('Age: '+obj.age);
        console.log('Grade: '+obj.grade);
    }
}
sort(['Pesho -> 13 -> 6.00']);

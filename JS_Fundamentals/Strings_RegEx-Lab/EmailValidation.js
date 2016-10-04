function solve([input]) {
    let pattern = /^[a-zA-Z0-9\._]+\@[a-z]+(\.[a-z]+)+$/g;
    let result = pattern.test(input);
    if (result){
        console.log('Valid');
    } else {
        console.log('Invalid');
    }
}
solve(['valid@email.bg']);
solve(['invalid@emai1.bg']);
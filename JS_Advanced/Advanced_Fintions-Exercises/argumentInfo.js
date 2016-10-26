function result() {
    let sumary = {};
    for (let i = 0; i < arguments.length; i++) {
        let obj = arguments[i];
        let type = typeof obj;
        if (!sumary[type]) {
            sumary[type] = 1;
        } else {
            sumary[type]++;
        }
        console.log(type + ': ' + obj);
    }
    let sortedTypes = [...Object.keys(sumary)]
        .sort((a, b) => sumary[b] - sumary[a])
        .forEach(item => console.log(item + ' = ' + sumary[item]));
}
result('cat', 42, function () {
    console.log('Hello world!');
});
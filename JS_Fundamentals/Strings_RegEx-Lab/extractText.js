function solve([text]) {
    let result =[];
    let startIndex  = text.indexOf('(');
    while (startIndex > -1){
        let endIndex = text.indexOf(')',startIndex);
        if (endIndex == -1){
            break;
        }
        let snipet = text.substring(startIndex +1,endIndex);
        result.push(snipet);
        startIndex = text.indexOf('(',endIndex);
    }
    console.log(result.join(', '));
}
solve(['Rakiya (Bulgarian brandy) is self-made liquor (alcoholic drink)']);

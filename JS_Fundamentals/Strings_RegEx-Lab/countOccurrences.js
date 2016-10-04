function solve([str, text]) {
    let count = 0;
    let index = text.indexOf(str);

    while (index > -1){
        count++;
        index = text.indexOf(str,index +1);
    }
    console.log(count);
}
solve(['the', 'The quick brown fox jumps over the lay dog.']);
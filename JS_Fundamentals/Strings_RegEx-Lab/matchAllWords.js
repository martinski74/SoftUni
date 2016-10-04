function solve([text]) {
    let result = [];
    let splited = text.split(/[\s\W]+/);

    for (let word of splited) {
        if (word != '') {
            result.push(word);
        }
    }

    console.log(result.join('|').trim());

}
//solve(['_(Underscores) are also word characters']);
solve(['In a sentence, also there are some signs like + or ? Sentences can also have semicolons; or dots. and !']);
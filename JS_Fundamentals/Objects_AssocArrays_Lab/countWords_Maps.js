function count(input) {
    let text = input.join('\n').toLowerCase()
        .split(/[^A-Za-z0-9_]+/).filter(w => w != '');
    let wordsCount = new Map();
    for (w of text) {
        wordsCount.has(w) ? wordsCount.set(w, wordsCount.get(w) + 1) : wordsCount.set(w, 1);
    }
    let allWords = Array.from(wordsCount.keys()).sort();
    allWords.forEach(w =>
    console.log(`'${w}' -> ${wordsCount.get(w)} times`));


}
count(['JS and Node.js', 'JS again and again', 'Oh, JS?']);
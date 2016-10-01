function solve(input) {
    console.log('<?xml version="1.0" encoding="UTF-8"?>\n<quiz>');
    for (let i = 0; i < input.length; i++) {
        if (i % 2 === 0) {
            console.log(`  <question>\n\t${input[i]}\n  </question>`)
        } else{
            console.log(`  <answer>\n\t${input[i]}\n  </answer>`)
        }
    }
    console.log('</quiz>');
}
solve(['question', 'answer', 'question', 'answer','question', 'answer']);
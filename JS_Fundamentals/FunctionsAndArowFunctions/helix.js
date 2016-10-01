function solve(input){
    let sequence = 'ATCGTTAGGG';
    let rows = Number(input[0]);
    let currIndex = 0;
    for (let i = 0; i < rows; i++) {
        let currentRow = i % 4;
        if (currentRow === 0){
            console.log(`**${sequence[currIndex++ % sequence.length]}${sequence[currIndex++ % sequence.length]}**`);
        } else if(currentRow === 1 || currentRow === 3){
            console.log(`*${sequence[currIndex++ % sequence.length]}--${sequence[currIndex++ % sequence.length]}*`);
        } else{
            console.log(`${sequence[currIndex++ % sequence.length]}----${sequence[currIndex++ % sequence.length]}`);
        }
    }
}
solve([10]);
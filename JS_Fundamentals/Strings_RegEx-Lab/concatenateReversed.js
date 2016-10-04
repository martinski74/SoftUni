function solve(input) {

   let str= input.join('');
    let revChars = Array.from(str).reverse();

    console.log(revChars.join(''));
}
solve(['I', 'am', 'student']);
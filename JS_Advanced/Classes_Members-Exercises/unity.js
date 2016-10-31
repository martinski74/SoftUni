class Rat{
    constructor(name){
        this.name = name;
        this.rats = [];
    }

    unite(otherRat){
        if(otherRat instanceof Rat){
            this.rats.push(otherRat);
        }
    }
    getRats(){
        return this.rats;
    }
    toString(){
        let result = this.name;
        for(let rat of this.rats){
            result+= `##${rat}`;
        }
        return result;
    }
}
let ratBoss = new Rat('Ratatui');
ratBoss.unite(new Rat('Blacky'));
ratBoss.unite(new Rat('Sparky'));

console.log(ratBoss.getRats());
console.log(ratBoss.toString());
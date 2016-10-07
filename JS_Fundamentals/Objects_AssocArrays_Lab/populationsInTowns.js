function solve(input) {
    let total = new Map();
    for (let lines of input) {
        let [town,population] = lines.split(/\s*<->\s*/);
        population = Number(population);

        if (total.has(town)) {
            total.set(town, total.get(town) + population);
        } else {
            total.set(town, population);
        }
    }
    for (let [town,sum] of total) {
        console.log(town + " : " + sum);
    }
}
solve(['B<->20', 'A<->30', 'B<->5']);

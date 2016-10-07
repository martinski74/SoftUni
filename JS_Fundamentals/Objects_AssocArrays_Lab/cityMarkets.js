function solve([input]) {
    let resultMap = new Map();
    for (let lines of input) {
        let [town,product,quontityPrice]=input.split(/\s*->\s*/);
        let [quantity,price]=quontityPrice.split(/\s*:\s*/);
        if (!resultMap.has(town)) {
            resultMap.set(town, new Map());
        }
        let income = Number(quantity) * Number(price);
        let oldIncome = resultMap.get(town).get(product);
        if (oldIncome) {
            income += oldIncome;
        }
        resultMap.get(town).set(product, income);
    }
    let output = '';
    for (let [town,products] of resultMap) {
        output += `Town - ${town}\n`;
        for (let [product,income]of products) {
            output += `$$$${product} : ${income}\n`;
        }
    }

    return output.trim();
}
console.log(solve(["Sofia -> Laptops HP -> 200 : 2000", "Sofia -> Raspberry -> 200000 : 1500", "Sofia -> Audi Q7 -> 200 : 100000", "Montana -> Portokals -> 200000 : 1", "Montana -> Qgodas -> 20000 : 0.2", "Montana -> Chereshas -> 1000 : 0.3"]));


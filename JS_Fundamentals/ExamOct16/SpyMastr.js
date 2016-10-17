function solve(args) {
    let specialKey = args.shift();
    let mag = "";

    for (let k = 0; k < specialKey.length; k++){
        mag += `[${specialKey[k].toLowerCase()}${specialKey[k].toUpperCase()}]`;
    }
    let str = "(^| )(" + mag + ")[ ]+([A-Z!%$#]{8,})( |\\.|\\,|$)";

    for (let line of args) {
        let rex = new RegExp(str, "g");
        line = line.replace(rex, function(match, p1, mg, p2) {

            let h = p2.split('').map((a) => {
                switch (a) {
                    case "!": { return 1; }; break;
                    case "%": { return 2; }; break;
                    case "#": { return 3; }; break;
                    case "$": { return 4; }; break;
                    default: { return a.toLowerCase() }
                }
            })
            return match.replace(p2, h.join(''));
        });
        console.log(line)
    }
}
solve(['specialKey',
    'In this text the specialKey HELLOWORLD! is correct, but',
    'the following specialKey $HelloWorl#d and spEcIaLKEy HOLLOWORLD1 are not, while',
    'SpeCIaLkeY   SOM%%ETH$IN and SPECIALKEY ##$$##$$ are!',
]);


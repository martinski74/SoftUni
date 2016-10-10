function solve(input) {
    let heroData =[];

    for (let i = 0; i < input.length; i++) {
        let currentLine = input[i].split(" / ");
        let currentItems = [];
        let currentHeroName = currentLine[0];
        let currentHeroLevel = Number(currentLine[1]);

        if (currentLine.length > 2){
            currentItems = currentLine[2].split(", ");
        }
        let hero ={
            name:currentHeroName,
            level:currentHeroLevel,
            items:currentItems
        };
        heroData.push(hero);

    }

    console.log(JSON.stringify(heroData));
}
solve(['Jake / 1000 / Gauss, HolidayGrenade']);
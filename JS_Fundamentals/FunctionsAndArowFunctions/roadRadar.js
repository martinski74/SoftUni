function solve(input) {
    var speed = Number(input[0]);
    var zone = input[1];

    function getLimit(zon) {
        switch (zon){
            case 'motorway': return 130;
            case 'interstate': return 90;
            case 'city': return 50;
            case 'residential': return 20;
        }
    }

    function getInfraction(speed, limit) {
        let overSpeed = speed - limit;
        if(overSpeed <= 0){
            return false;
        } else {
            if (overSpeed <= 20) return 'speeding';
            else if(overSpeed <= 40) return 'excessive speeding';
            else return 'reckless driving'
        }
    }

    let limit = getLimit(zone);
    let infraction = getInfraction(speed,limit);
    if (infraction){
        console.log(infraction);
    }
}
solve([40,'city']);
solve([21,'residential']);
solve([120,'interstate']);
solve([200,'motorway']);
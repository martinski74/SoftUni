function solve(personName, age, weight, height) {
    let output = {};

    function calculateBmi(w, h) {
        h = Number(h) / 100;
        w = Number(w);
        return w / (h * h);
    }

    output.name = personName;
    output.personalInfo = {
        age: age,
        weight: Math.round(Number(weight)),
        height: Math.round(Number(height))
    };
    output.BMI = Math.round(calculateBmi(weight, height));

    let status;
    if(output.BMI < 18.5){
        status = 'underweight';
    } else if(output.BMI < 25){
        status = 'normal';
    } else if(output.BMI < 30){
        status = 'overweight';
    } else {
        status = 'obese';
    }
    output.status = status;

    if (status === 'obese'){
        output.recommendation = 'admission required';
    }

    return output;

}
//console.log(solve("Peter", 29, 75, 182));
console.log(solve("Honey Boo Boo", 9, 57, 137));
let calc =(function () {
    function add(vec1, vec2) {
        return [vec1[0] + vec2[0], vec1[1] + vec2[1]];
    }

    function multiply(vec1, scalar) {
        return [vec1[0] * scalar, vec1[1] * scalar];
    }

    function length(vec) {
        return Math.sqrt((vec[0] * vec[0]) + (vec[1] * vec[1]));
    }

    function dot(vec1, vec2) {
        return vec1[0] * vec2[0] + vec1[1] * vec2[1];
    }
    function cross(vec1, vec2) {
        return (vec1[0] * vec2[1]) - (vec1[1] * vec2[0]);
    }

    return {add,multiply,length,dot,cross}
})();

console.log(calc.add([1, 1], [1, 0]));
console.log(calc.multiply([3.5, -2], 2));
console.log(calc.length([3, -4]));
console.log(calc.dot([1, 0], [0, -1]));
console.log(calc.cross([3, 7], [1, 0]));

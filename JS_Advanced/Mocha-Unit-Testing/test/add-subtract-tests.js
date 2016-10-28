let createCalculator = require("../add-subtract").createCalculator;
let expect = require("chai").expect;

describe("Test createCalculator() ",function () {
    let calc;
    beforeEach(function () {
        calc = createCalculator();
    });
    it("should return 5 after {add 3;add 2}",function () {
        calc.add(3); calc.add(2); let value = calc.get();
        expect(value).to.be.equal(5);
    })

    it("should return 0 after {get()}",function () {
         calc.get(); let value = calc.get();
        expect(value).to.be.equal(0);
    })
    it("should return -5 after {subtract 3;subtract 2}",function () {
        calc.subtract(3); calc.subtract(2); let value = calc.get();
        expect(value).to.be.equal(-5);
    })
    it("should return 4.2 after {add 5.2;subtract 1.1}",function () {
        calc.add(5.3); calc.subtract(1.1); let value = calc.get();
        expect(value).to.be.equal(5.3 - 1.1);
    })
    it("should return 2 after {add 10;subtract '7';add 2 subtract -1}",function () {
        calc.add(10); calc.subtract('7');calc.add('-2');calc.subtract(-1); let value = calc.get();
        expect(value).to.be.equal(2);
    })
    it("should return NaN after {add 'hello';}",function () {
        calc.add('hello'); let value = calc.get();
        expect(value).to.be.NaN;
    })
    it("should return NaN after {subtract 'hello';}",function () {
        calc.subtract('hello'); let value = calc.get();
        expect(value).to.be.NaN;
    })

} );
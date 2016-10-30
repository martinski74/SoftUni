let isOddOrEven = require("../even_Odd").isOddOrEven;
let expect = require("chai").expect;

describe("Test isOddOrEven ", function () {
    it("if input is number should return undefind", function () {
        expect(isOddOrEven(10)).to.be.equal(undefined);
    });
    it("if input is object should return undefind", function () {
        expect(isOddOrEven({name: 'pesho', age: 33})).to.be.equal(undefined);
    });
    it("if input is an even string should return correct result", function () {
        expect(isOddOrEven('pepi')).to.equal('even');
    });
    it("if input is odd string should return correct result", function () {
        expect(isOddOrEven('pesho')).to.equal('odd');
    })
    it("if input multiple consecutive checks should return correct result", function () {
        expect(isOddOrEven('cat')).to.equal('odd');
        expect(isOddOrEven('alabala')).to.equal('odd');
        expect(isOddOrEven('it is even')).to.equal('even');
    });


});

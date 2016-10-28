let isSimmetric = require("../isSimmetric").isSimmetric;
let expect = require("chai").expect;

describe("Test isSimetric(arr)",function () {

    it("should return true for [1,2,3,3,2,1]",function () {
        expect(isSimmetric([1,2,3,3,2,1])).to.be.equal(true);
    })

    it("should return false for [1,2,3,4,2,1]",function () {
        expect(isSimmetric([1,2,3,4,2,1])).to.be.equal(false);
    })

    it("should return true for [-1,2,-1]",function () {
        expect(isSimmetric([-1,2,-1])).to.be.equal(true);
    })

    it("should return false for [-1,2,1]",function () {
        expect(isSimmetric([-1,2,1])).to.be.equal(false);
    })

    it("should return false for [1,2]",function () {
        expect(isSimmetric([1,2])).to.be.equal(false);
    })

    it("should return true for [1]",function () {
        expect(isSimmetric([1])).to.be.equal(true);
    })

    it("should return true for [5,'hi',{a:5},new Date(),{a:5},'hi',5]",function () {
        expect(isSimmetric([5,'hi',{a:5},new Date(),{a:5},'hi',5])).to.be.equal(true);
    })

    it("should return false for [5,'hi',{a:5},new Date(),{X:5},'hi',5]",function () {
        expect(isSimmetric([5,'hi',{a:5},new Date(),{X:5},'hi',5])).to.be.equal(false);
    })

    it("should return false for 1,2,2,1",function () {
        expect(isSimmetric(1,2,2,1)).to.be.equal(false);
    })
    it("should return true []",function () {
        expect(isSimmetric([])).to.be.equal(true);
    })
    it("should return true [][][]",function () {
        expect(isSimmetric([[],[],[]])).to.be.equal(true);
    })

})


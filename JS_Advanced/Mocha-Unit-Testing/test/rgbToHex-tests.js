let rgbToHexColor = require("../rgbToHex").rgbToHexColor;
let expect = require("chai").expect;

describe("Test RGB To HEX",function () {
    it("sould return #FF9EAA on(255,158,170)",function () {
        expect(rgbToHexColor(255,158,170)).to.be.equal('#FF9EAA');
    });
    it("sould return #0C0D0E on(255,158,170)",function () {
        expect(rgbToHexColor(12,13,14)).to.be.equal('#0C0D0E');
    });
    it("sould return #000000 on(0,0,0)",function () {
        expect(rgbToHexColor(0,0,0)).to.equal('#000000');
    });
    it("sould return #FFFFFF on(255,255,255)",function () {
        expect(rgbToHexColor(255,255,255)).to.equal('#FFFFFF');
    });
    it("sould return undefinesd on(-1,0,0)",function () {
        expect(rgbToHexColor(-1,0,0)).to.be.equal(undefined);
    });
    it("sould return undefinesd on(256,0,0)",function () {
        expect(rgbToHexColor(256,0,0)).to.be.equal(undefined);
    });
    it("sould return undefinesd on(3.14,0,0)",function () {
        expect(rgbToHexColor(3.14,0,0)).to.be.equal(undefined);
    });
    it("sould return undefinesd on('5',[4],{4:6})",function () {
        expect(rgbToHexColor('5',[4],{4:6})).to.be.equal(undefined);
    });
    it("sould return undefinesd on(0)",function () {
        expect(rgbToHexColor(0)).to.be.equal(undefined);
    });
    it("sould return undefinesd on('string')",function () {
        expect(rgbToHexColor('string')).to.be.equal(undefined);
    });
    it("sould return undefinesd on([])",function () {
        expect(rgbToHexColor([])).to.be.equal(undefined);
    });
    it("sould return undefinesd on(10,-10,10)",function () {
        expect(rgbToHexColor(10,-10,10)).to.be.equal(undefined);
    });
    it("sould return undefinesd on(10,10,-10)",function () {
        expect(rgbToHexColor(10,10,-10)).to.be.equal(undefined);
    });

});
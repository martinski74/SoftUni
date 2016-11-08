let SortedList = require('../02.SortedList').SortedList;
let expect = require('chai').expect;

describe('SortedList',function () {
    let list = {};
    beforeEach(function () {
        list = new SortedList();
    })
    it('shuld have constructor',function () {
        expect(typeof SortedList).to.equal('function');
        expect(SortedList.prototype.hasOwnProperty('add')).to.equal(true,'Did not find add function');
        expect(SortedList.prototype.hasOwnProperty('remove')).to.equal(true,'Did not find remove function');
        expect(SortedList.prototype.hasOwnProperty('get')).to.equal(true,'Did not find get function');
        expect(SortedList.prototype.hasOwnProperty('size')).to.equal(true,'Did not find size function');
    })
    it('should have a size property',function () {
        expect(list.size).to.equal(0);
    })
    it('if have add(),get()',function () {
        list.add(5);
        expect(list.size).to.equal(1);
    })
    it('if have add()',function () {
        list.add(4);
        expect(list.get(0)).to.equal(4);
    })
    it('if have sorting',function () {
        list.add(4);
        list.add(3);
        list.add(8);
        list.add(1);
        expect(list.get(0)).to.equal(1);
        expect(list.get(1)).to.equal(3);
        expect(list.get(2)).to.equal(4);
        expect(list.get(3)).to.equal(8);
        expect(list.size).to.equal(4);
    })
    it('if have remove()',function () {
        list.add(4);
        list.add(3);
        list.add(10);
        list.add(1);
        list.remove(1)
        expect(list.get(0)).to.equal(1);
        expect(list.get(1)).to.equal(4);
        expect(list.get(2)).to.equal(10);
        expect(list.size).to.equal(3);
    })
    it('shuuld not work with negative index',function () {
        list.add(4);
        list.add(3);
        list.add(10);
        list.add(1);
        expect(() => list.get(-1)).to.throw(Error);
        expect(() => list.remove(-1)).to.throw(Error);
    })
    it('shuuld not work with negative index',function () {
        list.add(4);
        list.add(3);
        list.add(10);
        list.add(1);
        expect(() => list.get(4)).to.throw(Error);
        expect(() => list.remove(4)).to.throw(Error);
    })
    it('shuuld not work with empty colection',function () {
        expect(() => list.get(0)).to.throw(Error);
        expect(() => list.remove(0)).to.throw(Error);
    })


})

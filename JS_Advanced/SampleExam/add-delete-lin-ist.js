let expect = require('chai').expect;

function produce(){
    let data = [];
    return {
        add: function(item) {
            data.push(item);
        },
        delete: function(index) {
            if (Number.isInteger(index) && index >= 0 && index < data.length) {
                return data.splice(index, 1)[0];
            } else {
                return undefined;
            }
        },
        toString: function() {
            return data.join(", ");
        }
    };
};

describe('list',function () {
    // let list = {};
    // beforeEach(function () {
    //     list = produce();
    // });

    it('constructor should produce object with correct functions',function () {
        expect(typeof list.add).to.equal('function');
        expect(typeof list.delete).to.equal('function');
        expect(typeof list.toString).to.equal('function');
    })
    it('constructor should produce empty list',function () {
        expect(list.toString()).to.equal('','toString() did not return expected result');
    })
    describe('add',function () {
        it('should add correct value',function () {
            list.add(5);
            expect(list.toString()).to.equal('5','did not add correct value');
        })
        it('should add correct amount ot times',function () {
            list.add('Pesho');
            expect(list.toString()).to.equal('Pesho','did not add correct value');
        })
        it('should add to the end of list',function () {
            list.add('Pesho');
            list.add('Stamat');
            list.add('Gosho');
            expect(list.toString()).to.equal('Pesho, Stamat, Gosho','did not add correct value');
        })
    })

    describe('delete',function () {
        it('wuth string should return undefined ',function () {
            expect(list.delete('Pesho')).to.equal(undefined,'delete not return correct value');
        })
        it('with floating point',function () {
            expect(list.delete(3.14)).to.equal(undefined,'delete not return correct value');
        })
        it('with floating point should not delete any element',function () {
            list.add(15);
            list.delete(3.14);
            expect(list.toString()).to.equal('15','did not delete element');
        })
        it('with zero and no item in list',function () {
            expect(list.delete(0)).to.equal(undefined,'did not delete element');
            expect(list.toString()).to.equal('');
        })
        it('with negative index ,should not delete anything',function () {
            list.add('three')
            expect(list.delete(-6)).to.equal(undefined,'did not delete element');
            expect(list.toString()).to.equal('three');
        })
        it('with index equal to length of list should not delete anything',function () {
            list.add(5);
            list.add('two');
            expect(list.delete(2)).to.equal(undefined,'did not delete element');
            expect(list.toString()).to.equal('5, two');
        })
        it('with zero and  item ,should delete correct',function () {
            list.add(5);
            expect(list.delete(0)).to.equal(5,'Delete return wrong value');
        })
        it('with correct index,should delete correct',function () {
            list.add(5);
            list.add(10);
            list.add(16);
            expect(list.delete(2)).to.equal(16,'Delete return wrong value');
        })
        it('with correct index,should delete correct',function () {
            list.add(5);
            list.add(10);
            list.add(16);
            list.delete(1);
            expect(list.toString()).to.equal('5, 16','Delete return wrong value');
        })
        it('with correct index,should delete correct',function () {
            list.add(5);
            list.add(10);
            list.add(16);
            list.add(21);
            list.delete(3);
            expect(list.toString()).to.equal('5, 10, 16','Delete return wrong value');
        })

    })

})
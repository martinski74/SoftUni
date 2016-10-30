let sharedObject = require('../sharedObject').sharedObject;
let expect = require('chai').expect;
let jsdom = require('jsdom-global')();
let $ = require('jquery');

document.body.innerHTML = `<div id="wrapper">
<input type="text" id="name">
<input type="text" id="income">
</div>`;

describe('sharedObject',function () {
    it('name should start as null',function () {
        expect(sharedObject.name).to.equal(null,'Name did not start with null');
    })
    it('name should start as null',function () {
        expect(sharedObject.income).to.equal(null,'Name did not start with null');
    })
    describe('changeName',function () {
        it('with invalid params shoul not change property',function () {
            sharedObject.changeName('');
            expect(sharedObject.name).to.equal(null)
        })
        it('with invalid params and preexiasting values shoul not change property',function () {
            sharedObject.name = 'Pesho';
            sharedObject.changeName('');
            expect(sharedObject.name).to.equal('Pesho','Name changed incorrectly')
        })
        it('with invalid params and preexiasting values shoul not change property',function () {
            let nameTexbox =  $('#name');
            nameTexbox.val()
            sharedObject.changeName('');
            expect(sharedObject.name).to.equal('Pesho','Name changed incorrectly')
        })
        it('with valid name, should change name property',function () {
            sharedObject.changeName('Joro');
            expect(sharedObject.name).to.equal('Joro');
        })
        it('with valid name, should change name textbox value',function () {
            sharedObject.changeName('Stamat');
            let nameTexbox = $('#name');
            expect(nameTexbox.val()).to.equal('Stamat','Name did not changed');
        })
    })
})
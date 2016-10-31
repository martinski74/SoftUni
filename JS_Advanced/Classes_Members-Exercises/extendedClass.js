let testObj = new (
    //Judge solution is that IIFE
    (function () {
        let count = (function () {
            let counter = -1;
            return () => {
                return ++counter;
            };
        })();

        class Extensible {
            constructor() {
                this.id = count();
            }

            extend(template) {
                for (let prop in template) {
                    if (typeof template[prop] !== 'function') {
                        this[prop] = template[prop];
                    } else {
                        Extensible.prototype[prop] = template[prop];
                    }
                }
            }
        }

        Extensible.id = 0;
        return Extensible;
    })()
)();

//for testing - exacted tests form Judge
var template = {
    extensionData: 5,
    extensionMethod: function (value) {
        return value + 1;
    }
};

console.log(testObj.id);
testObj.extend(template);
console.log(testObj.hasOwnProperty('extensionData'));
console.log(testObj.extensionData === 5);
console.log(Object.getPrototypeOf(testObj).hasOwnProperty('extensionMethod'));
console.log(testObj.extensionMethod(1) === 2);
console.log(testObj);
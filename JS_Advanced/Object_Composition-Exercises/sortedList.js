function sortedList() {
    return (function () {

        let storage = [];

        function add(element) {
            storage.push(element);
            storage = storage.sort((a, b) => a - b);
        }

        function remove(index) {
            if (index >= 0 && index < storage.length) {
                storage.splice(index, 1);
                storage = storage.sort((a, b) => a - b);
            }
        }

        function get(index) {
            if (index >= 0 && index < storage.length) {
                return storage[index];
            }
        }

        function size() {
            return storage.length;
        }

        let list = {add, remove, get, size};

        return list;
    })()

}
let a = sortedList();


a.add(5);
a.add(4);
a.add(4);
a.remove(2);
console.log(a.hasOwnProperty('add'));
console.log(a.size());
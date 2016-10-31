
class SortedList {
    constructor() {
        this.elements = [];
        this.size = 0;
    }

    sort() {
        this.elements = this.elements.sort((a, b) => {
            if (a > b) return 1;
            if (a < b) return -1;
            return 0;
        })
    };

    add(element) {
        if(typeof element === "number") {
            this.elements.push(element);
            this.size += 1;
            this.sort();
        }
    };

    remove(index) {
        if (typeof index === "number" &&
            index === Math.trunc(index) &&
            index >= 0 &&
            index < this.size) {
            this.elements.splice(index, 1);
            --this.size;
        }
    };

    get(index) {
        if (typeof index === "number" &&
            index === Math.trunc(index) &&
            index >= 0 &&
            index < this.size) {
            return this.elements[index];
        }
    };
}

//for testing purposes
let list = new SortedList();
list.add(22);
list.add(2.2);
list.add(-22.3);
list.add("Pesho");
list.add('2');
list.add();
console.log(list);
console.log(list.get(2));
list.remove(2);
list.remove(-2);
list.remove("Penka");
list.remove();
console.log(list);
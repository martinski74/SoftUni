class Person {
    constructor(firstName, lastName, age, email) {
        [this.firstName, this.lastName, this.age, this.email] = [firstName, lastName, age, email];
    }
    toString() {
        return `${this.firstName} ${this.lastName} (age: ${this.age}, email: ${this.email})`;
    }
}


let p = new Person('Ivan','Ivanov',33,'ivan@ivanov');
console.log(''+p);

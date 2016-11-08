function personAndTeacher() {
    class Person {
        constructor(name, email) {
            this.name = name;
            this.email = email;
        }
    }
    class Teacher extends Person {
        constructor(name, email, subject) {
            super(name, email);
            this.subject = subject;
        }
    }

    return {Person, Teacher};
}


let p = new Person('Maria ', 'maria@abv.com');
console.log('Person: ' + p.name + p.email);
let t = new Teacher('Ivan ', 'ivan@abv.com ', 'PHP');
console.log('Teacher: ' + t.name + t.email + t.subject);
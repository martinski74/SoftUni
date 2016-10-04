function solve(input) {
    let result = [];
    for (let email of input){
        let [alias,domain] = email.split('@');
        let username = alias + '.';
        let domainPart = domain.split('.');
        domainPart.forEach(p => username += p[0]);
        result.push(username);
    }
    console.log(result.join(', '));
}
solve(['peshoo@gmail.com', 'todor_43@mail.dir.bg', 'foo@bar.com']);
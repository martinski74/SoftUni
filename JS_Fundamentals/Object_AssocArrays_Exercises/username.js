function usernames(input) {
    let names = new Set();
    for (let word of input) {
        names.add(word);
    }
    let sorted = Array.from(names);
    sorted.sort((a, b)=> {
        if (a.length != b.length) {
            return a.length - b.length;
        }
        return a.localeCompare(b);
    });
    for (let name of sorted) {
        console.log(name);
    }
}

usernames(
    [
        "Ashton",
        "Kutcher",
        "Kutcher",
        "Ariel",
        "Lilly",
        "Keyden",
        "Aizen",
        "Billy",
        "Braston"

    ]);

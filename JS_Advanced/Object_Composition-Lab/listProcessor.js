function listProcessor(commands) {
    let commandProcessor = (function () {
        let list = [];
        return {
            add: function (newItem) {
                return list.push(newItem);
            },
            remove: function (item) {
                return list = list.filter(x => x != item);
            },
            print: ()=> console.log(''+ list),

            toString:()=> list.join(', ')
        };
    })();

    for (let command of commands) {
        let [cmdName,arg] = command.split(' ');
        commandProcessor[cmdName](arg);
    }
}
listProcessor(['add hello', 'add again', 'remove hello', 'add again', 'print']);

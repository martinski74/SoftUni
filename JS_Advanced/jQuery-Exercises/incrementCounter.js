function increment(selector) {
    let container = $(selector);
    let fragment = document.createDocumentFragment();
    let textArea = $('<textarea></textarea>');
    let incrementBtn = $('<button>Increment</button>');
    let addBtn = $('<button>Add</button>');
    let list = $('<ul>');


    textArea.val(0);
    textArea.addClass('counter');
    textArea.attr('disabled',true);
    incrementBtn.addClass('btn');
    incrementBtn.attr('id','incrementBtn');
    addBtn.addClass('btn');
    addBtn.attr('id','addBtn');
    list.addClass('results');

    incrementBtn.on('click',function (event) {
        let value = parseInt(textArea.val());
        textArea.val(++value);
    });

    addBtn.on('click',function (event) {
        let value = parseInt(textArea.val());
        let li = $('<li>');
        li.text(value);
        list.append(li);
    });

    textArea.appendTo(fragment);
    incrementBtn.appendTo(fragment);
    addBtn.appendTo(fragment);
    list.appendTo(fragment);

    container.append(fragment);

}

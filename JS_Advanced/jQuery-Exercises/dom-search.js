function domSearch(selector,caseType) {
    let containerDiv = $(selector);
    containerDiv.addClass('items-control');

    let addControlsDiv = $('<div>').addClass('add-controls');
    let addLable = $('<label>Enter text: </label>');
    let addInput  =$('<input>');
    let a = $('<a class="button" style="display: inline-block">Add</a>');

    addLable.append(addInput);
    addControlsDiv.append(addLable);
    addControlsDiv.append(a);
    containerDiv.append(addControlsDiv);

    let searchControls = $('<div>').addClass('search-controls');
    let searchLabel = $('<label>Search: </label>');
    let sinput = $('<input>');
    //sinput.on('input',search);

    searchLabel.append(sinput);
    searchControls.append(searchLabel);
    containerDiv.append(searchControls);

    let resultDiv = $('<div>').addClass('result-controls');
    let ul = $('<ul>').addClass('items-list');
    resultDiv.append(ul);
    containerDiv.append(resultDiv);

    a.on('click',function () {
        let textValue = input.val();
        let li = $('<li class="list-item"></li>');
        let hiks = $('<a class="button">X</a>');
        hiks.click(function () {
            $(this).parent().remove();
        })

    })
}

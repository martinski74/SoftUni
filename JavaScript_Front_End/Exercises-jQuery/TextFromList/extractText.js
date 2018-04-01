function extractText() {
    // let item = $('#items li')
    //     .toArray()
    //     .map(li => li.textContent)
    //     .join(", ");
    // $('#result').text(item);
    let result = [];
     $('#items li')
         .each((i,elem) => result.push(elem.textContent));
     $('#result').text(result);
}
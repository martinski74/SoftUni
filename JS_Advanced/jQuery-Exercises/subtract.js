function subtract() {
    let first = $('#firstNumber');
    let second = $('#secondNumber');
    let resultDiv = $('#result')

    let result = parseFloat(first.val()) - parseFloat(second.val());
    resultDiv[0].textContent = result;
}


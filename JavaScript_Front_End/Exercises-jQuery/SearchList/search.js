function search() {
    let patern = $('#searchText').val();
    let target = $(`#towns li:contains(${patern})`);
    target.css('font-weight', 'bold');
    $(`#towns li:not(:contains(${patern}))`).css('font-weight', '');

    $('#result').text(target.length + ' matches found.');
}
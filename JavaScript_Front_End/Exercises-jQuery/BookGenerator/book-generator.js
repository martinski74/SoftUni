let createBook = (function createBook() {
    let id =1;
    return function (selector, titleName, authorName, isbn) {

        let fragment = document.createDocumentFragment();
        let container = $(selector);

        let bookContainer = $('<div>');
        let title = $('<p>').text(titleName);
        let author = $('<p>').text(authorName);
        let isbnParagraph = $('<p>').text(isbn);
        let selectBtn = $('<button>Select</button>');
        let deselectBtn = $('<button>Deselect</button>');

        bookContainer.attr('id','book' +id);
        id++;
        title.addClass('title');
        author.addClass('author');
        isbnParagraph.addClass('isbn');

        selectBtn.on('click', function () {
            bookContainer.css('border', '2px solid blue');
        });

        deselectBtn.on('click', function () {
            bookContainer.css('border', 'none');
        });

        bookContainer.append(title)
            .append(author)
            .append(isbnParagraph)
            .append(selectBtn)
            .append(deselectBtn);
        bookContainer.appendTo(fragment);
        container.append(fragment);
    }
})();
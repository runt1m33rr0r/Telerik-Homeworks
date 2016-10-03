function solve() {
    'use strict';

    function validateStringLength(value, minLength, maxLength, message) {
        if (value.length < minLength || value.length > maxLength) {
            throw new Error(message);
        }
    }

    function validateAuthor(author, message) {
        if (!author) {
            throw new Error(message);
        }
    }

    function checkForExistingTitle(book, books, message) {
        if (books.some(function (b) { return b.title === book.title; })) {
            throw new Error(message);
        }
    }

    function checkForExistingIsbn(book, books, message) {
        if (books.some(function (b) { return b.isbn === book.isbn; })) {
            throw new Error(message);
        }
    }

    var library = (function () {
        var invalidStringLength = 'must be between 2 and 100 characters long!',
            invalidAuthor = 'Author must be non-empty string!',
            bookWithTileAlreadyExists = 'A book with the same title already exists!',
            bookWithIsbnAlreadyExists = 'A book with the same ISBN already exists!',
            minStringLength = 2,
            maxStringLength = 100,
            minIsbnLength = 10,
            maxIsbnLength = 13,
            bookTitle = 'Book title',
            bookIsbn = 'Book ISBN',
            books = [],
            categories = [];

        function listBooks(parameter) {
            if (parameter) {
                if (parameter.category) {
                    return books
                        .filter(function (b) { return b.category === parameter.category; })
                        .sort(function (a, b) { return a.ID - b.ID; });
                } else if (parameter.author) {
                    return books
                        .filter(function (b) { return b.author === parameter.author; })
                        .sort(function (a, b) { return a.ID - b.ID; });
                }
            } else {
                return books.sort(function (a, b) { return a.ID - b.ID; });
            }
        }

        function addBook(book) {
            book.ID = books.length + 1;

            validateStringLength(book.title, minStringLength, maxStringLength, `${bookTitle} ${invalidStringLength}`);
            validateStringLength(book.isbn, minIsbnLength, maxIsbnLength, '${bookIsbn} ${invalidStringLength}');
            validateAuthor(book.author, invalidAuthor);
            checkForExistingTitle(book, books, bookWithTileAlreadyExists);
            checkForExistingIsbn(book, books, bookWithIsbnAlreadyExists);

            if (!book.category) {
                book.category = {};
            } else if (!categories.some(function (c) { return c === book.category; })) {
                categories.push(book.category);
            }

            books.push(book);
            return book;
        }

        function listCategories() {
            return categories.sort(function (a, b) { return a.ID - b.ID; });
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    } ());

    return library;
}
module.exports = solve;

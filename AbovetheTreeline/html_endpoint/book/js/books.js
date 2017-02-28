

function getAllBook(){
    booksList('http://abovethetreeline20170226103631.azurewebsites.net/api/books');
}
function BooksAbove50(){
    booksList('http://abovethetreeline20170226103631.azurewebsites.net/api/books?price=100');
}
function BooksUnder50(){
    booksList('http://abovethetreeline20170226103631.azurewebsites.net/api/books?price=50');
}
function Bookstowomen()
{
    booksList('http://abovethetreeline20170226103631.azurewebsites.net/api/books?gender=F');
}
function Bookstomen(){
    booksList('http://abovethetreeline20170226103631.azurewebsites.net/api/books?gender=M');
}

function booksList(apiUrl) {
    $.getJSON(apiUrl)
        .done(function (data) {
            // On success, 'data' contains a list of products.
            booksListSuccess(data);
        });

}


function booksListSuccess(books) {
    $('#bookTable tbody').empty();
    // Iterate over the collection of data
    $.each(books, function (index, book) {
        // Add a row to the book table
        bookAddRow(book);
    });
}


function bookAddRow(book) {
    // Check if <tbody> tag exists, add one if not
    if ($("#bookTable tbody").length == 0) {
        $("#bookTable").append("<tbody></tbody>");
    }
    // Append row to <table>
    $("#bookTable tbody").append(
        bookBuildTableRow(book));
}

function bookBuildTableRow(book) {
    var ret =
        "<tr>" +
        "<td>" + book.Title + "</td>" +
        "<td>" + book.AuthorName + "</td>"+
         "<td>" + book.bookdetail.isbn + "</td>" +
        "<td>" + book.bookdetail.Year  +"</td>"+
       "<td>" + book.bookdetail.Price +"</td>"+
        "<td>" + book.bookdetail.Genre+"</td>"+
        "</tr>";
    return ret;
}


function handleException(request, message,
    error) {
    var msg = "";
    msg += "Code: " + request.status + "\n";
    msg += "Text: " + request.statusText + "\n";
    if (request.responseJSON != null) {
        msg += "Message" +
            request.responseJSON.Message + "\n";
    }
    alert(msg);
}

$(document).ready(function () {
    booksList('http://abovethetreeline20170226103631.azurewebsites.net/api/books');
});
document.addEventListener("DOMContentLoaded", function() {

    var list = document.querySelector("#book-list ul");
    var forms = document.forms;
    //console.log(forms);

    // filter Books
    const searchBar = forms["search-book"].querySelector("input");
    searchBar.addEventListener("keyup", (e) => {
        var term = e.target.value.toLowerCase();
        //
        var books = document.getElementsByTagName("li");
        // var books = document.querySelector("#book-list ul");

        //var myBooks = list.querySelectorAll("li");
        //sconsole.log(books);
        Array.from(books).forEach((book) => {
            var title = book.firstElementChild.textContent.toLowerCase();
            //console.log();
            if (title.indexOf(term) != -1) {
                book.style.display = 'block';
            } else {
                book.style.display = 'none';
            }
        })
    })
})
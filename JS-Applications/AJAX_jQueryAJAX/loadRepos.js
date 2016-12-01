function loadRepos() {
    $("#repos").empty();
    let username = $('#username').val();
    $.get("https://api.github.com/users/" + username + "/repos")
        .then(displayRepos)
        .catch(function () {
            $('#result').append($('<li>Error!</li>'));
        });
    function displayRepos(data) {
        for(let repo of data){
            let link = $('<a>');
            link.text(repo.full_name);
            link.attr('href',repo.html_url);
            let li = $('<li>').append(link);
            $('#result').append(li);
        }
    }

}



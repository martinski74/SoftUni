function startApp() {
    const kinveyBaseUrl = "https://baas.kinvey.com/";
    const kinveyAppKey = "kid_BJtMC3aMx";
    const kinveyAppSecret = "f9aec521fcfe4a8abe7323e0823d8c1e";
    const kinveyAppAuthHeaders = {
        "Authorization": "Basic " + btoa(kinveyAppKey + ":" + kinveyAppSecret)
    };

    sessionStorage.clear();
    showHideMenuLinks();
    showView('viewHome');

    $('#linkHome').click(showHomeView);
    $('#linkLogin').click(showLoginView);
    $('#linkRegister').click(showRegisterView);
    $('#linkListSongs').click(listSongs);
    $('#linkCreateSong').click(showCreateSongView);
    $('#linkLogout').click(logoutUser);

    $('#buttonLoginUser').click(loginUser);
    $('#buttonRegisterUser').click(registerUser);
    $('#buttonCreateSong').click(createSong);
    $('#buttonEditSong').click(editSong);

    $('#infoBox, #errorBox').click(function () {
        $(this).fadeOut();
    });

    $(document).on({
        ajaxStart: function () {
            $('#loadingBox').show();
        },
        ajaxStop: function () {
            $('#loadingBox').hide();
        }
    });

    function showHideMenuLinks() {
        $('#linkHome').show();

        if(sessionStorage.getItem('authToken')) {
            $('#linkLogin').hide();
            $('#linkRegister').hide();
            $('#linkListSongs').show();
            $('#linkCreateSong').show();
            $('#linkLogout').show();
        } else {
            $('#linkLogin').show();
            $('#linkRegister').show();
            $('#linkListSongs').hide();
            $('#linkCreateSong').hide();
            $('#linkLogout').hide();
        }
    }

    function showView(viewName) {
        $('main > section').hide();
        $('#' + viewName).show();
    }

    function showHomeView() {
        showView('viewHome');
    }

    function showLoginView() {
        showView('viewLogin');
        $('#formLogin').trigger('reset');
    }

    function showRegisterView() {
        $('#formRegister').trigger('reset');
        showView('viewRegister');
    }

    function showCreateSongView() {
        $('#formCreateSong').trigger('reset');
        showView('viewCreateSong');
    }

    function loginUser() {
        let userData = {
            username: $('#formLogin input[name=username]').val(),
            password: $('#formLogin input[name=passwd]').val()
        };

        $.ajax({
            method: "POST",
            url: kinveyBaseUrl + "user/" + kinveyAppKey + "/login",
            headers: kinveyAppAuthHeaders,
            data: userData,
            success: loginSuccess,
            error: handleAjaxError
        });

        function loginSuccess(userInfo) {
            saveAuthInSession(userInfo);
            showHideMenuLinks();
            listSongs();
            showInfo('You are Loged in.');
        }
    }

    function registerUser() {
        let userData = {
            username: $('#formRegister input[name=username]').val(),
            password: $('#formRegister input[name=passwd]').val(),
			/* confirmPassword: $('#formRegister input[name=confirm-passwd]').val() */
        };

        $.ajax({
            method: "POST",
            url: kinveyBaseUrl + "user/" + kinveyAppKey + "/",
            headers: kinveyAppAuthHeaders,
            data: userData,
            success: registerSuccess,
            error: handleAjaxError
        });

        function registerSuccess(userInfo) {
            saveAuthInSession(userInfo);
            showHideMenuLinks();
            listSongs();
            showInfo('User registration successful.');
        }
    }

    function saveAuthInSession(userInfo) {
        let userAuth = userInfo._kmd.authtoken;
        sessionStorage.setItem('authToken', userAuth);
        let userId = userInfo._id;
        sessionStorage.setItem('userId', userId);
        let username = userInfo.username;
        $('#loggedInUser').text("Welcome to Hell, " + username + "!");
    }

    function handleAjaxError(response) {
        let errorMsg = JSON.stringify(response);
        if(response.readyState === 0) {
            errorMsg = "Cannot connect due to network error.";
        }
        if(response.responseJSON && response.responseJSON.description) {
            errorMsg = response.responseJSON.description;
        }

        showError(errorMsg);
    }

    function showInfo(message) {
        $('#infoBox').text(message);
        $('#infoBox').show();
        setTimeout(function () {
            $('#infoBox').fadeOut();
        }, 3000);
    }

    function showError(errorMsg) {
        $('#errorBox').text("Error: " + errorMsg);
        $('#errorBox').show();
    }

    function logoutUser() {
        sessionStorage.clear();
        $('#loggedInUser').text('');
        showHideMenuLinks();
        showView('viewHome');
        showInfo('Logout successful.')
    }

    function listSongs() {
        $('#songs').empty();
        showView('viewSongs');

        $.ajax({
            method: "GET",
            url: kinveyBaseUrl + "appdata/" + kinveyAppKey + "/songs",
            headers: getKinveyUserAuthHeaders(),
            success: loadSongsSuccess,
            error: handleAjaxError
        });

        function loadSongsSuccess(songs) {
            showInfo('Songs loaded.');
            if(songs.length == 0) {
                $('#songs').text('No songs in the library.');
            } else {
                let songsTable = $('<table>')
                    .append($('<tr>')
                        .append('<th>TITLE</th><th>ARTIST(Band)</th>', '<th>ALBUM</th><th>ACTION</th>'));

                for(let song of songs){
                    appendSongRow(song, songsTable);
                }

                $('#songs').append(songsTable)
            }

            function appendSongRow(song, songsTable) {
                let links = [];
                if(song._acl.creator == sessionStorage['userId']) {
                    let deleteLink = $('<a href="#">[Delete]</a>').click(function () {
                        deleteSong(song);
                    });
                    let editLink = $('<a href="#">[Edit]</a>').click(function () {
                        loadSongForEdit(song);
                    });

                    links = [deleteLink, ' ', editLink];
                }

                songsTable.append($('<tr>')
                    .append($('<td>').text(song.title), $('<td>').text(song.singer), $('<td>').text(song.album), $('<td>').append(links)
                    ));
            }
        }
    }

    function getKinveyUserAuthHeaders() {
        return {
            "Authorization": "Kinvey " + sessionStorage.getItem('authToken')
        };
    }

    function createSong() {
        let songData = {
            title:$('#formCreateSong input[name=title]').val(),
            singer: $('#formCreateSong input[name=author]').val(),
            album: $('#formCreateSong textarea[name=descr]').val()
        };

        $.ajax({
            method: "POST",
            url: kinveyBaseUrl + "appdata/" + kinveyAppKey + "/songs",
            headers: getKinveyUserAuthHeaders(),
            data: songData,
            success: createSongSuccess,
            error: handleAjaxError
        });

        function createSongSuccess(response) {
            listSongs();
            showInfo('Song created.');
        }
    }

    function loadSongForEdit(song) {
        $.ajax({
            method: "GET",
            url: kinveyBaseUrl + "appdata/" + kinveyAppKey + "/songs/" + song._id,
            headers: getKinveyUserAuthHeaders(),
            success: loadSongForEditSuccess,
            error: handleAjaxError
        });

        function loadSongForEditSuccess(book) {
            $('#formEditSong input[name=id]').val(song._id);
            $('#formEditSong input[name=title]').val(song.title);
            $('#formEditSong input[name=author]').val(song.singer);
            $('#formEditSong textarea[name=descr]').val(song.album);

            showView('viewEditSong');
        }
    }

    function editSong() {
        let songData = {
            title: $('#formEditSong input[name=title]').val(),
            singer: $('#formEditSong input[name=author]').val(),
            album: $('#formEditSong textarea[name=descr]').val()
        };

        $.ajax({
            method: "PUT",
            url: kinveyBaseUrl + "appdata/" + kinveyAppKey + "/songs/" + $('#formEditSong input[name=id]').val(),
            headers: getKinveyUserAuthHeaders(),
            data: songData,
            success: editSongSuccess,
            error: handleAjaxError
        });

        function editSongSuccess(response) {
            listSongs();
            showInfo('Song edited.');
        }
    }

    function deleteSong(song) {
        $.ajax({
            method: "DELETE",
            url: kinveyBaseUrl + "appdata/" + kinveyAppKey + "/songs/" + song._id,
            headers: getKinveyUserAuthHeaders(),
            success: deleteSongSuccess,
            error: handleAjaxError
        });

        function deleteSongSuccess(response) {
            listSongs();
            showInfo('Song deleted.');
        }
    }
}

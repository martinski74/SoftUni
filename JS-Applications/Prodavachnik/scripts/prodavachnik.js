function startApp() {
    const appKey = "kid_HJIJ2OYXl";
    const appSecret = "5f90da58381c4608a4b3fc33fd647d34";
    const baseUrl = 'https://baas.kinvey.com/';
    const kinveyAppAuthHeaders = {
        "Authorization": "Basic " + btoa(appKey + ":" + appSecret)
    };

    sessionStorage.clear();
    showHideMenuLinks();
    showView('viewHome');

    $('#linkHome').click(showHomeView);
    $('#linkLogin').click(showLoginView);
    $('#linkRegister').click(showRegisterView);
    $('#linkListAds').click(listAds);
    $('#linkCreateAd').click(showCreateAd);
    $('#linkLogout').click(logoutUser);

    $('#buttonLoginUser').click(loginUser);
    $('#buttonRegisterUser').click(registerUser);
    $('#buttonCreateAd').click(createAd);
    $('#buttonEditAd').click(editAd);

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
        if (sessionStorage.getItem('authToken') == null) {
            $('#linkListAds').hide();
            $('#linkCreateAd').hide();
            $('#linkLogin').show();
            $('#linkRegister').show();
            $('#linkLogout').hide();
        } else {
            $('#linkLogin').hide();
            $('#linkRegister').hide();
            $('#linkListAds').show();
            $('#linkCreateAd').show();
            $('#linkLogout').show();
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
    function showCreateAd() {
        $('#formCreateAd').trigger('reset');
        showView('viewCreateAd');
    }

    function loginUser() {
        let userData = {
            username: $('#formLogin input[name=username]').val(),
            password: $('#formLogin input[name=passwd]').val()
        };
        $.ajax({
            method: 'POST',
            url: baseUrl + "user/" + appKey + "/login",
            headers: kinveyAppAuthHeaders,
            data: userData,
            success: loginSuccess,
            error: handleAjaxError
        });
        function loginSuccess(userInfo) {
            saveAuthSession(userInfo);
            showHideMenuLinks();
            listAds();
            showInfo('You are loged in!');
        }
    }

    function registerUser() {
        let userData = {
            username: $('#formRegister input[name=username]').val(),
            password: $('#formRegister input[name=passwd]').val(),
        };
        $.ajax({
            method: 'POST',
            url: baseUrl + "user/" + appKey + "/",
            headers: kinveyAppAuthHeaders,
            data: userData,
            success: registerSuccess,
            error: handleAjaxError
        });
        function registerSuccess(userInfo) {
            saveAuthSession(userInfo);
            showHideMenuLinks();
            listAds();
            showInfo('Registration successfull!');
        }
    }

    function saveAuthSession(userInfo) {
        let userAuth = userInfo._kmd.authtoken;
        sessionStorage.setItem('authToken', userAuth);
        let userId = userInfo._id;
        sessionStorage.setItem('userId', userId);
        let username = userInfo.username;
        $('#loggedInUser').text('Welcome ' + username + "!");
    }

    function handleAjaxError(response) {
        let errorMsg = JSON.stringify(response);
        if (response.readyState === 0) {
            errorMsg = 'Can not connect due the network error!'
        }
        if (response.responseJSON && response.responseJSON.description) {
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
        $('#errorBox').text('Error ' + errorMsg);
        $('#errorBox').show();
    }

    function logoutUser() {
        sessionStorage.clear();
        $('#loggedInUser').text('');
        showHideMenuLinks();
        showView('viewHome');
        showInfo('Logout successful!')
    }

    function listAds() {
        $('#ads').empty();
        showView('viewAds');

        $.ajax({
            method: "GET",
            url: baseUrl + "appdata/" + appKey + "/advert",
            headers: getKinveyUserAuthHeaders(),
            success: loadAdsSuccess,
            error: handleAjaxError
        });
        function loadAdsSuccess(ads) {
            showInfo('Adds loaded');
            if (ads.length == 0) {
                $('#ads').text('No ads find.');
            } else {
                let adsTable = $('<table>')
                    .append($('<tr>')
                        .append('<th>Title</th><th>Descriptin</th><th>Publisher</th><th>Date</th><th>Price</th><th>Actions</th>'));
                for (let item of ads) {
                    appedndRow(item, adsTable);
                }

                $('#ads').append(adsTable);
            }

            function appedndRow(ads, adsTable) {
                let links = [];
                if (ads._acl.creator == sessionStorage['userId']) {
                    let deleteLink = $('<a href="#">[Delete]</a>').click(function () {
                        deleteAds(ads);
                    });
                    let editLink = $('<a href="#">[Edit]</a>').click(function () {
                        loadForEdit(ads);
                    });
                    links = [deleteLink, ' ', editLink];
                }
                adsTable.append($('<tr>')
                    .append($('<td>').text(ads.title),
                        $('<td>').text(ads.description),
                        $('<td>').text(ads.publisher),
                        $('<td>').text(ads.date),
                        $('<td>').text(ads.price),
                        $('<td>').append(links)
                    ));

            }
        }
    }

    function getKinveyUserAuthHeaders() {
        return {
            "Authorization": "Kinvey " + sessionStorage.getItem('authToken')
        };
    }

    function createAd() {
        let adsData = {
            title:$('#formCreateAd input[name=title]').val(),
            description:$('#formCreateAd textarea[name=description]').val(),
            date:$('#formCreateAd input[name=datePublished]').val(),
            price:$('#formCreateAd input[name=price]').val()
        };
        $.ajax({
            method: "POST",
            url: baseUrl + "appdata/" + appKey + "/advert",
            headers: getKinveyUserAuthHeaders(),
            data: adsData,
            success: createAdSuccess,
            error: handleAjaxError
        });
        function createAdSuccess(response) {
            listAds();
            showInfo('Adds created!');
        }
    }
    function loadForEdit(adds) {
       $.ajax({
           method:'GET',
           url:baseUrl + "appdata/"+ appKey + "/advert/" + adds._id,
           headers:getKinveyUserAuthHeaders(),
           success:loadForEditSuccess,
           error:handleAjaxError
       });

       function loadForEditSuccess(add) {
           $('#formEditAd input[name=id]').val(adds._id);
           $('#formEditAd input[name=title]').val(adds.title);
           $('#formEditAd textarea[name=description]').val(adds.description);
           $('#formEditAd input[name=datePublished]').val(adds.date);
           $('#formEditAd input[name=price]').val(adds.price);

           showView('viewEditAd');
       }
    }
    function editAd() {
        let adsData = {
            title:$('#formCreateAd input[name=title]').val(),
            description:$('#formCreateAd textarea[name=description]').val(),
            date:$('#formCreateAd input[name=datePublished]').val(),
            price:$('#formCreateAd input[name=price]').val()
        };
        $.ajax({
            method:'PUT',
            url:baseUrl + 'appdata/' + appKey + '/advert/'+ $('#formEditAd input[name=id]').val(),
            headers:getKinveyUserAuthHeaders(),
            data:adsData,
            success:editAdSuccess,
            error:handleAjaxError
        });
        
        function editAdSuccess(response) {
            listAds();
            showInfo('Ads edited!');
        }
    }
    function deleteAds(add) {
        $.ajax({
            method:'DELETE',
            url:baseUrl + 'appdata/' + appKey + '/advert/' + add._id,
            headers:getKinveyUserAuthHeaders(),
            success:deleteSuccess,
            error:handleAjaxError
        });

        function deleteSuccess(response) {
            listAds();
            showInfo('Ads deleted!');
        }
    }

}
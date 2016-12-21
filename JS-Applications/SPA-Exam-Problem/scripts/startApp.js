function startApp() {
    const kinveyBaseUrl = "https://baas.kinvey.com/";
    const kinveyAppKey = "kid_SklYGRO5Qx";
    const kinveyAppSecret = "97879f469cfa477d9dc0aa845cfe3ce3";
    const kinveyAppAuthHeaders = {
        "Authorization": "Basic " + btoa(kinveyAppKey + ":" + kinveyAppSecret)
    };

    //sessionStorage.clear();
    showHideMenuLinks();
    showView('viewAppHome');

    $('#linkMenuAppHome').click(showHomeView);
    $('#linkMenuLogin').click(showLoginView);
    $('#linkMenuRegister').click(showRegisterView);

    $('#linkMenuUserHome').click(showUserHomeView);
    $('#linkUserHomeMyMessages').click(listMessages);
    $('#linkMenuMyMessages').click(listMessages);
    $('#linkMenuSendMessage').click(sendMessageView);
    $('#linkUserHomeSendMessage').click(sendMessageView);
    $('#linkMenuArchiveSent').click(archivesSentView);
    $('#linkUserHomeArchiveSent').click(archivesSentView);
    $('#linkMenuLogout').click(logoutUser);

    $('#formLogin').submit(loginUser);
    $('#formRegister').submit(registerUser);
    $(`#formSendMessage input[type="submit"]`).click(sendMessage);


    function showHideMenuLinks() {
        // when user logged in
        if (sessionStorage.getItem('authToken')) {
            $("#linkMenuAppHome").hide();
            $("#linkMenuLogin").hide();
            $("#linkMenuRegister").hide();
            $("#linkMenuUserHome").show();
            $("#linkMenuMyMessages").show();
            $("#linkMenuArchiveSent").show();
            $("#linkMenuSendMessage").show();
            $("#linkMenuLogout").show();
            $('#spanMenuLoggedInUser').text('Welcome, ' + sessionStorage.getItem('name') + '!')

        } else { // logged out
            $("#linkMenuAppHome").show();
            $("#linkMenuLogin").show();
            $("#linkMenuRegister").show();
            $("#linkMenuUserHome").hide();
            $("#linkMenuMyMessages").hide();
            $("#linkMenuSendMessage").hide();
            $("#linkMenuArchiveSent").hide();
            $("#linkMenuLogout").hide();
            $('#spanMenuLoggedInUser').empty();

        }
    }

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

    function showView(viewName) {
        $('main > section').hide();
        $('#' + viewName).show();
    }

    function showHomeView() {
        showView('viewAppHome');
    }

    function showLoginView() {
        showView('viewLogin');
        $('#formLogin').trigger('reset');
    }

    function showRegisterView() {
        showView('viewRegister');
        $('#formRegister').trigger('reset');
    }

    function sendMessageView() {
        showView('viewSendMessage');
        loadUsers();
    }

    function showInfo(message) {
        $('#infoBox').text(message);
        $('#infoBox').show();
        setTimeout(function () {
            $('#infoBox').fadeOut();
        }, 3000);
    }

    function loginUser(e) {
        e.preventDefault();
        let userData = {
            username: $('#formLogin input[name=username]').val(),
            password: $('#formLogin input[name=password]').val()
        };
        $.ajax({
            method: "POST",
            url: kinveyBaseUrl + "user/" + kinveyAppKey + "/login",
            headers: kinveyAppAuthHeaders,
            data: userData,
            success: loginSucces,
            error: handleAjaxError
        });
        function loginSucces(userInfo) {
            saveAuthInSession(userInfo);
            showHideMenuLinks();
            showUserHomeView();
            $('#spanMenuLoggedInUser').text("Welcome, " + sessionStorage.getItem('name') + '!');
            showInfo('You are logged in.')
        }

    }

    function registerUser(e) {
        e.preventDefault();
        let userData = {
            username: $('#formRegister input[name=username]').val(),
            password: $('#formRegister input[name=password]').val(),
            name: $('#registerName').val()
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
            showUserHomeView();
            showInfo('User registration successful.')
        }
    }

    function logoutUser() {
        $.ajax({
            method: "POST",
            url: kinveyBaseUrl + "user/" + kinveyAppKey + "/_logout",
            headers: getKinveyUserAuthHeaders(),
            success: logedOut,
            error: handleAjaxError
        });
        function logedOut(userInfo) {
            sessionStorage.clear();
            $('#spanMenuLoggedInUser').text('');
            showHideMenuLinks();
            showView('viewAppHome');
            showInfo('You are loged out.')
        }

    }

    function listMessages(){
        $('#myMessages').empty();
        const getMyMsgsUrl = kinveyBaseUrl + "appdata/" + kinveyAppKey + `/messages?query={"recipient_username":"${sessionStorage.getItem('username')}"}`;
        let table = $('<table>').append(`<thead>
                    <tr>
                        <th>From</th>
                        <th>Message</th>
                        <th>Date Received</th>
                    </tr>
                    </thead>`);
        $.ajax({
            method: "GET",
            url: getMyMsgsUrl,
            headers: getKinveyUserAuthHeaders(),
            success: fillTable,
            error: handleAjaxError
        });
        function fillTable(messages) {
            if (messages.length == 0) {
                $('#myMessages').empty();
                $('#myMessages').text('No messages found.')
            }
            else {
                let tbody = $('<tbody>');
                for (let msg of messages) {
                    tbody.append($('<tr>')
                        .append($(`<td>`).text(formatSender(msg.sender_name, msg.sender_username)))
                        .append($(`<td>`).text(msg.text))
                        .append($(`<td>`).text(formatDate(msg._kmd.ect))));
                }
                table.append(tbody);
                $('#myMessages').append(table);
            }
        }
        showView('viewMyMessages');
    }

     function archivesSentView(messanges) {
        const mySentMsgUrl = kinveyBaseUrl + "appdata/" + kinveyAppKey + `/messages?query={"sender_username":"${sessionStorage.getItem('username')}"}`;
        showView('viewArchiveSent');
        $('#sentMessages').empty();

        let table = $('<table>').append(`<thead>
    <tr>
        <th>To</th>
        <th>Message</th>
        <th>Date Sent</th>
        <th>Action</th>
    </tr>
 </thead>`);

        $.ajax({
            method: "GET",
            url: mySentMsgUrl,
            headers: getKinveyUserAuthHeaders(),
            success: fillSentTable,
            error: handleAjaxError
        });
        function fillSentTable(messages) {
            if (messages.length == 0) {
                $('#sentMessages').empty();
                $('#sentMessages').text('No messages found.');
            } else {
                let tbody = $('<tbody>');
                for (let msg of messages) {
                    let delBtn = $('<button>Delete</button>').click(function () {
                        deleteMsg(msg, this)
                    });
                    let td = $('<td>');
                    td.append(delBtn);

                    table.append($('<tbody>')
                        .append($('<td>').text(msg.recipient_username))
                        .append($('<td>').text(msg.text))
                        .append($('<td>').text(formatDate(msg._kmd.ect)))
                        .append(td));
                }
                $('#sentMessages').append(table);
            }
        }

    }

    function loadUsers() {
        let listUsersUrl = kinveyBaseUrl  + "user/" + kinveyAppKey;
        $('#msgRecipientUsername').empty();
        $.ajax({
            method: 'GET',
            url: listUsersUrl,
            headers:getKinveyUserAuthHeaders() ,
            success: displayUsersInDropdown,
            error: handleAjaxError
        });
        function displayUsersInDropdown(users) {
            for (let user of users) {
                $('#msgRecipientUsername').append($('<option>')
                    .text(formatSender(user.name, user.username))
                    .val(user.username));
            }
        }

    }


    function sendMessage(e) {
        e.preventDefault();

        const sentUrl = kinveyBaseUrl + "appdata/" + kinveyAppKey + "/messages";
        let msgDta = {
            sender_username:sessionStorage.getItem('username'),
            sender_name:sessionStorage.getItem('name'),
            recipient_username: $("#msgRecipientUsername").val() ,
            text: $('#msgText').val()
        };
        $.ajax({
            method:"POST",
            url:sentUrl,
            headers:getKinveyUserAuthHeaders(),
            data:msgDta,
            success:sentSucces,
            error:handleAjaxError
        });
        function sentSucces() {
            showInfo('Message sent!');
            $('#msgText').empty();
            archivesSentView();
        }

    }
    function deleteMsg(msg, btn) {
        let delUrl = kinveyBaseUrl + "appdata/" + kinveyAppKey + "/messages" + `/${msg._id}`;
        $.ajax({
            method: "DELETE",
            url: delUrl,
            headers: getKinveyUserAuthHeaders(),
            success: messagesDeleted,
            error: handleAjaxError
        });
        function messagesDeleted() {
            $(btn).parent().parent().remove();
            showInfo('Message deleted.')
        }
    }

    function formatDate(dateISO8601) {
        let date = new Date(dateISO8601);
        if (Number.isNaN(date.getDate()))
            return '';
        return date.getDate() + '.' + padZeros(date.getMonth() + 1) +
            "." + date.getFullYear() + ' ' + date.getHours() + ':' +
            padZeros(date.getMinutes()) + ':' + padZeros(date.getSeconds());

        function padZeros(num) {
            return ('0' + num).slice(-2);
        }
    }

    function formatSender(name, username) {
        if (!name)
            return username;
        else
            return username + ' (' + name + ')';
    }


    function getKinveyUserAuthHeaders() {
        return {'Authorization': "Kinvey " + sessionStorage.getItem('authToken')};
    }

    function saveAuthInSession(userInfo) {
        let userAuth = userInfo._kmd.authtoken;
        sessionStorage.setItem('authToken', userAuth);
        let userId = userInfo._id;
        sessionStorage.setItem('userId', userId);
        let username = userInfo.username;
        sessionStorage.setItem('username', username);
        let name = userInfo.name;
        sessionStorage.setItem('name', name);
        $('#loggedInUser').text("Welcome , " + username + "!");
    }

    function handleAjaxError(response) {
        let errorMsg = JSON.stringify(response);
        if (response.readyState === 0)
            errorMsg = "Cannot connect due to network error.";
        if (response.responseJSON &&
            response.responseJSON.description)
            errorMsg = response.responseJSON.description;
        showError(errorMsg);
    }

    function showError(errorMsg) {
        $('#errorBox').text("Error: " + errorMsg);
        $('#errorBox').show();
    }

    function showUserHomeView() {
        $('#viewUserHomeHeading').text('Welcome, ' + sessionStorage.getItem('name') + '!');
        showView('viewUserHome');
    }

}

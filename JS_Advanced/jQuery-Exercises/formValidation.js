function solve() {
    let isCompany = false;
    setEvents();

    function setEvents() {
        $('#company').on('change', function () {
            let companyFielsSet = $('#companyInfo');
            if ($(this).is(':checked')) {

                companyFielsSet.slideDown();
                isCompany = true;
            } else {
                companyFielsSet.slideUp();
                isCompany = false;
            }
        });
        $('#submit').click(function (event) {
            event.preventDefault();
            validateForm();
        });
    }

    function validateForm() {
        let isValid = true;
        let username = $('#username');
        if (!username.val().match(/^[a-zA-Z0-9]{3,20}$/)) {
            username.css('border-color', 'red');
            isValid = false;
        } else {
            username.css('border', 'none');
        }

        let email = $('#email');
        if (!email.val().match(/^.*@.*?\..*?$/)) {
            email.css('border-color', 'red');
            isValid = false;
        } else {
            email.css('border', 'none');
        }

        let password = $('#password');
        let confPasword = $('#confirm-password');
        if (!password.val().match(/^[\w]{5,15}$/)) {
            password.css('border-color', 'red');
            confPasword.css('border-color', 'red');
            isValid = false;
        } else {
            if (!confPasword.val().match(/^[\w]{5,15}$/)) {
                password.css('border-color', 'red');
                confPasword.css('border-color', 'red');
                isValid = false;
            } else {
                if (confPasword.val() != password.val()) {
                    password.css('border-color', 'red');
                    confPasword.css('border-color', 'red');
                    isValid = false;
                } else {
                    confPasword.css('border', 'none');
                    password.css('border', 'none');
                }
            }
        }

        if (isCompany) {
            let companyNumber = $('#companyNumber');
            if (!companyNumber.val().match(/^[1-9]\d{3}$/)) {
                companyNumber.css('border-color', 'red');
                isValid = false;
            } else {
                companyNumber.css('border', 'none');
            }
        }
        if (isValid) {
            $('#valid').show();
        }

    }


}

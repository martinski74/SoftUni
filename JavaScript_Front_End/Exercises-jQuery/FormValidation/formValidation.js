function validate() {
    let username = $('#username');
    let email = $('#email');
    let password = $('#password');
    let confPass = $('#confirm-password');
    let companyCheckBox = $('#company');
    let companyNimber = $('#companyNumber');
    let companyInfo = $('#companyInfo');
    let submitBtn = $('#submit');
    let validationDiv = $('#valid');

    companyCheckBox.on('change',function () {
        if(companyCheckBox.is(':checked')){
            companyInfo.css('display','block');
        } else {
            companyInfo.css('display','none');
        }
    });
    submitBtn.on('click',function (ev) {
        ev.preventDefault();
        validateForm();
    });
     function validateForm() {
         
     }
}

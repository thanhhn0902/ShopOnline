$(document).ready(function () {
    $('.nav-link').click(function () {
        $('.nav-link').removeClass('active');
        $(this).addClass('active');
    });
    $('.repass').blur(function (e) {
        var pass = $('.pass').val();
        var repass = $('.repass').val();
        if (pass != repass) {
            $('.repassValidate').append("<span style='color:red;'>Mật khẩu không khớp!!!</span>");
        }
    });
});
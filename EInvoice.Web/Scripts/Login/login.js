   // template
    $(document).ready(function() {
        $('#goRight').on('click',
            function() {
                $('#slideBox').animate({
                    'marginLeft': '0'
                });
                $('.topLayer').animate({
                    'marginLeft': '100%'
                });
            });
        $('#goLeft').on('click',
            function() {
                $('#slideBox').animate({
                    'marginLeft': '50%'
                });
                $('.topLayer').animate({
                    'marginLeft': '0'
                });
            });
    });

    // login
    $(document).ready(function() {
        $("#btnLogin").click(function() {
            doLogin();
        });
    });

    function doLogin() {
        var userName = $("#username").val();
        var password = $("#password").val();
        debugger
        if (userName.length === 0) {
            $("#errorMessage").html("Please enter your username");
            timeoutMessage();
        } else if (password.length === 0) {
            $("#errorMessage").html("Please enter your password");
            timeoutMessage();
        } else {
            $.ajax({
                type: 'Post',
                url: "?userName=" + userName + "&password=" + password,
                dataType: 'json',
                success: function(data) {
                    if (data.status === "WrongUserName") {
                        $("#errorMessage").html("Username is incorrect");
                        timeoutMessage();
                    } else if (data.status === "WrongPassword") {
                        $("#errorMessage").html("Password is incorrect");
                        timeoutMessage();
                    } else if (data.status === "Succsess") {
                        window.location.href = "/"
                    }
                }
            });
        }
    }

function timeoutMessage() {
    setTimeout(function() {
       $("#errorMessage").empty();
     },1500);
}

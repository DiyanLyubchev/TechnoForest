/// Buy product

$('#buyItem').click(function () {
    const id = $('#buyItem').val();

    $.ajax({
        url: '/ShoppingCart/BuyItem',
        data: { idItem: id },
        type: 'POST',
        dataType: 'json',
        traditional: true,
        cache: false,
        success: function (result) {
            window.location.href = "/home/index/" + result.resultId;
        }
    });
});

// Reject product

$('#rejectItem').click(function () {
    const id = $('#rejectItem').val();

    $.ajax({
        url: '/ShoppingCart/BuyItem',
        data: { rejectItem: id },
        type: 'POST',
        dataType: 'json',
        traditional: true,
        cache: false,
        success: function (result) {
            window.location.href = "/home/index/" + result.resultId;
        }
    });
});



//$('#send-button').on('click', function () {

//    const addName = $('#fullname').val();
//    const addEGN = $('#egn').val();
//    const addPhoneNumber = $('#phone-number').val();
//    const gmailId = $('#send-button').val();

//    let massege = 'Something went wrong!';

//    function isNumeric(checkEgn) {
//        return !isNaN(parseFloat(checkEgn)) && isFinite(checkEgn);
//    }

//    if (!isNumeric(addEGN)) {
//        massege = "Egn connot contains letter"
//    }

//    if (addName.length === 0 || addEGN.length === 0 || addPhoneNumber.length === 0) {
//        massege = "The client's details cannot be null!";
//    }
//    else if (addName.length < 3 || addName.length > 50) {
//        massege = "The length of the client's name is not correct!";
//    }
//    else if (addEGN.length < 10 || addEGN.length > 10) {
//        massege = "The client's Egn must be 10 symbols!";
//    }
//    else if (addPhoneNumber.length < 8 || addPhoneNumber.length > 50) {
//        massege = "The length of the client's phone number is not correct!";
//    }

//    $.ajax({
//        url: '/Loan/Loanform',
//        data: { userData: addName, egnData: addEGN, phoneData: addPhoneNumber, idData: gmailId },
//        type: 'POST',
//        dataType: 'json',
//        traditional: true,
//        cache: false,
//        success: function (result) {
//            if (result.emailId) {
//                Swal.fire({
//                    position: 'top-end',
//                    icon: 'success',
//                    title: 'Your work has been saved',
//                    showConfirmButton: false,
//                    timer: 1000
//                })
//                window.setInterval(foo, 1000);
//                function foo() {
//                    window.location.href = "/home/index/" + result.emailId;
//                }
//            }
//            else if (result.exeption) {
//                Swal.fire({
//                    icon: 'error',
//                    title: 'Oops...',
//                    showConfirmButton: true,
//                    text: massege
//                })
//                window.setInterval(errorRequest, 5000);
//                function errorRequest() {
//                    window.location.href = "/email/fillemailform/" + result.exeption;
//                }
//            }
//        }
//    });
//});

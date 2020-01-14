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



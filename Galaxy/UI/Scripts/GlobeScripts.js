function DeleteGlobe(id) {
    if (Ask() === true)
        $.ajax({
            async: false,
            method: "POST",
            url: "/Home/Delete/" + id,
            data: id = id
        });
    //Old data in response if use Refresh method in success
    RefreshAfterDelete();
}

function RefreshAfterDelete() {
    $.ajax({
        async: false,
        method: "POST",
        url: "/Home/ListOfGlobes",
        success: function (res) {
            $("#table-container").html(res);
        }
    });
}

$(document).ready(function () {
    $(".selectpicker").selectpicker({
        style: "btn-default",
        width: "fit"
    });

});


function Ask() {
    //Need create asking mechanism, for example modal window
    return true;
}
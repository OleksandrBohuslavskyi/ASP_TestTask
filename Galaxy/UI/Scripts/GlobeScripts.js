function DeleteGlobe(id) {
    if(Ask() === true)
    $.ajax({
        url: "/Home/Delete/" + id,
        data: id = id,
        success: function (data) { SuccessMessage("Success!") }       
    });
}

function Ask() {
    //Need create asking mechanism
    return true;
}
function SuccessMessage(message) {
    alert(message);
}
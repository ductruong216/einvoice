function EditCompany() {
    $("#submitCompany").css('visibility', 'visible');
    $(':input').removeAttr('readonly')
    $('#companyName').prop('readonly', true);
    $('#taxCode').prop('readonly', true);
}

function SubmitCompanyStatus() {
    swal({
        title: "Edit Company Info",
        text: "Edit Successfully",
        icon: "success",
        buttons: false,
        timer: 1300
    })
}
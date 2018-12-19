function EditCompany() {
    $("#submitCompany").css('visibility', 'visible');
    $(':input').removeAttr('readonly')
    $('#companyName').prop('readonly', true);
    $('#taxCode').prop('readonly', true);
}
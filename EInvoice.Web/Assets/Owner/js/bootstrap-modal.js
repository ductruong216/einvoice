$("#btnNew").on("click", function () {
	$('#customerForm').trigger("reset");
	$('#code_status').contents().remove();
	$('#taxCode_status').contents().remove();
	$('span.field-validation-valid').contents().remove();
});

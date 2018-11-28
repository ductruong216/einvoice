function CheckAvailable(field, URL, fieldStatus, statusContent) {
	$("#" + field).keyup(function () {
		$.ajax({
			url: URL,
			type: "POST",
			dataType: "json",
			data: { searchKey: $("#" + field).val() },
			success: function (data) {
				if (data === true) {
					$("#" + fieldStatus).css("color", "red");
					$("#" + fieldStatus).html(statusContent);
				} else {
					$("#" + fieldStatus).html("");
				}
			}
		});
	});
}

CheckAvailable("Code", "Customer/CheckCode", "code_status", "Customer code is exist");
CheckAvailable("TaxCode", "Customer/CheckTaxCode", "taxCode_status", "Tax code is exist");



$(document).ready('#btnAdd').click(function () {
	this.href = "/Customer/Edit/" + document.getElementById('customerId').value;
});
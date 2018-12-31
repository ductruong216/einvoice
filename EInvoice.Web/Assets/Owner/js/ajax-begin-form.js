function SubmitStatus() {
	$('#newCustomer').modal('hide');
	$('#customerForm').trigger("reset");
	$('#code_status').contents().remove();
	$('#taxCode_status').contents().remove();
	$('span.field-validation-valid').contents().remove();
	swal({
		title: "Add Customer",
		text: "Add Successfully",
		icon: "success",
		buttons: false,
		timer: 1300
	}).then(function () {
		Customers.Refresh();
	});
}

function AddProductSuccess () {
    $('#newProduct').modal('hide');
    $('#productForm').trigger("reset");
    $('#Code-error').contents().remove();
    $('#Name-error').contents().remove();
    $('#Price-error').contents().remove();
	$('span.field-validation-valid').contents().remove();
	swal({
		title: "Add Product",
		text: "Add Successfully",
		icon: "success",
		buttons: false,
		timer: 1300
	}).then(function () {
        Products.Refresh();
	});
}



// $.ajax({
//	url: '@Url.Action("Create", "Customer")',
//	method: "POST",
//	data: formData,
//	dataType: 'json',
//	contentType: 'application/json; charset=utf-8',
//	processData: false,


//	success: function (json) {
//		if (json.Success) {
//			swal({
//				title: "Add Customer",
//				text: "Add Successfully",
//				icon: "success",
//				buttons: false,
//				timer: 1300
//			});
//		}
//		else {

//			swal({
//				title: "FAILED",
//				text: json.Message,
//				icon: "error",
//				buttons: false,
//				timer: 1300
//			});
//		}
//	},
//	error: function () {
//		swal({
//			title: "FAILED",
//			text: "Add Customer Failed",
//			icon: "error",
//			buttons: false,
//			timer: 1300
//		});
//	},
//	complete: function () {
//		$('#btnSave').removeAttr('disabled');
//	}
//}) 
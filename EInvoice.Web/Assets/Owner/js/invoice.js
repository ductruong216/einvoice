// Create Invoice
$(document).ready(function () {
	$("#submitInvoice").click(function () {
		var items = [];
		var count = $('#goodsTable tr').length;

		for (var i = 1; i < count; ++i) {
			if ($('#productCode' + i).val().trim() !== "" && $('#productId' + i).val().trim() !== "") {
				var item = {
					ProductId: $('#productId' + i).val(),
					ItemName: $('#name' + i).val(),
					ItemPrice: $('#price' + i).val(),
					UnitName: $('#unit' + i).val(),
					Quantity: $('#qty' + i).val(),
					TotalAmount: $('#total' + i).val()
				};

				items.push(item);
			}
		}

		$.ajax({
			type: "POST",
			dataType: "json",
			url: '/Invoice/Create',
			data: {
				Tax: $('#tax').val(),
				TaxAmount: $('#tax_amount').val(),
				SubTotalAmount: $('#sub_total').val(),
				GrandTotalAmount: $('#total_amount').val(),
				PatternId: parseInt($('#pattern').val(), 10),
				Series: $('#series').val(),
				No: $('#no').val(),
				CreatedDate: $('#date').val(),
				PurchaserCustomer: {
					Code: $('#CusCode').val(),
					Purchaser: $('#purchaser').val(),
					EnterpriseName: $('#companyName').val(),
					TaxCode: $('#taxCode').val(),
					Address: $('#address').val(),
					Email: $('#email').val(),
					Phone: $('#phone').val()
				},
				CustomerId: $('#customerId').val(),

				Items: items,

				PaymentTypeID:
					$('#paymentType').val()
				,
				Note: $('#note').val()
			},
			success: function (response) {
				if (response.Success) {
					swal({
						title: "Add Invoice",
						text: response.Message,
						icon: "success",
						buttons: false,
						timer: 1500
					}).then(function () {
						window.location.href = "/Invoice/List";
					});
				} else {
					swal({
						title: "Add Invoice",
						text: response.Message,
						icon: "error",
						buttons: false,
						timer: 2000
					});
				}
			}
		});
	});
});

//Edit Invoice
$(document).ready(function () {
	$("#submitEditInvoice").click(function () {
		var items = [];
		var count = $('#goodsTable tr').length;
		for (var i = 1; i < count; ++i) {
			if ($('#productCode' + i).val() !== "" && $('#productId' + i).val() !== "") {
				var item = {
					ProductId: $('#productId' + i).val(),
					ItemName: $('#name' + i).val(),
					ItemPrice: $('#price' + i).val(),
					UnitName: $('#unit' + i).val(),
					Quantity: $('#qty' + i).val(),
					TotalAmount: $('#total' + i).val()
				};
				items.push(item);
			}
		}
		$.ajax({
			type: "POST",
			dataType: "json",
			url: '/Invoice/Edit',
			data: {
				Tax: $('#tax').val(),
				PurchaserCustomerID: $('#PurchaserCustomerID').val(),
				CompanyID: $('#CompanyId').val(),
				TaxAmount: $('#tax_amount').val(),
				ProductId: $('#tax_amount').val(),
				ID: $('#ID').val(),

				SubTotalAmount: $('#sub_total').val(),
				GrandTotalAmount: $('#total_amount').val(),
				PatternId: parseInt($('#pattern').val(), 10),
				Series: $('#series').val(),
				No: $('#no').val(),
				CreatedDate: $('#date').val(),
				PurchaserCustomer: {
					Code: $('#CusCode').val(),
					Purchaser: $('#purchaser').val(),
					EnterpriseName: $('#companyName').val(),
					TaxCode: $('#taxCode').val(),
					Address: $('#address').val(),
					Email: $('#email').val(),
					Phone: $('#phone').val()
				},
				Status: "Draft",
				Customer: {
					ID: $('#CustomerId').val()
				},

				CustomerId: $('#customerId').val(),

				Items: items,

				PaymentTypeID:
					$('#paymentType').val()
				,
				Note: $('#note').val()
			},
			success: function (response) {
				if (response.Success) {
					swal({
						title: "Edit Invoice",
						text: response.Message,
						icon: "success",
						buttons: false,
						timer: 1500
					}).then(function () {
						window.location.href = "/Invoice/List";
					});
				} else {
					swal({
						title: "Edit Invoice",
						text: response.Message,
						icon: "error",
						buttons: false,
						timer: 2000
					});
				}
			}
		});
	});
});

// Confirm Delete Invoice
function deleteInvoice(id) {
	swal({
		title: "Do you want to delete this invoice?",

		icon: "warning",
		buttons: true,
		dangerMode: true
	}).then((isConfirm) => {
		if (isConfirm) {
			$.ajax({
				type: "POST",
				url: "/Invoice/Delete/" + id,
				success: function (data) {

					if (data.Success === true) {
						swal({
							title: "Delete Invoice",
							text: data.Message,
							icon: "success",
							buttons: false,
							timer: 1500
						}).then(function () {
							DraftInvoice.Refresh();
							ReleaseGrid.Refresh();
						});
					} else {
						swal({
							title: "Delete Invoice",
							text: data.Message,
							icon: "error",
							buttons: false,
							timer: 1500
						});
					}
				}
			});
		}
	});
}

function Release(id) {
	swal({
		title: "Do you want to release this invoice?",
		icon: "info",
		buttons: true,
		dangerMode: true
	}).then((isConfirm) => {
		if (isConfirm) {
		
			$.ajax({
				type: "POST",
				url: "/Invoice/ReleaseInvoice/" + id,
				success: function (data) {

					if (data.Success === true) {
						swal({
							title: "Release Invoice",
							text: data.Message,
							icon: "success",
							buttons: false,
							timer: 1500

						}).then(function() {
							ReleaseGrid.Refresh();
							DraftInvoice.Refresh();
							ListInvoice.SetActiveTabIndex(1);

						});
					} else {
						swal({
							title: "Release Invoice",
							text: data.Message,
							icon: "error",
							buttons: false,
							timer: 1500
						});
					}
				}
			});

		}
	});
}

function viewInvoice(id) {
	swal({
		title: "Do you want to release this invoice?",
		icon: "info",
		buttons: true,
		dangerMode: true
	}).then((isConfirm) => {
		if (isConfirm) {	
			$.ajax({
				type: "POST",
				url: "/Invoice/ReleaseInvoice/" + id,
				success: function (data) {
					if (data.Success === true) {
						swal({
							title: "Release Invoice",
							text: data.Message,
							icon: "success",
							buttons: false,
							timer: 1500

						}).then(function() {
							ReleaseGrid.Refresh();
							DraftInvoice.Refresh();
							ListInvoice.SetActiveTabIndex(1);

						});
					} else {
						swal({
							title: "Release Invoice",
							text: data.Message,
							icon: "error",
							buttons: false,
							timer: 1500
						});
					}
				}
			});

		}
	});
}
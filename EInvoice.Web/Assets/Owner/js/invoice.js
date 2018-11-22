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

//Hey
//Havana, ooh na - na(ay)
//Half of my heart is in Havana, ooh - na - na(ay, ay)
//She took me back to East Atlanta, na - na - na
//Oh, but my heart is in Havana(ay)
//There's somethin' 'bout her manners (uh huh)
//Havana, ooh na - na(uh)
//She didn't walk up with that "how you doin' ? " (uh)
//	(When She came in the room)
//She said there's a lot of girls I can do with (uh)
//	(But I can't without you)
//I knew her forever in a minute(hey)
//		(That summer night in June)
//And papa says she got malo in her(uh)
//She got me feelin' like
//Ooh - ooh - ooh, I knew it when I met her
//I loved her when I left her
//Got me feelin' like
//Ooh - ooh - ooh, and then I had to tell her
//I had to go, oh na - na - na - na - na
//Havana, ooh na - na(ay, ay)
//Half of my heart is in Havana, ooh - na - na(ay, ay)
//She took me back to East Atlanta, na - na - na(uh huh)
//Oh, but my heart is in Havana(ay)
//My heart is in Havana(ay)
//Havana, ooh na - na
//Jeffery
//Just graduated, fresh on campus, mm
//Fresh out East Atlanta with no manners, damn
//Fresh out East Atlanta
//Bump on her bumper like a traffic jam
//Hey, I was quick to pay that girl like Uncle Sam(here you go, ay)
//Back it on me, shawty cravin' on me
//Get to diggin' on me (on me)
//She waited on me(then what ?)
//Shawty cakin' on me, got the bacon on me (wait up)
//This is history in the makin' on me (on me)
//Point blank, close range, that be
//If it cost a million, that's me (that's me)
//I was gettin' mula, man they feel me
//Havana, ooh na - na(ay, ay)
//Half of my heart is in Havana, ooh - na - na(oh, ay, ay)
//She took me back to East Atlanta, na - na - na(oh no)
//Oh, but my heart is in Havana(ay)
//My heart is in Havana(ay)
//Havana, ooh na - na
//Ooh na - na, oh na - na - na(oo - ooh)
//Take me back, back, back like
//Ooh na - na, oh na - na - na(yeah, babe)
//Take me back, back, back like
//Ooh na - na, oh na - na - na(yea, yeah)
//Take me back, back, back like
//Ooh na - na, oh na - na - na(yea, babe)
//Take me back, back, back
//	(Hey, hey)
//Ooh - ooh - ooh
//Ooh - ooh - ooh
//Take me back to my Havana
//Havana, ooh na - na
//Half of my heart is in Havana, ooh - na - na(oh, yeah)
//She took me back to East Atlanta, na - na - na(ay, ay)
//Oh, but my heart is in Havana
//My heart is in Havana(ay)
//Havana, ooh na - na
//Uh huh
//Oh na - na - na(oh na, yeah)
//Oh na - na - na
//Oh na - na - na
//No, no, no, take me back
//Oh na - na - na
//Havana, ooh na - na


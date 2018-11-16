
$(document).ready(function () {

	$("#submitInvoice").click(function () {
		var items = [];
		var count = $('#goodsTable tr').length;
		for (var i = 1; i < count; ++i) {
			if ($('#productCode' + i).val().trim() !== "" && $('#productId' + i).val().trim() !== "") {
				debugger;
				var	 item = {
					ProductId: $('#productId' + i).val(),
					ItemName: $('#name' + i).val(),
					ItemPrice: $('#price' + i).val(),
					UnitName: $('#unit' + i).val(),
					Quantity: $('#qty' + i).val(),
					TotalAmount: $('#total' + i).val()
				};
			}

			items.push(item);
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
			success: function (data) {
				alert("Successfully");
			},
			error: function (status) {
				alert("Failed");
			}
		});
	});
});
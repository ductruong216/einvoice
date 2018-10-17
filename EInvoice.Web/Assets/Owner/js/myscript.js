$(document).ready(function () {
	$('.list-unstyled a').filter(function () { return this.href === location.href }).parent().addClass('active')
		.siblings().removeClass('active');
});
$(document).ready('.list-unstyled a').click(function () {
	$(this).parent().addClass('active').siblings().removeClass('active');
});
function calc() {
	$('#tab_logic tbody tr').each(function (i, element) {
		var html = $(this).html();
		if (html !== '') {
			var price = $(this).find('.price').val();
			var qty = $(this).find('.qty').val();
			$(this).find('.total').val(qty * price);

			calc_total();
		}
	});
}
function calc_total() {
	total = 0;
	$('.total').each(function () {
		total += parseInt($(this).val());
	});
	$('#sub_total').val(total.toFixed(2));
	tax_sum = total / 100 * $('#tax').val();
	$('#tax_amount').val(tax_sum.toFixed(2));
	$('#total_amount').val((tax_sum + total).toFixed(2));
}
// Add-Remove products
$(document).ready(function () {
	var i = 1;
	$("#add_row").click(function () {
		b = i - 1;
		//var newRow = $('#addr' + i).html($('#addr' + b).html()).find('td:first-child').html(i + 1);
		var newRow = $('#addr' + i).html('<td> ' + (i + 1) + '  </td >' +
			'<td><input type="text" id="name' + (i + 1) + '" name="name' + i + '" ' + 'class="form-control name" id="description" step="0" min="0" /></td>' +
			'<td><input type="number" id="price' + (i + 1) + '" name="price' + i + '' + '"class="form-control price" step="0.00" min="0" /></td >' +
			'<td><input type="text" id="unit' + (i + 1) + '" name="unit' + i + ' ' + '" class="form-control unit" step="0.00" min="0" /></td >' +
			'<td><input type="number" name="qty +' + i + '"  class="form-control qty" step="0" min="0" /></td >' +
			'<td><input type="number" name="total ' + i + '" placeholder="0.00" class="form-control total" readonly /></td >');
		var index = i + 1;
		newRow.find("#name" + index).autocomplete({
			source: function (request, response) {
				$.ajax({
					url: '/Product/GetProducts',
					type: "POST",
					dataType: "json",
					data: { searchKey: request.term },
					success: function (data) {
						response($.map(data,
							function (item) {
								return {
									value: item.Name,
									code: item.Code,
									price: item.Price,
									tax: item.Tax,
									unit: item.UnitName
								};
							}));
					},
					error: function (status) {
						alert(status);
					}
				});
			},
			select: function (even, ui) {
				$("#name" + index).val(ui.item.name);
				$("#price" + index).val(ui.item.price);
				$("#unit" + index).val(ui.item.unit);
			}
		});

		$('#tab_logic').append('<tr id="addr' + (i + 1) + '"></tr>');
		i++;
		return false;
	});
	$("#delete_row").click(function () {
		if (i > 1) {
			$("#addr" + (i - 1)).html('');
			i--;
		}
		calc();
	});

	$('#tab_logic tbody').on('keyup change', function () {
		calc();
	});
	$('#tax').on('keyup change', function () {
		calc_total();
	});
});

$(document).ready(function () {
	$("#name1").autocomplete({
		source: function (request, response) {
			$.ajax({
				url: '/Product/GetProducts',
				type: "POST",
				dataType: "json",
				data: { searchKey: request.term },
				success: function (data) {
					response($.map(data,
						function (item) {
							return {
								label: item.Name,
								value: item.Name,
								price: item.Price,
								unit: item.UnitName
							};
						}));
				},
				error: function (status) {
					alert(status);
				}
			});
		},
		select: function (even, ui) {
			$("#name1").val(ui.item.name);
			$("#price1").val(ui.item.price);
			$("#unit1").val(ui.item.unit);
		}
	});
});

//Autocomplete Customers
function CustomerAutoComplete(field, fieldValue, URL) {
	$("#" + field).autocomplete({
		source: function (request, response) {
			$.ajax({
				url: URL,
				type: "POST",
				dataType: "json",
				data: { searchKey: request.term },
				success: function (data) {
					response($.map(data,
						function (item) {
							return {
								label: item[fieldValue],
								value: item[fieldValue],
								name: item.Name,
								code: item.Code,
								purchaser: item.Purchaser,
								taxCode: item.TaxCode,
								address: item.Address,
								email: item.Email,
								bankId: item.BankAccountID,
								accountHolder: item.AccountHolder,
								bankName: item.BankName,
								phone: item.Phone
							};
						}));
				},
				error: function (status) {
					alert(status);
				}
			});
		},
		select: function (even, ui) {
			$("#companyName").val(ui.item.name);
			$("#purchaser").val(ui.item.purchaser);
			$("#CusCode").val(ui.item.code);
			$("#taxCode").val(ui.item.taxCode);
			$("#address").val(ui.item.address);
			$("#email").val(ui.item.email);
			$("#bankId").val(ui.item.bankId);
			$("#accountHolder").val(ui.item.accountHolder);
			$("#bankName").val(ui.item.bankName);
			$("#phone").val(ui.item.phone);
		}
	});
};
CustomerAutoComplete("CusCode", "Code", '/Customer/GetCodeCustomerJsonResult');
CustomerAutoComplete("companyName", "Name", '/Customer/GetNameCustomerJsonResult');
CustomerAutoComplete("taxCode", "TaxCode", '/Customer/GetTaxCodeCustomerJsonResult');
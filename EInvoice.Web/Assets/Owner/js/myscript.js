$(document).ready(function () {
	$('.list-unstyled a').filter(function () { return this.href == location.href }).parent().addClass('active')
		.siblings().removeClass('active');
});

$(document).ready('.list-unstyled a').click(function () {
	$(this).parent().addClass('active').siblings().removeClass('active');
});

// Add-Remove products
$(document).ready(function () {
	var i = 1;
	$("#add_row").click(function () {
		b = i - 1;
		$('#addr' + i).html($('#addr' + b).html()).find('td:first-child').html(i + 1);	
	
		$('#tab_logic').append('<tr id="addr' + (i + 1) + '"></tr>');

		//$('#tab_logic tbody tr').each(function (i, element) {
		//	var html = $(this).html();
		//	if (html != '') {
		//		find(".name").autocomplete(autocomplete_opt);
		//	};
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
var autocomplete_opt = {
	source: function (request, response) {
		$.ajax({
			url: '/Category/GetProducts',
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
							unit: item.Unit
						};
					}));
			},
			error: function (status) {
				alert(status);
			}
		});
	},
	select: function (even, ui) {
		$(".name").val(ui.item.name);
		$(".price").val(ui.item.price);
		$(".code").val(ui.item.code);
		$(".unit").val(ui.item.unit);
	}
};

$(document).ready(function() {
	$(".name").autocomplete({
		source: function(request, response) {
			$.ajax({
				url: '/Category/GetProducts',
				type: "POST",
				dataType: "json",
				data: { searchKey: request.term },
				success: function(data) {
					response($.map(data,
						function(item) {
							return {
								value: item.Name,
								code: item.Code,
								price: item.Price,
								tax: item.Tax,
								unit: item.Unit
							};
						}));
				},
				error: function(status) {
					alert(status);
				}
			});
		},
		select: function(even, ui) {
			$(".name").val(ui.item.name);
			$(".price").val(ui.item.price);
			$(".code").val(ui.item.code);
			$(".unit").val(ui.item.unit);
		}
	});
});

function calc() {
	$('#tab_logic tbody tr').each(function (i, element) {
		var html = $(this).html();
		if (html != '') {
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

CustomerAutoComplete("CusCode", "Code", '/Category/GetCodeCustomerJsonResult');
CustomerAutoComplete("companyName", "Name", '/Category/GetNameCustomerJsonResult');
CustomerAutoComplete("taxCode", "TaxCode", '/Category/GetTaxCodeCustomerJsonResult');


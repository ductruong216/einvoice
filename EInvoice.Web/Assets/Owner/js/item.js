
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
	var total = 0;
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
			'<td style="display: none"><input id="productId' + (i + 1) + '" name="productId' + i + '"' + 'class="form-control id" /></td>' +
			'<td><input id="productCode' + (i + 1) + '" name="productCode' + i + '"' + ' class="form-control name" id="description" step="0" min="0" /></td>' +
			'<td><input type="text" id="name' + (i + 1) + '" name="name' + i + '" ' + 'class="form-control name" id="description" step="0" min="0" /></td>' +
			'<td><input type="number" id="price' + (i + 1) + '" name="price' + i + '' + '"class="form-control price" step="0.00" min="0" /></td >' +
			'<td><input type="text" id="unit' + (i + 1) + '" name="unit' + i + '' + '" class="form-control unit" step="0.00" min="0" /></td >' +
			'<td><input type="number" id="qty' + (i + 1) + '"name="qty' + + i + '"  class="form-control qty" step="0" min="0" /></td >' +
			'<td><input type="number"  id="total' + (i + 1) + '"name="total' + i + '" placeholder="0.00" class="form-control total" readonly /></td >');
		var index = i + 1;

		newRow.find("#name" + index).autocomplete({
			source: function (request, response) {
				$.ajax({
					url: '/Product/GetProductsName',
					type: "POST",
					dataType: "json",
					data: { searchKey: request.term },
					success: function (data) {
						response($.map(data,
							function (item) {
								return {
									value: item.Name,
									id: item.ID,
									code: item.Code,
									price: item.Price,
									tax: item.Tax,
									unit: item.UnitName
								};
							}));
					}
				});
			},
			select: function (even, ui) {
				$("#productId" + index).val(ui.item.id);
				$("#productCode" + index).val(ui.item.code);
				$("#name" + index).val(ui.item.name);
				$("#price" + index).val(ui.item.price);
				$("#unit" + index).val(ui.item.unit);
			}
		});

		newRow.find("#productCode" + index).autocomplete({
			source: function (request, response) {
				$.ajax({
					url: '/Product/GetProductsCode',
					type: "POST",
					dataType: "json",
					data: { searchKey: request.term },
					success: function (data) {
						response($.map(data,
							function (item) {
								return {
									value: item.Code,
									id: item.ID,
									code: item.Code,
									name: item.Name,
									price: item.Price,
									tax: item.Tax,
									unit: item.UnitName
								};
							}));
					}
				});
			},
			select: function (even, ui) {
				$("#productId" + index).val(ui.item.id);
				$("#productCode" + index).val(ui.item.code);
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
	$('#find_company').on('click',
		function () {
			$.ajax({
				url: '/Customer/GetCustomerAPI',
				type: "GET",
				dataType: "json",
				data: { mst: $('#taxCode').val() },
				success: function (data) {
					debugger;
					response($.map(data,
						function (item) {
							return {
								name: item.TitleEn,
								address: item.DiaChiCongTy
							};
						}));
				},

				select: function (even, ui) {
					$("#companyName").val(ui.item.name);
					$("#address").val(ui.item.address);
				}
			});
		});
});

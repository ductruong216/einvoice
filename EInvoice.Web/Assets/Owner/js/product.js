

// Autocomplete Product
function ProductAutocomplete(field, fieldValue, URL) {
	$("#" + field).autocomplete({
	
		source: function (request, response) {
			debugger;
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
								id: item.ID,
								name: item.Name,
								code: item.Code,
								price: item.Price,
								unit: item.UnitName
							};
						}));
				}
			});
		},
		select: function (even, ui) {
			$("#productId1").val(ui.item.id);
			$("#productCode1").val(ui.item.code);
			$("#name1").val(ui.item.name);
			$("#price1").val(ui.item.price);
			$("#unit1").val(ui.item.unit);
		}
	});
}

ProductAutocomplete("name1", "Name", '/Product/GetProductsName');
ProductAutocomplete("productCode1", "Code", '/Product/GetProductsCode');


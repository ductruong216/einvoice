function AutoComplete(matchFieldName, resultFieldName, URL) {
	$("#" + matchFieldName).autocomplete({
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
								value: item.Code,
								name: item.Name,
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

		}
	});
}

function AutoComplete(matchFieldName, resultFieldName, lookupURL) {
	$('#' + matchFieldName).autocomplete({
		source: function (request, response) {
			$.ajax({
				type: "POST",
				url: lookupURL,
				contentType: 'application/json',
				dataType: "json",
				data: JSON.stringify({ prefixText: request.term, count: 20 }),
				success: function (data) {
					var output = jQuery.parseJSON(data.d);
					response($.map(output, function (item) {
						return {
							value: item.Value,
							label: (item.Label == item.Value) ? item.Label : item.Label + "(" + item.Value + ")"
						}
					}));
				},
				error: function (XMLHttpRequest, textStatus, errorThrown) {
					alert(textStatus);
				}
			});
		},
		minLength: 2,
		select: function (event, ui) {
			$('#' + resultFieldName).val(ui.item.value);
		}
	});
}
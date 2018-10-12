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


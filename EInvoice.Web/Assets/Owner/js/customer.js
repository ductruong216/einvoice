// Autocomplete Customers
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
								id: item.ID,
								name: item.EnterpriseName,
								code: item.Code,
								purchaser: item.Name,
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
			$("#customerId").val(ui.item.id);
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
CustomerAutoComplete("companyName", "EnterpriseName", '/Customer/GetNameCustomerJsonResult');
//CustomerAutoComplete("taxCode", "TaxCode", '/Customer/GetTaxCodeCustomerJsonResult');
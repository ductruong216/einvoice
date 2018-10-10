﻿(function () {
	$('.list-unstyled a').filter(function () { return this.href == location.href }).parent().addClass('active')
		.siblings().removeClass('active');
});

$('.list-unstyled a').click(function () {
	$(this).parent().addClass('active').siblings().removeClass('active');
});

// Add-Remove products
$(document).ready(function () {
	var i = 1;
	$("#add_row").click(function () {
		b = i - 1;
		$('#addr' + i).html($('#addr' + b).html()).find('td:first-child').html(i + 1);
		$('#tab_logic').append('<tr id="addr' + (i + 1) + '"></tr>');
		i++;
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
function calc() {
	$('#tab_logic tbody tr').each(function(i, element) {
		var html = $(this).html();
		if(html!='')
		{
			var price = $(this).find('.price').val();
			var qty = $(this).find('.qty').val();
			$(this).find('.total').val(qty*price);
			
			calc_total();
		}
    });
}

function calc_total()
{
	total=0;
	$('.total').each(function() {
        total += parseInt($(this).val());
    });
	$('#sub_total').val(total.toFixed(2));
	tax_sum=total/100*$('#tax').val();
	$('#tax_amount').val(tax_sum.toFixed(2));
	$('#total_amount').val((tax_sum+total).toFixed(2));
}

// Autocomplete Customers
//$(document).ready(function () {
//	$("#CusCode").autocomplete({
//		source: function (request, response) {
//			$.ajax({
//				url: '@Url.Action("GetCustomerJsonResult","Customer")',
//				type: "POST",
//				dataType: "json",
//				data: { search: $("#CusCode").val() },
//				success: function(data) {
//					response($.map(data,
//						function(item) {
//							return { label: item.Code, value: item.Code };
//						}));
//				}
//			});
//		},
//		messages: {
//			noResults: "", results: ""
//		}
//	});
//});
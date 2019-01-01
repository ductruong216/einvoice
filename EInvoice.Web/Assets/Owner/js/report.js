function SubmitReport() {

}

$('#selectQuater, #selectYear').change(function () {
    $("#reportTable tbody").remove();
    $.ajax({
        url: "/Invoice/ReportOnUse",
        type: "POST",
        dataType: "json",
        data: { quarter: $('#selectQuater').val(), year: $('#selectYear').val() },
        success: function (data) {
            $('#quarter').html($('#selectQuater').val());
            $('#year').html($('#selectYear').val());
            console.log(data);
            var event_data = '';
            $.each(data,
                function (key, value) {
                    var index = key + 1;
                    event_data += '<tr border="1" class="text">';
                    event_data += '<td  style="text-align:center">' + index + '</td>';
                    event_data += '<td style="vertical-align: text-top" class="text">' + value.InvoiceType + '</td>';
                    event_data += '<td style="text-align:center;vertical-align: text-top">' + value.Pattern + '</td>';
                    event_data += '<td style="text-align:center;vertical-align: text-top">' + value.Serial + '</td>';
                    event_data += '<td style="text-align:center;vertical-align: text-top">' +
                        value.TotalBegining +
                        '</td>';
                    event_data += '<td id="TonTuSo" style="text-align:center;vertical-align: text-top">' +
                        (value.FromBeginingNo == null ? "-" : value.FromBeginingNo) +
                        '</td>';
                    event_data += '<td style="text-align:center;vertical-align: text-top">' +
                        (value.ToBeginingNo == null ? "-" : value.ToBeginingNo) +
                        '</td>';
                    event_data += '<td style="text-align:center;vertical-align: text-top">' +
                        (value.FromBuyNo == null ? "-" : value.FromBuyNo) +
                        '</td>';
                    event_data += '<td style="text-align:center;vertical-align: text-top">' +
                        (value.ToBuyNo == null ? "-" : value.ToBuyNo) +
                        '</td>';
                    event_data += '<td style="text-align:center;vertical-align: text-top">' +
                        (value.FromAllInvoice == null ? "-" : value.FromAllInvoice) +
                        '</td>';
                    event_data += '<td style="text-align:center;vertical-align: text-top">' +
                        (value.ToAllInvoice == null ? "-" : value.ToAllInvoice) +
                        '</td>';
                    event_data += '<td style="text-align:center;vertical-align: text-top">' +
                        value.TotalAllInvoice +
                        '</td>';
                    event_data += '<td style="text-align:center;vertical-align: text-top">' +
                        value.TotalIssued +
                        '</td>';
                    event_data += '<td style="text-align:center;vertical-align: text-top">-</td>';
                    event_data += '<td style="text-align:center;vertical-align: text-top">-</td>';
                    event_data += '<td style="text-align:center;vertical-align: text-top">-</td>';
                    event_data += '<td style="text-align:center;vertical-align: text-top">-</td>';
                    event_data += '<td style="text-align:center;vertical-align: text-top">' +
                        value.TotalCanceled +
                        '</td>';

                    event_data += '<td style="text-align:center;vertical-align: text-top">'
                  
                    //$.each(value.ListCanceled, function (i) {
                    //    $.each(value.ListCanceled[i], function (key, val) {
                    //        alert(val);
                    //    });
                    //})
                   
                    ';</td>';
                    event_data += ' <td style="width:20px;text-align:center;vertical-align: text-top" class="text">' +
                        (value.FromClosingStock == null ? "1" : value.FromClosingStock) +
                        '</td>';
                    event_data += ' <td style="width:20px;text-align:center;vertical-align: text-top" class="text">' +
                        (value.ToClosingStock == null ? "-" : value.ToClosingStock) +
                        '</td>';
                    event_data += ' <td style="width:20px;text-align:center;vertical-align: text-top" class="text">' +
                        value.TotalClosingStock +
                        '</td>';
                    event_data += '</tr>';
                });
            $("#reportTable").append(event_data);
        }
    });
})
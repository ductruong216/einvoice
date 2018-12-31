// Create Invoice
function IsRelease(button) {
    if (button === "submitInvoice") {
        return false;
    }
    else if (button === "save_and_release") {
        return true;
    }
};

function NewInvoiceCore(isRelease) {
    var items = [];
    var count = $('#goodsTable tr').length;
    for (var i = 1; i < count; ++i) {
        if ($('#productCode' + i).val().trim() !== "" && $('#productId' + i).val().trim() !== "") {
            var item = {
                ProductId: $('#productId' + i).val(),
                ItemName: $('#name' + i).val(),
                ItemPrice: $('#price' + i).val(),
                UnitName: $('#unit' + i).val(),
                Quantity: $('#qty' + i).val(),
                TotalAmount: $('#total' + i).val()
            };

            items.push(item);
        }
    }
    $.ajax({
        type: "POST",
        dataType: "JSON",
        url: '/Invoice/Create',
        data: {
            isRelease: isRelease,
            Tax: $('#tax').val(),
            TaxAmount: $('#tax_amount').val(),
            SubTotalAmount: $('#sub_total').val(),
            GrandTotalAmount: $('#total_amount').val(),
            PatternId: parseInt($('#pattern').val(), 10),
            SeriesId: $('#series').val(),
            No: $('#no').val(),
            CreatedDate: $('.date').val(),
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
        success: function (response) {
            debugger
            if (response.Success) {
                if (isRelease === false) {
                    swal({
                        title: "New Invoice",
                        text: response.Message,
                        icon: "success",
                        buttons: false,
                        timer: 1500
                    }).then(function () {
                        window.location.href = "/Invoice/List";
                    });
                } else {
                    swal({
                        title: "Issue Invoice",
                        text: response.Message,
                        icon: "success",
                        buttons: false,
                        timer: 1500
                    }).then(function () {
                        window.location.href = "/Invoice/List";
                    });
                }

            } else {
                swal({
                    title: "New Invoice",
                    text: response.Message,
                    icon: "error",
                    buttons: false,
                    timer: 2000
                });
            }
        },
        error: function(error) {
          console.log(error)
        }
    });
}
function CreateInvoice(button) {
    var isRelease = IsRelease(button);
    $("#" + button).click(function () {
        if (isRelease === false) {
            NewInvoiceCore(isRelease);
        }
        else {
            swal({
                title: "Do you want to save then issue this invoice?",
                icon: "info",
                buttons: true,
            }).then((isConfirm) => {
                if (isConfirm) {
                    swal({
                        title: "Sign an invoice",
                        icon: "info",
                        content: {
                            element: "input",
                            attributes: {
                                placeholder: "Type your PIN",
                                type: "password",
                            },
                        }
                    }).then((isConfirm) => {
                        if (isConfirm) {
                            NewInvoiceCore(isRelease);
                        }
                    })
                }
            });
        }

    });
}
CreateInvoice("submitInvoice");
CreateInvoice("save_and_release");

//function replaceAndIssue() {
//    swal({
//        title: "Do you wanna save then issue this invoice",
//        icon: "info",
//        buttons: true,
//    }).then((isConfirm) => {
//        if (isConfirm) {
//            swal({
//                title: "Sign an invoice",
//                icon: "info",
//                content: {
//                    element: "input",
//                    attributes: {
//                        placeholder: "Type your PIN",
//                        type: "password",
//                    },
//                }
//            }).then((isConfirm) => {
//                if (isConfirm) {
//                    NewInvoiceCore(null, true);
//                }
//            })
//        }
//    });
//}


//Edit Invoice
$(document).ready(function () {
    $("#submitEditInvoice").click(function () {
        var items = [];
        var count = $('#goodsTable tr').length;
        for (var i = 1; i < count; ++i) {
            if ($('#productCode' + i).val() !== "" && $('#productId' + i).val() !== "") {
                var item = {
                    ProductId: $('#productId' + i).val(),
                    ItemName: $('#name' + i).val(),
                    ItemPrice: $('#price' + i).val(),
                    UnitName: $('#unit' + i).val(),
                    Quantity: $('#qty' + i).val(),
                    TotalAmount: $('#total' + i).val()
                };
                items.push(item);
            }
        }
        $.ajax({
            type: "POST",
            dataType: "json",
            url: '/Invoice/Edit',
            data: {
                isRelease: false,
                Tax: $('#tax').val(),
                PurchaserCustomerID: $('#PurchaserCustomerID').val(),
                CompanyID: $('#CompanyId').val(),
                TaxAmount: $('#tax_amount').val(),
                ProductId: $('#tax_amount').val(),
                ID: $('#ID').val(),
                SubTotalAmount: $('#sub_total').val(),
                GrandTotalAmount: $('#total_amount').val(),
                PatternId: parseInt($('#pattern').val(), 10),
                SeriesId: $('#series').val(),
                No: $('#no').val(),
                CreatedDate: $('.date').val(),
                PurchaserCustomer: {
                    Code: $('#CusCode').val(),
                    Purchaser: $('#purchaser').val(),
                    EnterpriseName: $('#companyName').val(),
                    TaxCode: $('#taxCode').val(),
                    Address: $('#address').val(),
                    Email: $('#email').val(),
                    Phone: $('#phone').val()
                },
                Status: "Draft",
                Customer: {
                    ID: $('#CustomerId').val()
                },

                CustomerId: $('#customerId').val(),

                Items: items,

                PaymentTypeID:
					$('#paymentType').val()
				,
                Note: $('#note').val()
            },
            success: function (response) {
                if (response.Success) {
                    swal({
                        title: "Edit Invoice",
                        text: response.Message,
                        icon: "success",
                        buttons: false,
                        timer: 1500
                    }).then(function () {
                        window.location.href = "/Invoice/List";
                    });
                } else {
                    swal({
                        title: "Edit Invoice",
                        text: response.Message,
                        icon: "error",
                        buttons: false,
                        timer: 2000
                    });
                }
            }
        });
    });
});

// Confirm Delete Invoice
function deleteInvoice(id) {
    swal({
        title: "Do you want to delete this invoice?",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((isConfirm) => {
        if (isConfirm) {
            $.ajax({
                type: "POST",
                url: "/Invoice/Delete/" + id,
                success: function (data) {
                    if (data.Success === true) {
                        swal({
                            title: "Delete Invoice",
                            text: data.Message,
                            icon: "success",
                            buttons: false,
                            timer: 1500
                        }).then(function () {
                            DraftInvoice.Refresh();
                            ReleaseGrid.Refresh();
                        });
                    } else {
                        swal({
                            title: "Delete Invoice",
                            text: data.Message,
                            icon: "error",
                            buttons: false,
                            timer: 1500
                        });
                    }
                }
            });
        }
    });
}


function Release(id) {
    swal({
        title: "Do you want to issue this invoice?",
        icon: "info",
        buttons: true,
        dangerMode: true
    }).then((isConfirm) => {
        if (isConfirm) {
            swal({
                title: "Sign an invoice",
                icon: "info",
                content: {
                    element: "input",
                    attributes: {
                        placeholder: "Type your PIN",
                        type: "password",
                    },
                }
            }).then((isConfirm) => {
                if (isConfirm) {
                    $.ajax({
                        type: "POST",
                        url: "/Invoice/ReleaseInvoice/" + id,
                        success: function (data) {
                            if (data.Success === true) {
                                swal({
                                    title: "Issue Invoice",
                                    text: data.Message,
                                    icon: "success",
                                    buttons: false,
                                    timer: 1500

                                }).then(function () {
                                    ReleaseGrid.Refresh();
                                    DraftInvoice.Refresh();
                                    ListInvoice.SetActiveTabIndex(1);

                                });
                            } else {
                                swal({
                                    title: "Issue Invoice",
                                    text: data.Message,
                                    icon: "error",
                                    buttons: false,
                                    timer: 1500
                                });
                            }
                        }
                    });
                }
            })
        }
    });
}

function viewInvoice(id) {
    swal({
        title: "Do you want to release this invoice?",
        icon: "info",
        buttons: true,
        dangerMode: true
    }).then((isConfirm) => {
        if (isConfirm) {
            $.ajax({
                type: "POST",
                url: "/Invoice/ReleaseInvoice/" + id,
                success: function (data) {
                    if (data.Success === true) {
                        swal({
                            title: "Release Invoice",
                            text: data.Message,
                            icon: "success",
                            buttons: false,
                            timer: 1500

                        }).then(function () {
                            ReleaseGrid.Refresh();
                            DraftInvoice.Refresh();
                            ListInvoice.SetActiveTabIndex(1);

                        });
                    } else {
                        swal({
                            title: "Release Invoice",
                            text: data.Message,
                            icon: "error",
                            buttons: false,
                            timer: 1500
                        });
                    }
                }
            });

        }
    });
}

// Start Select Pattern and Serial
function PopulateDropDown(url, data, type) {
    return $.ajax({
        url: url,
        type: type ? type : 'GET',
        data: data,
        contentType: 'application/json'
    });
}

PopulateDropDown('/Invoice/GetAllPattern', null).done(function (response) {
    if (response.length > 0) {
        $('#pattern').html('');
        var options = '';
        options += '<option value="Select">Select</option>';
        for (var i = 0; i < response.length; i++) {
            options += '<option value="' + response[i].Value + '">' + response[i].Text + '</option>';
        }
        $('#pattern').append(options);
    }
}).fail(function (error) {
    //alert(error.StatusText);
});

$(document).ready(function () {
    $('#pattern').on("change", function () {
        var pattern = $('#pattern').val();
        var obj = { patternId: pattern };

        PopulateDropDown('/Invoice/GetSerial', JSON.stringify(obj), 'POST').done(function (response) {
            if (response.length > 0) {
                $('#series').html('');
                var options = '';
                options += '<option value="Select">Select</option>';
                for (var i = 0; i < response.length; i++) {
                    options += '<option value="' + response[i].Value + '">' + response[i].Text + '</option>';
                }
                $('#series').append(options);
            }

        }).fail(function (error) {
            $('#series').html('<option value="Select">Select</option>');
        });
    });
});

// End Select Pattern and Serial

$(document).ready(function () {
    $("#find_company").click(function () {
        $.ajax({
            url: "/Customer/GetCompanyOnline",
            type: "GET",
            dataType: "json",
            data: { taxCode: $('#taxCode').val() },
            success: function (data) {
                var obj = JSON.parse(data);
                $("#companyName").val(obj.Title);
                $("#address").val(obj.DiaChiCongTy);
            }
        });
    });
});


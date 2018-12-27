function alertReplace() {
    return swal({
        title: "If you want to replace this invoice you must cancel it first",
        icon: "warning",
        buttons: true,
        dangerMode: true
    })
}

function AjaxDestroyInvoice() {
    return $.ajax({
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

function CancelAndReplace(invoiceId) {
    return $.ajax({
        type: "POST",
        url: "/Invoice/ReplaceIssuedInvoice",
        data: { invoiceId: invoiceId },
        success: function (data) {
            debugger
            if (data.Success === true) {
                swal({
                    title: "Cancel Invoice",
                    text: data.Message,
                    icon: "success",
                    buttons: false,
                    timer: 1500
                }).then(function () {
                    DraftInvoice.Refresh();
                    ReleaseGrid.Refresh();
                    window.location.href = "/Invoice/Replace/" + invoiceId;
                });
            } else {
                swal({
                    title: "Cancel Invoice",
                    text: data.Message,
                    icon: "error",
                    buttons: false,
                    timer: 1500
                });
            }
        }
    });
}

function CheckPassword(invoiceId, password) {
    return $.ajax({
        url: "/User/CheckPassword",
        type: "POST",
        data: { password: password },
        dataType: "JSON",
        success: function (response) {
            if (response.Success === true) {
                CancelAndReplace(invoiceId)
            } else {
                swal({
                    title: "Wrong password",
                    text: response.Message,
                    icon: "error",
                    buttons: false,
                    timer: 2000
                });
            }
        }
    });
}

function inputUserPassword(invoiceId) {
    return swal({
        title: "Enter your password to continue",
        icon: "info",
        content: {
            element: "input",
            attributes: {
                placeholder: "Type your password",
                type: "password",
            },
        }
    }).then((value) => {
        CheckPassword(invoiceId, value)
    })
}

function replaceInvoice(id) {
    alertReplace().then((isConfirm) => {
        if (isConfirm) {
            inputUserPassword(id)
        }
    });
};

// Replace invoice
function CreateInvoice(button) {
    var isRelease = IsRelease(button);

}

function New_ReplaceInvoice() {
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
        url: '/Invoice/NewReplace',
        data: {
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
                    title: "Replace Invoice",
                    text: response.Message,
                    icon: "success",
                    buttons: false,
                    timer: 1500
                }).then(function () {
                    window.location.href = "/Invoice/List";
                });
            } else {
                swal({
                    title: "Replace Invoice",
                    text: response.Message,
                    icon: "error",
                    buttons: false,
                    timer: 2000
                });
            }
        }
    });
}
function ReplaceInvoice() {
    swal({
        title: "Do you want to replace invoice by issue this invoice?",
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
                    New_ReplaceInvoice();
                }
            })
        }
    });
}

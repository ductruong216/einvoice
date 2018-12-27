function alertReplace() {
    return swal({
        title: "If you want to cancel this invoice you must replace by another invoice",
        icon: "warning",
        buttons: true,
        dangerMode: true
    })
}

function aleartConfrimCancel() {
    return swal({
        title: "Do you want to cancel this invoice?",
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
        url: "/Invoice/CancelIssuedInvoice",
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
                    window.location.href = "/Invoice/Create";
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
            debugger
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

function cancelInvoice(id) {
    aleartConfrimCancel().then((isConfirm) => {
        if (isConfirm) {
            alertReplace().then((isConfirm) => {
                if (isConfirm) {
                    inputUserPassword(id)
                }
            })
        }
    });
}
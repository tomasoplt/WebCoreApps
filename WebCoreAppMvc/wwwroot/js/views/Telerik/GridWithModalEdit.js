var wndKendo;
var grid;

function editRecord(e) {
    e.preventDefault();

    var dataItem = this.dataItem($(e.currentTarget).closest("tr"));
    var url = "/Telerik/GridWithModalEditPopup/" + dataItem.DepartmentID;

    if (typeof wndKendo === 'undefined') {
        wndKendo = $("#DepartmentDetails").getKendoWindow();
        grid = $("#Grid").data("kendoGrid");
    }

    wndKendo.refresh({
        url: url
    });

    wndKendo.center();
    wndKendo.open();
}

function onActivate(e) {

    var $closeButton = wndKendo.element.find('.close-button');
    var $saveButton = wndKendo.element.find('.save-button');

    $closeButton.prop('disabled', false);
    $saveButton.prop('disabled', false);

    $closeButton.click(function (e) {
        e.preventDefault();
        wndKendo.close();
    });

    $saveButton.click(function (e) {

        e.preventDefault();

        url = wndKendo.element.find('form').attr('action');
        formData = wndKendo.element.find('form').serialize();
        verificationToken = $('input:hidden[name="__RequestVerificationToken"]').val();

        $.ajax({
            url: url,
            data: formData,
            type: 'POST',
            headers: {
                "ANTI-XSRF-TOKEN": verificationToken
            },
            success: function (ajaxData) {
                wndKendo.close();
                grid.dataSource.read();
            },
            error: function (xhr, ajaxOptions, thrownError) {
                alert(thrownError);
            }
        });
    });
}

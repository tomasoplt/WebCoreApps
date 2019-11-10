var wndKendo;

function editRecord(e) {
    e.preventDefault();

    var dataItem = this.dataItem($(e.currentTarget).closest("tr"));
    var url = "/Telerik/BasicGridProductDetail/" + dataItem.ProductID;
    wndKendo = $("#ProductDetails").getKendoWindow();
    wndKendo.refresh({
        url: url
    });

    wndKendo.center();
    wndKendo.open();
}

function onActivate(e) {
    var $closeButton = wndKendo.element.find('.close-button');
    $closeButton.click(function (e) {
        wndKendo.close();
    });

}

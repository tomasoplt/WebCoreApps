//var wndKendo;

//function editRecord(e) {
//    e.preventDefault();

//    var dataItem = this.dataItem($(e.currentTarget).closest("tr"));
//    var url = "/Telerik/BasicGridProductDetail/" + dataItem.ProductID;

//    if (typeof wndKendo === 'undefined') {
//        wndKendo = $("#ProductDetails").getKendoWindow();
//    }

//    wndKendo.refresh({
//        url: url
//    });

//    wndKendo.center();
//    wndKendo.open();
//}

//function onActivate(e) {
//    var $closeButton = wndKendo.element.find('.close-button');
//    var $saveButton = wndKendo.element.find('.save-button');

//    $closeButton.prop('disabled', false);
//    $saveButton.prop('disabled', false);

//    $closeButton.click(function (e) {
//        wndKendo.close();
//    });

//}

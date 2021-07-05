var mainContent;
var titleContent;

$(function () {

    mainContent = $("#MainContent"); /// render partial views.  
    titleContent = $("title"); // render titles.  
});

var routingApp = $.sammy("#MainContent", function () {

    this.get("/ItemDetails/Index", function (context) {
        titleContent.html("Item Details");
        $.get("/ItemDetails/Index", function (data) {
            $('#itemDetailsDivContainer').html(data);
        });
    });

    this.get("/Bidder/Index", function (context) {

        titleContent.html("Bidder");
        $.get("/Bidder/Index", function (data) {
            $('#bidderDivContainer').html(data);
        });
    });

    this.get("/BidDetails/Index", function (context) {

        titleContent.html("Bidders");
        $.get("/BidDetails/Index", function (data) {
            $('#bidDetailsDivContainer').html(data);
        });
    });

    this.get("/Winner/Index", function (context) {

        titleContent.html("Bidders");
        $.get("/Winner/Index", function (data) {
            $('#winnerDivContainer').html(data);
        });
    });


    this.post("/BidDetails/SaveAuctionDetails", function (context) {

        titleContent.html("Save Auction");
        
        $.post("/BidDetails/SaveAuctionDetails", bidAutionDetailsVM, function (data) {
            $('#message').html('Auction data saved successfully.');

            $('#btnSave').prop('disabled', '');
        });
    });

});

$(function () {
   GetItemDetailsForm();
});


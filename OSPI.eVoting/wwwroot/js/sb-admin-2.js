$(function() {

    $('#side-menu').metisMenu(); 

    $('#tbl_user').dataTable({
        responsive: true,
        "columnDefs": [
            { "orderable": false, "targets": 0 }
        ]
    });
    $("#chkuser_all").click(function () {
        $('#tbl_user tbody input[type="checkbox"]').prop('checked', this.checked);
    });
    $("#tbl_user").find("thead th").removeClass("sorting_asc");

    $("#chkaccounttype_all").click(function () {
        $('#tbl_accounttype tbody input[type="checkbox"]').prop('checked', this.checked);
    });
    $('#tbl_accounttype').dataTable({
        responsive: true,
        "columnDefs": [
            { "orderable": false, "targets": 0 }
        ]
    });
    $("#tbl_accounttype").find("thead th").removeClass("sorting_asc");

    $('#tbl_company').dataTable({
        responsive: true,
        "columnDefs": [
            { "orderable": false, "targets": 0 }
        ]
    });
    $("#tbl_company").find("thead th").removeClass("sorting_asc");

    $('#tbl_CofAccount').dataTable({
        responsive: true,
        "columnDefs": [
            { "orderable": false, "targets": 0 }
        ]
    });
    $("#tbl_CofAccount").find("thead th").removeClass("sorting_asc");

    $("#chkcompany_all").click(function () {
        $('#tbl_company tbody input[type="checkbox"]').prop('checked', this.checked);
    });
    $("#chkCofAccount_all").click(function () {
        $('#tbl_CofAccount tbody input[type="checkbox"]').prop('checked', this.checked);
    });
    
    $('.datepicker').datepicker({
        format: 'dd/mm/yyyy',
        autoclose: true,
        startDate: '0d'
    });
    $('#tbl_profitcenteraccount').dataTable({
        responsive: true,
        "columnDefs": [
            { "orderable": false, "targets": 0 }
        ]
    });
    $("#tbl_profitcenteraccount").find("thead th").removeClass("sorting_asc");
    $("#chkprofitcenteraccount_all").click(function () {
        $('#tbl_profitcenteraccount tbody input[type="checkbox"]').prop('checked', this.checked);
    });

    $("#tbl_Positions").find("thead th").removeClass("sorting_asc");

    $("#chktbl_Positions_all").click(function () {
        $('#tbl_Positions tbody input[type="checkbox"]').prop('checked', this.checked);
    });
    $('#tbl_Edittbl_Positions').dataTable({
        responsive: true,
        "columnDefs": [
            { "orderable": false, "targets": 0 }
        ]
    });
    
});
$(function () {
    $("#btnShowPopup").click(function () { 
        $("#myModal").modal();
    });
})

 

//Loads the correct sidebar on window load,
//collapses the sidebar on window resize.
// Sets the min-height of #page-wrapper to window size
$(function() {
    $(window).bind("load resize", function() {
        topOffset = 50;
        width = (this.window.innerWidth > 0) ? this.window.innerWidth : this.screen.width;
        if (width < 768) {
            $('div.navbar-collapse').addClass('collapse');
            topOffset = 100; // 2-row-menu
        } else {
            $('div.navbar-collapse').removeClass('collapse');
        }

        height = ((this.window.innerHeight > 0) ? this.window.innerHeight : this.screen.height) - 1;
        height = height - topOffset;
        if (height < 1) height = 1;
        if (height > topOffset) {
            $("#page-wrapper").css("min-height", (height) + "px");
        }
    });

    //var url = window.location;
    //var element = $('ul.nav a').filter(function() {
    //    return this.href == url || url.href.indexOf(this.href) == 0;
    //}).addClass('active').parent().parent().addClass('in').parent();
    //if (element.is('li')) {
    //    element.addClass('active');
    //}
});

$(function() {

    $('#side-menu').metisMenu(); 

    $('#tbl_eBallots').dataTable({
        responsive: true,
        "columnDefs": [
            { "orderable": false, "targets": 0 }
        ]
    });
    $("#chkeBallots_all").click(function () {
        $('#tbl_eBallots tbody input[type="checkbox"]').prop('checked', this.checked);
    });
    $("#tbl_eBallots").find("thead th").removeClass("sorting_asc");

    

    $('#tbl_Members').dataTable({
        responsive: true,
        "columnDefs": [
            { "orderable": false, "targets": 0 }
        ]
    });
  
    $("#tbl_Members").find("thead th").removeClass("sorting_asc");

    $("#chkMembers_all").click(function () {
        $('#tbl_Members tbody input[type="checkbox"]').prop('checked', this.checked);
    });
    
    $('.datepicker').datepicker({
        format: 'mm/dd/yyyy ',
        autoclose: true,
        startDate: '0d'
    });
    $(".datepicker").datepicker().datepicker("setDate", new Date());
 
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

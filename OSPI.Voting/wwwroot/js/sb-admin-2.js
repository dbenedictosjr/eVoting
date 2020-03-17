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
    $('#tbl_AddRoles').dataTable({
        responsive: true,
        
    });
    $('#tbl_Roles').dataTable({
        responsive: true,
        "columnDefs": [
            { "orderable": false, "targets": 0 }
        ]
    });
    $('.editdatepicker').datepicker({
        format: 'mm/dd/yyyy',
        autoclose: true,
        startDate: '0d'
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
 
    function format(d) {
       
        var tableTR = '';
        $.each(d, function (i, v) {

            tableTR += '<tr>' +
                '<td>' + "<input type ='checkbox' class='checkcount'>" + '</td>' +
                '<td>' + "<img src='" + v.candidateMemberNo + "' style='width:70px'>" + '</td>' +
                '<td>' +v.candidateFirstName + '</td>' +
                '</tr>'

        });
        return '<table cellpadding="5" cellspacing="0" border="0" style="padding-left:50px;">' +
            (tableTR === '' ? "<tr><td>NA</td></tr>" : tableTR) +
            '</table>';
    }
    //Serer Side datatable
    var tableDemo = $('#tbl_test').DataTable({
        responsive: {
            details: {
                type: 'column',
                target: 'tr'
            }
        },
        columnDefs: [{
            className: 'details-control',
            orderable: false,
            bSortable: false,
            bSearchable: false,
            targets: 0
        }
        ],
        order: [1, 'asc']
    });

   
    $('#tbl_test tbody').on('click', 'td.details-control', function () {
        var tr = $(this).closest('tr');
        var row = tableDemo.row(tr);

        if (row.child.isShown()) {
            // This row is already open - close it
            row.child.hide();
            tr.removeClass('shown');
        }
        else {
            $.get("/Elections/Test?PositionId=" + this.id, function (result) {
                if (result.length > 0) {
                    if (result && result !== 'undefined') {
                        
                        row.child(format(result)).show();
                            tr.addClass('shown');
                        

                    }
                    else {
                        if ($('chk_' + id).is(":checked")) {
                            $(this).removeAttr("checked");
                        }
                    }
                }
                else
                {
                    alert("No data found");
                }
            });
            // 
        }
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

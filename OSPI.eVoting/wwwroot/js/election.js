$(function () {
    $("#txtCandidates").change(function () {
        var _val = $(this).val();
        if (!(/^\s*(?=.*[1-9])\d*(?:\.\d{1,2})?\s*$/.test(_val))) {
            $("#spn_candidates").html('Invalid value(Please enter only Numeric and Decimal value)');
            return false;
        }
        if (_val != "" && _val != 0) {
            $("#spn_candidates").html(" ");
        }
    })
    var _gridData = [];
    var _data;
    _data = $('#tbl_Positions').DataTable({
        "searching": false,
        "lengthChange": false,
        responsive: true,
        "columnDefs": [
            { "orderable": false, "targets": 0, "class": "text-left" }
        ]
    });
    $("#btnsave").click(function () {
        //bind all model value in model.
        var positionname = $("#txtPosition").val();
        var candidates = $("#txtCandidates").val();
        if (!(/^\s*(?=.*[1-9])\d*(?:\.\d{1,2})?\s*$/.test(candidates))) {
            $("#spn_candidates").html('Invalid value(Please enter only Numeric value)');
            return false;
        }
        if (candidates == "" || candidates == 0) {
            $("#spn_candidates").html("Required candidates is required.")
            return false;
        }
        var qualifications = $("#txtQualifications").val();

        _gridData.push({
            'PositionName': positionname, 'RequiredCandidates': parseInt(candidates), 'Qualifications': qualifications
        })
        _data.row.add([positionname, candidates, qualifications,'<a onclick="Delete(this)" data-id="new"> <i class="fa fa-trash" aria-hidden="true"></i></a>'])
            .draw()
            .node();
        $("#AddPositionModal").modal("hide");
        $("#txtPosition").val('');
        $("#txtCandidates").val(0);
        $("#txtQualifications").val('');
    })
    $("#btncreate").click(function () {
        var vRefCode = $("#RefCode").val();
        var vDescription = $("#Description").val();
        var vRegStartDate = $("#RegStartDate").datepicker("getDate");
        var vRegEndDate = $("#RegEndDate").datepicker("getDate");
        var vVotingStartDate = $("#VotingStartDate").datepicker("getDate");
        var vVotingEndDate = $("#VotingEndDate").datepicker("getDate");
        var election = {
            'RefCode': vRefCode, 'Description': vDescription, 'RegStartDate': vRegStartDate, 'RegEndDate': vRegEndDate, 'VotingStartDate': vVotingStartDate, 'VotingEndDate': vVotingEndDate, 'JPositions': _gridData
        };
       
        $.ajax({
            type: 'POST',
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            url: '/Elections/Create',
            data: JSON.stringify(election),

            success: function (data) {
                alert("Record has been inserted successfully.");
                location.href = "/Elections/Index";
            },
            error: function (data) {

                alert(data.responseText);
            },
            failure: function (data) {

                alert(data.responseText);
            },
        });
    })
    $("#btnedit").click(function () {
        var vRefCode = $("#RefCode").val();
        var vDescription = $("#Description").val();
        var vRegStartDate = $("#RegStartDate").datepicker("getDate");
        var vRegEndDate = $("#RegEndDate").datepicker("getDate");
        var vVotingStartDate = $("#VotingStartDate").datepicker("getDate");
        var vVotingEndDate = $("#VotingEndDate").datepicker("getDate");
        var vElectionID = $("#ElectionID").val();
        var vRowVersion = $("#RowVersion").val();
        var election = {
            'ElectionID': vElectionID, 'RefCode': vRefCode, 'Description': vDescription, 'RegStartDate': vRegStartDate, 'RegEndDate': vRegEndDate, 'VotingStartDate': vVotingStartDate, 'VotingEndDate': vVotingEndDate, 'RowVersion': vRowVersion, 'JPositions': _gridData
        };
         
        $.ajax({
            type: 'POST',
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            url: '/Elections/Edit',
            data: JSON.stringify(election),

            success: function (data) {
                alert("Record has been edited successfully.");
                location.href = "/Elections/Index";
            },
            error: function (data) {

                alert(data.responseText);
            },
            failure: function (data) {

                alert(data.responseText);
            },
        });
    })

 


});
function Delete(e) {  
    var row = e.closest("tr");
    var id = e.dataset.id;
    if (id != "new") {
        if (confirm('Are you sure you want to delete this?')) {

            $.ajax({
                type: 'GET',
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                url: '/Elections/Delete',
                data: { 'id': id },

                success: function (data) {
                    row.remove();
                    alert("Record has been deleted successfully."); 
                },
                error: function (data) {

                    alert(data.responseText);
                },
                failure: function (data) {

                    alert(data.responseText);
                },
            });

        }
    }
    else
    {
        row.remove();
        alert("Record has been deleted successfully.");
    }

} 
$(function () { 
    $('#RegStartDate').datetimepicker({
       
        format: 'DD-MM-YYYY hh:mm:ss',
        autoclose: true,
        numberOfMonths: [1, 1]
    }); 
    $('#RegEndDate').datetimepicker({
        
        format: 'DD/MM/YYYY h:mm:ss',
        autoclose: true,
        numberOfMonths: [1, 1]
    }); 
    $('#VotingStartDate').datetimepicker({
       
        format: 'DD/MM/YYYY h:mm:ss',
        autoclose: true,
        numberOfMonths: [1, 1]
    }); 
    $('#VotingEndDate').datetimepicker({
        
        format: 'DD/MM/YYYY h:mm:ss',
        autoclose: true,
        numberOfMonths: [1, 1]
    }); 
    $("#txtMinimumVotes").change(function () {
        var _min = $(this).val();
        var _max = $("#txtMaximumVotes").val();
        if (!(/^\s*(?=.*[1-9])\d*(?:\.\d{1,2})?\s*$/.test(_min))) {
            $("#spn_minimumvotes").html('Invalid value(Please enter only Numeric and Decimal value)');
            return false;
        }
        if (_max > 0 && _min > _max) {
            $("#spn_minimumvotes").html('Minimum votes should be less than maximum votes');
            return false;
        }
        if ((_min != "" && _min != 0) && (_min <= _max)) {
            $("#spn_minimumvotes").html(" ");
            $("#spn_maximumvotes").html(" ");
        }
    })

    $("#txtMaximumVotes").change(function () {
        var _max = $(this).val();
        var _min = $("#txtMinimumVotes").val();
        if (!(/^\s*(?=.*[1-9])\d*(?:\.\d{1,2})?\s*$/.test(_max))) {
            $("#spn_maximumvotes").html('Invalid value(Please enter only Numeric and Decimal value)');
            return false;
        }
        if (_max > 0 && _min > _max) {
            $("#spn_maximumvotes").html('Maximum votes should greater than minimum votes');
            return false;
        }
        if ((_max != "" && _max != 0) && (_min <= _max)) {
            $("#spn_minimumvotes").html(" ");
            $("#spn_maximumvotes").html(" ");
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
    })

    $("#btnsave").click(function () {
        //bind all model value in model.
        var positionname = $("#txtPosition").val();
        var minimumvotes = $("#txtMinimumVotes").val();
        var maximumvotes = $("#txtMaximumVotes").val();
        var qualifications = $("#txtQualifications").val();

        //Validation for minimum required votes
        if (!(/^\s*(?=.*[1-9])\d*(?:\.\d{1,2})?\s*$/.test(minimumvotes))) {
            $("#spn_minimumvotes").html('Invalid value(Please enter only Numeric value)');
            return false;
        }
        if (minimumvotes == "" || minimumvotes == 0) {
            $("#spn_minimumvotes").html("Minimum votes is required.")
            return false;
        }

        //Validation for maximum votes
        if (!(/^\s*(?=.*[1-9])\d*(?:\.\d{1,2})?\s*$/.test(maximumvotes))) {
            $("#spn_maximumvotes").html('Invalid value(Please enter only Numeric value)');
            return false;
        }
        if (maximumvotes == "" || maximumvotes == 0) {
            $("#spn_maximumvotes").html("Maximum votes is required.")
            return false;
        }

        _gridData.push({
            'PositionName': positionname,
            'MinimumRequiredVotes': parseInt(minimumvotes),
            'MaximumRequiredVotes': parseInt(maximumvotes),
            'Qualifications': qualifications
        });

        _data.row.add([positionname, minimumvotes, maximumvotes, qualifications, '<a onclick="Delete(this)" data-id="new"> <i class="fa fa-trash" aria-hidden="true"></i></a>'])
            .draw()
            .node();
        $("#AddPositionModal").modal("hide");
        $("#txtPosition").val('');
        $("#txtMinimumVotes").val(0);
        $("#txtMaximumVotes").val(0);
        $("#txtQualifications").val('');
    });

    $("#btncreate").click(function () {
        var refcode = $("#RefCode").val();
        var description = $("#Description").val();
        var regstartdate = $("#RegStartDate").datepicker("getDate");
        var regenddate = $("#RegEndDate").datepicker("getDate");
        var votingstartdate = $("#VotingStartDate").datepicker("getDate");
        var votingenddate = $("#VotingEndDate").datepicker("getDate");
        var ballot = {
            'RefCode': refcode,
            'Description': description,
            'EditRegStartDate': regstartdate,
            'EditRegEndDate': regenddate,
            'EditVotingStartDate': votingstartdate,
            'EditVotingEndDate': votingenddate,
            'JPositions': _gridData
        };

        $.ajax({
            type: 'POST',
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            url: '/Ballots/Create',
            data: JSON.stringify(ballot),

            success: function (data) {
                alert("Record has been inserted successfully.");
                location.href = "/Ballots/Index";
            },
            error: function (data) {
                alert(data.responseText);
            },
            failure: function (data) {

                alert(data.responseText);
            },
        });
    });

    $("#btnedit").click(function () {
        var refcode = $("#RefCode").val();
        var description = $("#Description").val();
         
        var regstartdate = $("#RegStartDate").val();
       
        var regenddate = $("#RegEndDate").val();
        var votingstartdate = $("#VotingStartDate").val();
        var votingenddate = $("#VotingEndDate").val();
        var ballotid = $("#BallotId").val();
        var rowversion = $("#RowVersion").val();
        var ballot = {
            'BallotId': ballotid,
            'RefCode': refcode,
            'Description': description, 
            'EditRegStartDate': regstartdate,  
             'EditRegEndDate': regenddate,
             'EditVotingStartDate': votingstartdate,
             'EditVotingEndDate': votingenddate,
            'RowVersion': rowversion,
            'JPositions': _gridData
        };

        $.ajax({
            type: 'POST',
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            url: '/Ballots/Edit',
            data: JSON.stringify(ballot),

            success: function (data) {
                alert("Record has been edited successfully.");
                location.href = "/Ballots/Index";
            },
            error: function (data) {
                alert(data.responseText);
            },
            failure: function (data) {

                alert(data.responseText);
            },
        });
    });
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
                url: '/Ballots/Delete',
                data: { 'id': id },

                success: function (data) {
                    row.remove();
                    alert("Record has been deleted successfully.");
                },
                error: function (data) {
                    if (data.responseText.indexOf('FK_Candidates_Positions_PositionId') > 0) {
                        alert('You can not Delete this Position  because this is assoicated with another Candidates.');
                    }
                    else {
                        alert(data.responseText);
                    }
                    
                },
                failure: function (data) {
                    if (data.responseText.indexOf('FK_Candidates_Positions_PositionId') > 0) {
                        alert('You can not Delete this Position  because this is assoicated with another Candidates.');
                    }
                    else {
                        alert(data.responseText);
                    }
                    
                },
            });
        }
    }
    else {
        row.remove();
        alert("Record has been deleted successfully.");
    }
}
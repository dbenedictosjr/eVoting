$(function () {
    $("#txtMinimumVotes").change(function () {
        var _val = $(this).val();
        if (!(/^\s*(?=.*[1-9])\d*(?:\.\d{1,2})?\s*$/.test(_val))) {
            $("#spn_minimumvotes").html('Invalid value(Please enter only Numeric and Decimal value)');
            return false;
        }
        if (_val != "" && _val != 0) {
            $("#spn_minimumvotes").html(" ");
        }
    })



    $("#txtMaximumVotes").change(function () {
        var _val = $(this).val();
        if (!(/^\s*(?=.*[1-9])\d*(?:\.\d{1,2})?\s*$/.test(_val))) {
            $("#spn_maximumvotes").html('Invalid value(Please enter only Numeric and Decimal value)');
            return false;
        }
        if (_val != "" && _val != 0) {
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
        if (!(/^\s*(?=.*[1-9])\d*(?:\.\d{1,2})?\s*$/.test(candidates))) {
            $("#spn_minimumvotes").html('Invalid value(Please enter only Numeric value)');
            return false;
        }
        if (candidates == "" || candidates == 0) {
            $("#spn_minimumvotes").html("Minimum votes is required.")
            return false;
        }

        //Validation for maximum votes
        if (!(/^\s*(?=.*[1-9])\d*(?:\.\d{1,2})?\s*$/.test(candidates))) {
            $("#spn_maximumvotes").html('Invalid value(Please enter only Numeric value)');
            return false;
        }
        if (candidates == "" || candidates == 0) {
            $("#spn_maximumvotes").html("Maximum votes is required.")
            return false;
        }

        _gridData.push({
            'PositionName': positionname,
            'MinimumRequiredVotes': parseInt(minimumvotes),
            'MaximumRequiredVotes': parseInt(maximumvotes),
            'Qualifications': qualifications
        });

        _data.row.add([positionname, candidates, qualifications, '<a onclick="Delete(this)" data-id="new"> <i class="fa fa-trash" aria-hidden="true"></i></a>'])
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
        var election = {
            'RefCode': refcode,
            'Description': description,
            'RegStartDate': regstartdate,
            'RegEndDate': regenddate,
            'VotingStartDate': votingstartdate,
            'VotingEndDate': votingenddate,
            'JPositions': _gridData
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
    });

    $("#btnedit").click(function () {
        var refcode = $("#RefCode").val();
        var description = $("#Description").val();
        var regstartdate = $("#RegStartDate").datepicker("getDate");
        var regenddate = $("#RegEndDate").datepicker("getDate");
        var votingstartdate = $("#VotingStartDate").datepicker("getDate");
        var votingenddate = $("#VotingEndDate").datepicker("getDate");
        var electionid = $("#ElectionId").val();
        var rowversion = $("#RowVersion").val();
        var election = {
            'ElectionId': electionid,
            'RefCode': refcode,
            'Description': description,
            'RegStartDate': regstartdate,
            'RegEndDate': regenddate,
            'VotingStartDate': votingstartdate,
            'VotingEndDate': votingenddate,
            'RowVersion': rowversion,
            'JPositions': _gridData
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
    else {
        row.remove();
        alert("Record has been deleted successfully.");
    }
}
$(function () {
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
        var qualifications = $("#txtQualifications").val();

        _gridData.push({
            'PositionName': positionname, 'RequiredCandidates': candidates, 'Qualifications': qualifications })
        _data.row.add([positionname, candidates, qualifications])
            .draw()
            .node();
        alert("Record has been added successfully.");
        $("#AddPositionModal").modal("hide");
        $("#txtPosition").val('');
        $("#txtCandidates").val('');
        $("#txtQualifications").val('');
    })
    $("#btnsubmit").click(function () {

        //bind all model value in model.
        var vRefCode = $("#RefCode").val();
        var vDescription = $("#Description").val();
        var vRegStartDate = $("#RegStartDate").val();
        var vRegEndDate = $("#RegEndDate").val();
        var vVotingStartDate = $("#VotingStartDate").val();
        var vVotingEndDate = $("#VotingEndDate").val();
        
        var model = {
            'RefCode': vRefCode, 'Description': vDescription, 'RegStartDate': vRegStartDate, 'vRegStartDate': vRegEndDate, 'VotingStartDate': vVotingStartDate, 'VotingEndDate': vVotingEndDate, 'JPositions': _gridData
        };
        debugger;
        $.ajax({
            type: 'POST',
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            url: '/Elections/Create',
            data: JSON.stringify(model),

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
});